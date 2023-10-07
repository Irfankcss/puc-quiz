using puc_quiz.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puc_quiz.Forms
{
    public partial class frmQuiz : Form
    {
        List<Question> _questions = new List<Question>();
        List<int> ListOfShown = new List<int>();
        Random rnd = new Random();
        Question question=new Question();   
        int randQuestionID;
        int CorrectCounter = 0;
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            MakeTextBackgroundTransparent();


            _questions=GetQuestions();
            NextQuestion();

        }

        private void MakeTextBackgroundTransparent()
        {
            lblQuestionText.AutoSize = true;
            lblQuestionText.MaximumSize = new Size(400, 0);
            lblPoints.Parent = pbBackground;
            lblQuestionText.Parent = pbBackground;
            btnQuestionA.Parent = pbBackground; 
            btnQuestionB.Parent = pbBackground;
            btnQuestionC.Parent = pbBackground;
            btnQuestionD.Parent = pbBackground;
        }

        private void NextQuestion()
        {
            if (ListOfShown.Count == 10)
            {
                this.Close();
            }
            if (ListOfShown.Count() > 0)
            {
                do
                {
                    randQuestionID = rnd.Next(_questions.First().QuestionID, _questions.Last().QuestionID + 1);
                }
                while (isAlreadyShown(randQuestionID));
            }
            else
            {
                randQuestionID = rnd.Next(_questions.First().QuestionID, _questions.Last().QuestionID);
            }
            //    MessageBox.Show(_db.Questions.First().Question_Text);
            List<Question> list = _questions;
            foreach (var id in list)
            {
                if (id.QuestionID == randQuestionID)
                {
                    question = id as Question;
                }
            }
           // lblQuestionText.Text = question.Question_Text + '?';
            lblQuestionText.Text = question.Question_Text as string + "?";
            int spotrnd = rnd.Next(1, 5);
            if (spotrnd == 1)
            {
                
                btnQuestionA.Text = question.Correct_Answer as string;
                btnQuestionB.Text = question.Incorrect_Answer1 as string;
                btnQuestionC.Text = question.Incorrect_Answer2 as string;
                btnQuestionD.Text = question.Incorrect_Answer3 as string;
            }
            else if (spotrnd == 2)
            {
                btnQuestionB.Text = question.Correct_Answer as string;
                btnQuestionA.Text = question.Incorrect_Answer1 as string;
                btnQuestionC.Text = question.Incorrect_Answer2 as string;
                btnQuestionD.Text = question.Incorrect_Answer3 as string;
            }
            else if (spotrnd == 3)
            {
                btnQuestionC.Text = question.Correct_Answer as string;
                btnQuestionA.Text = question.Incorrect_Answer1 as string;
                btnQuestionB.Text = question.Incorrect_Answer2 as string;
                btnQuestionD.Text = question.Incorrect_Answer3 as string;
            }
            else if (spotrnd == 4)
            {
                btnQuestionD.Text = question.Correct_Answer as string;
                btnQuestionA.Text = question.Incorrect_Answer1 as string;
                btnQuestionC.Text = question.Incorrect_Answer2 as string;
                btnQuestionB.Text = question.Incorrect_Answer3 as string;
            }
        }

        private List<Question> GetQuestions()
        {
            string constring = "Data Source=DESKTOP-QRMG5SV;Initial Catalog=Puc_Quiz_Questions.db;Integrated Security=true";
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["dbcon"]);

            List<Question> ques = new List<Question>();

            string sqlQuery = "SELECT * FROM Question";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Question q = new Question
                    {
                        QuestionID = Convert.ToInt32(reader["QuestionID"]),
                        Question_Text = reader["Question_Text"].ToString(),
                        Correct_Answer = reader["Correct_Answer"].ToString(),
                        Incorrect_Answer1 = reader["Incorrect_Answer1"].ToString(),
                        Incorrect_Answer2 = reader["Incorrect_Answer2"].ToString(),
                        Incorrect_Answer3 = reader["Incorrect_Answer3"].ToString(),
                    };

                    ques.Add(q);
                }

                reader.Close();
            }

            connection.Close();
            return ques;
        }

        private bool isAlreadyShown(int id)
        {
            foreach (int ids in ListOfShown)
            {
                if (ids == id)
                    return true;
            }
            return false;
        }

       

        private bool isCorrect(object sender)
        {
            ListOfShown.Add(question.QuestionID);
            string ans = (sender as Button).Text;
            if (ans.ToLower().Equals(question.Correct_Answer.ToLower()))
            {
               ////
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnQuestionA_Click(object sender, EventArgs e)
               {
                   if (isCorrect(sender))
                   {
                       CorrectCounter++;
                       lblPoints.Text = CorrectCounter.ToString();
                       NextQuestion();
                   }
                   NextQuestion();

               }
        private void btnQuestionB_Click(object sender, EventArgs e)
        {
            if (isCorrect(sender))
            {
                CorrectCounter++;
                lblPoints.Text = CorrectCounter.ToString();
                NextQuestion();
            }
            NextQuestion();
        }
        private void btnQuestionC_Click(object sender, EventArgs e)
        {
            if (isCorrect(sender))
            {
                CorrectCounter++;
                lblPoints.Text = CorrectCounter.ToString();
                NextQuestion();
            }
            NextQuestion();
        }
        private void btnQuestionD_Click(object sender, EventArgs e)
        {
            if (isCorrect(sender))
            {
                CorrectCounter++;
                lblPoints.Text = CorrectCounter.ToString();
                NextQuestion();
            }
            NextQuestion();
        }

        private void lblQuestionText_Click(object sender, EventArgs e)
        {

        }
    }
}

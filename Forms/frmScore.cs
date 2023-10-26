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
    public partial class frmScore : Form
    {
        private int score;

        public frmScore()
        {
            InitializeComponent();
        }

        public frmScore(int correctCounter)
        {
            InitializeComponent();
            this.score = correctCounter;
            lblScore.Text = score.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            SaveScoreToDb(name);
        }

        private void SaveScoreToDb(string name)
        {
            
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["dbcon"])) { 
                        connection.Open();

                        string insertQuery = "INSERT INTO Users (Name, Score) VALUES (@Name, @Score)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Score", score);

                            int rowsAffected = cmd.ExecuteNonQuery();
                        }
                        connection.Close();
                        MessageBox.Show("Score successfully saved");
                        frmScoreboard frmScoreBoard = new frmScoreboard();
                        this.Hide();
                        frmScoreBoard.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error while saving score" + e.Message + e.GetType());
                    this.Close();
                //add
                }

        }
    }
}

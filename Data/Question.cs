using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puc_quiz.Data
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Question_Text { get; set; }
        public string Correct_Answer { get; set; }
        public string Incorrect_Answer1 { get; set; }
        public string Incorrect_Answer2 { get; set; }
        public string Incorrect_Answer3 { get; set; }
    }

}

using puc_quiz.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puc_quiz
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newQuiz = new frmQuiz();
            newQuiz.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newLeaderBoard = new frmScoreboard();
            newLeaderBoard.ShowDialog();
            this.Close();
        }
    }
}

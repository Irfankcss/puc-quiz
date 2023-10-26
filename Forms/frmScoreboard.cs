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
    public partial class frmScoreboard : Form
    {
        public frmScoreboard()
        {
            InitializeComponent();
            dgvScoreboard.AutoGenerateColumns = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            ;


            LoadPlayers();
            dgvScoreboard.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvScoreboard.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvScoreboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //dgvScoreboard..AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

        }

        private void LoadPlayers()
        {

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["dbcon"]))
            {
                try
                {
                    connection.Open();
                    string Sqlquery = "SELECT TOP (10) ROW_NUMBER() OVER (ORDER BY [Score] DESC) AS Position,[Name],[Score] FROM [Puc_Quiz_Questions].[dbo].[Users] as U ORDER BY U.Score DESC";
                    using (SqlCommand command = new SqlCommand(Sqlquery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("Position", typeof(int));
                            dataTable.Columns.Add("Name", typeof(string));
                            dataTable.Columns.Add("Score", typeof(int));
                            adapter.Fill(dataTable);
                            dgvScoreboard.DataSource = dataTable;
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dgvScoreboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



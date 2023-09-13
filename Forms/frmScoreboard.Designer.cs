namespace puc_quiz.Forms
{
    partial class frmScoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvScoreboard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScoreboard
            // 
            this.dgvScoreboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreboard.Location = new System.Drawing.Point(61, 48);
            this.dgvScoreboard.Name = "dgvScoreboard";
            this.dgvScoreboard.Size = new System.Drawing.Size(672, 288);
            this.dgvScoreboard.TabIndex = 0;
            // 
            // frmScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvScoreboard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScoreboard";
            this.Text = "Puc Quiz Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreboard;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScoreboard));
            this.dgvScoreboard = new System.Windows.Forms.DataGridView();
            this.lblTop10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblLocal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScoreboard
            // 
            this.dgvScoreboard.AllowUserToAddRows = false;
            this.dgvScoreboard.AllowUserToDeleteRows = false;
            this.dgvScoreboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvScoreboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreboard.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvScoreboard.Location = new System.Drawing.Point(67, 111);
            this.dgvScoreboard.Name = "dgvScoreboard";
            this.dgvScoreboard.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoreboard.RowHeadersWidth = 51;
            this.dgvScoreboard.ShowEditingIcon = false;
            this.dgvScoreboard.Size = new System.Drawing.Size(672, 234);
            this.dgvScoreboard.TabIndex = 0;
            this.dgvScoreboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoreboard_CellContentClick);
            // 
            // lblTop10
            // 
            this.lblTop10.AutoSize = true;
            this.lblTop10.BackColor = System.Drawing.Color.Transparent;
            this.lblTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop10.ForeColor = System.Drawing.Color.White;
            this.lblTop10.Location = new System.Drawing.Point(61, 45);
            this.lblTop10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop10.Name = "lblTop10";
            this.lblTop10.Size = new System.Drawing.Size(106, 31);
            this.lblTop10.TabIndex = 4;
            this.lblTop10.Text = "Top 10:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(178, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.BackgroundImage")));
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(528, 388);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(107, 41);
            this.btnPlayAgain.TabIndex = 6;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(388, 368);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(39, 18);
            this.lblLocal.TabIndex = 7;
            this.lblLocal.Text = "local";
            // 
            // frmScoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::puc_quiz.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTop10);
            this.Controls.Add(this.dgvScoreboard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScoreboard";
            this.Text = "Puc Quiz Leaderboard";
            this.Load += new System.EventHandler(this.frmScoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreboard;
        private System.Windows.Forms.Label lblTop10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblLocal;
    }
}
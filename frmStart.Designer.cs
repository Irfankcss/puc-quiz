namespace puc_quiz
{
    partial class frmStart
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.Location = new System.Drawing.Point(340, 138);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(136, 44);
            this.btnScoreBoard.TabIndex = 1;
            this.btnScoreBoard.Text = "Leaderboard";
            this.btnScoreBoard.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScoreBoard);
            this.Controls.Add(this.btnStart);
            this.Name = "frmStart";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.Button btnExit;
    }
}


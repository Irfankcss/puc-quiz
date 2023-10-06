namespace puc_quiz.Forms
{
    partial class frmQuiz
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
            this.btnQuestionA = new System.Windows.Forms.Button();
            this.btnQuestionB = new System.Windows.Forms.Button();
            this.btnQuestionC = new System.Windows.Forms.Button();
            this.btnQuestionD = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuestionA
            // 
            this.btnQuestionA.Location = new System.Drawing.Point(102, 196);
            this.btnQuestionA.Name = "btnQuestionA";
            this.btnQuestionA.Size = new System.Drawing.Size(146, 41);
            this.btnQuestionA.TabIndex = 0;
            this.btnQuestionA.Text = "Question A";
            this.btnQuestionA.UseVisualStyleBackColor = true;
            this.btnQuestionA.Click += new System.EventHandler(this.btnQuestionA_Click);
            // 
            // btnQuestionB
            // 
            this.btnQuestionB.Location = new System.Drawing.Point(270, 196);
            this.btnQuestionB.Name = "btnQuestionB";
            this.btnQuestionB.Size = new System.Drawing.Size(146, 41);
            this.btnQuestionB.TabIndex = 1;
            this.btnQuestionB.Text = "Question B";
            this.btnQuestionB.UseVisualStyleBackColor = true;
            this.btnQuestionB.Click += new System.EventHandler(this.btnQuestionB_Click);
            // 
            // btnQuestionC
            // 
            this.btnQuestionC.Location = new System.Drawing.Point(102, 255);
            this.btnQuestionC.Name = "btnQuestionC";
            this.btnQuestionC.Size = new System.Drawing.Size(146, 41);
            this.btnQuestionC.TabIndex = 2;
            this.btnQuestionC.Text = "Question C";
            this.btnQuestionC.UseVisualStyleBackColor = true;
            this.btnQuestionC.Click += new System.EventHandler(this.btnQuestionC_Click);
            // 
            // btnQuestionD
            // 
            this.btnQuestionD.Location = new System.Drawing.Point(270, 255);
            this.btnQuestionD.Name = "btnQuestionD";
            this.btnQuestionD.Size = new System.Drawing.Size(146, 41);
            this.btnQuestionD.TabIndex = 3;
            this.btnQuestionD.Text = "Question D";
            this.btnQuestionD.UseVisualStyleBackColor = true;
            this.btnQuestionD.Click += new System.EventHandler(this.btnQuestionD_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(99, 72);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(73, 13);
            this.lblQuestionText.TabIndex = 4;
            this.lblQuestionText.Text = "Question Text";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(477, 27);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(35, 37);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.btnQuestionD);
            this.Controls.Add(this.btnQuestionC);
            this.Controls.Add(this.btnQuestionB);
            this.Controls.Add(this.btnQuestionA);
            this.Name = "frmQuiz";
            this.Text = "Puc Quiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionA;
        private System.Windows.Forms.Button btnQuestionB;
        private System.Windows.Forms.Button btnQuestionC;
        private System.Windows.Forms.Button btnQuestionD;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblPoints;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.btnQuestionA = new System.Windows.Forms.Button();
            this.btnQuestionB = new System.Windows.Forms.Button();
            this.btnQuestionC = new System.Windows.Forms.Button();
            this.btnQuestionD = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuestionA
            // 
            this.btnQuestionA.BackColor = System.Drawing.Color.Transparent;
            this.btnQuestionA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuestionA.BackgroundImage")));
            this.btnQuestionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuestionA.Location = new System.Drawing.Point(90, 199);
            this.btnQuestionA.Name = "btnQuestionA";
            this.btnQuestionA.Size = new System.Drawing.Size(167, 49);
            this.btnQuestionA.TabIndex = 0;
            this.btnQuestionA.Text = "Question A";
            this.btnQuestionA.UseVisualStyleBackColor = false;
            this.btnQuestionA.Click += new System.EventHandler(this.btnQuestionA_Click);
            // 
            // btnQuestionB
            // 
            this.btnQuestionB.BackColor = System.Drawing.Color.Transparent;
            this.btnQuestionB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuestionB.BackgroundImage")));
            this.btnQuestionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuestionB.Location = new System.Drawing.Point(280, 199);
            this.btnQuestionB.Name = "btnQuestionB";
            this.btnQuestionB.Size = new System.Drawing.Size(167, 49);
            this.btnQuestionB.TabIndex = 1;
            this.btnQuestionB.Text = "Question B";
            this.btnQuestionB.UseVisualStyleBackColor = false;
            this.btnQuestionB.Click += new System.EventHandler(this.btnQuestionB_Click);
            // 
            // btnQuestionC
            // 
            this.btnQuestionC.BackColor = System.Drawing.Color.Transparent;
            this.btnQuestionC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuestionC.BackgroundImage")));
            this.btnQuestionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionC.ForeColor = System.Drawing.Color.White;
            this.btnQuestionC.Location = new System.Drawing.Point(90, 258);
            this.btnQuestionC.Name = "btnQuestionC";
            this.btnQuestionC.Size = new System.Drawing.Size(167, 49);
            this.btnQuestionC.TabIndex = 2;
            this.btnQuestionC.Text = "Question C";
            this.btnQuestionC.UseVisualStyleBackColor = false;
            this.btnQuestionC.Click += new System.EventHandler(this.btnQuestionC_Click);
            // 
            // btnQuestionD
            // 
            this.btnQuestionD.BackColor = System.Drawing.Color.Transparent;
            this.btnQuestionD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuestionD.BackgroundImage")));
            this.btnQuestionD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionD.ForeColor = System.Drawing.Color.White;
            this.btnQuestionD.Location = new System.Drawing.Point(280, 258);
            this.btnQuestionD.Name = "btnQuestionD";
            this.btnQuestionD.Size = new System.Drawing.Size(167, 49);
            this.btnQuestionD.TabIndex = 3;
            this.btnQuestionD.Text = "Question D";
            this.btnQuestionD.UseVisualStyleBackColor = false;
            this.btnQuestionD.Click += new System.EventHandler(this.btnQuestionD_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(86, 78);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(141, 24);
            this.lblQuestionText.TabIndex = 4;
            this.lblQuestionText.Text = "Question Text";
            this.lblQuestionText.Click += new System.EventHandler(this.lblQuestionText_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPoints.Location = new System.Drawing.Point(477, 27);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 37);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbBackground.Image")));
            this.pbBackground.Location = new System.Drawing.Point(-10, -6);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(575, 370);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 6;
            this.pbBackground.TabStop = false;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 359);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.btnQuestionD);
            this.Controls.Add(this.btnQuestionC);
            this.Controls.Add(this.btnQuestionB);
            this.Controls.Add(this.btnQuestionA);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puc Quiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
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
        private System.Windows.Forms.PictureBox pbBackground;
    }
}
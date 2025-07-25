namespace PRG281_Project
{
    partial class AddingDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.scrtyQstn = new System.Windows.Forms.ComboBox();
            this.scrtyLbl = new System.Windows.Forms.Label();
            this.scrtyAnswer = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmboGender = new System.Windows.Forms.ComboBox();
            this.lblBio = new System.Windows.Forms.Label();
            this.rchBio = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCreateProfileHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(61, 118);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(158, 20);
            this.txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(61, 184);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(158, 20);
            this.txtLast.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(237, 435);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 39);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(61, 260);
            this.numAge.Margin = new System.Windows.Forms.Padding(2);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(158, 20);
            this.numAge.TabIndex = 7;
            this.numAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // scrtyQstn
            // 
            this.scrtyQstn.FormattingEnabled = true;
            this.scrtyQstn.Items.AddRange(new object[] {
            "What was the name of your first pet?",
            "In what city were you born?",
            "What is your mother\'s maiden name?",
            "What was the make and model of your first car?",
            "What was the name of your first school?",
            "What is the name of the street you grew up on?",
            "What was your childhood nickname?",
            "What is the name of your favorite childhood friend?",
            "What is the middle name of your oldest sibling?",
            "What was the name of your first employer?"});
            this.scrtyQstn.Location = new System.Drawing.Point(202, 343);
            this.scrtyQstn.Name = "scrtyQstn";
            this.scrtyQstn.Size = new System.Drawing.Size(158, 21);
            this.scrtyQstn.TabIndex = 8;
            // 
            // scrtyLbl
            // 
            this.scrtyLbl.AutoSize = true;
            this.scrtyLbl.Location = new System.Drawing.Point(234, 327);
            this.scrtyLbl.Name = "scrtyLbl";
            this.scrtyLbl.Size = new System.Drawing.Size(90, 13);
            this.scrtyLbl.TabIndex = 9;
            this.scrtyLbl.Text = "Security Question";
            // 
            // scrtyAnswer
            // 
            this.scrtyAnswer.Location = new System.Drawing.Point(202, 385);
            this.scrtyAnswer.Name = "scrtyAnswer";
            this.scrtyAnswer.Size = new System.Drawing.Size(158, 20);
            this.scrtyAnswer.TabIndex = 10;
            this.scrtyAnswer.Text = "answer";
            this.scrtyAnswer.Click += new System.EventHandler(this.scrtyAnswer_TextClick);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(282, 89);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // cmboGender
            // 
            this.cmboGender.FormattingEnabled = true;
            this.cmboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmboGender.Location = new System.Drawing.Point(285, 118);
            this.cmboGender.Name = "cmboGender";
            this.cmboGender.Size = new System.Drawing.Size(215, 21);
            this.cmboGender.TabIndex = 12;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(282, 160);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(22, 13);
            this.lblBio.TabIndex = 13;
            this.lblBio.Text = "Bio";
            // 
            // rchBio
            // 
            this.rchBio.Location = new System.Drawing.Point(285, 184);
            this.rchBio.Name = "rchBio";
            this.rchBio.Size = new System.Drawing.Size(215, 96);
            this.rchBio.TabIndex = 14;
            this.rchBio.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(717, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCreateProfileHeading
            // 
            this.lblCreateProfileHeading.AutoSize = true;
            this.lblCreateProfileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateProfileHeading.Location = new System.Drawing.Point(55, 24);
            this.lblCreateProfileHeading.Name = "lblCreateProfileHeading";
            this.lblCreateProfileHeading.Size = new System.Drawing.Size(291, 33);
            this.lblCreateProfileHeading.TabIndex = 16;
            this.lblCreateProfileHeading.Text = "Create Your Profile!";
            // 
            // AddingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(554, 518);
            this.Controls.Add(this.lblCreateProfileHeading);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rchBio);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.cmboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.scrtyAnswer);
            this.Controls.Add(this.scrtyLbl);
            this.Controls.Add(this.scrtyQstn);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Name = "AddingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingDetails";
            this.Load += new System.EventHandler(this.AddingDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox scrtyQstn;
        private System.Windows.Forms.Label scrtyLbl;
        private System.Windows.Forms.TextBox scrtyAnswer;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmboGender;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.RichTextBox rchBio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCreateProfileHeading;
    }
}
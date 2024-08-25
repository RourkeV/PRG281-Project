namespace PRG281_Project
{
    partial class UserSignUp
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPasswordCon = new System.Windows.Forms.Label();
            this.txtPassCon = new System.Windows.Forms.TextBox();
            this.chkBxShow = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMovePage = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(89, 347);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 35);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(50, 126);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPass.Location = new System.Drawing.Point(50, 201);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(194, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(50, 173);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // lblPasswordCon
            // 
            this.lblPasswordCon.AutoSize = true;
            this.lblPasswordCon.Location = new System.Drawing.Point(50, 245);
            this.lblPasswordCon.Name = "lblPasswordCon";
            this.lblPasswordCon.Size = new System.Drawing.Size(91, 13);
            this.lblPasswordCon.TabIndex = 6;
            this.lblPasswordCon.Text = "Confirm Password";
            // 
            // txtPassCon
            // 
            this.txtPassCon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassCon.Location = new System.Drawing.Point(50, 270);
            this.txtPassCon.Name = "txtPassCon";
            this.txtPassCon.PasswordChar = '*';
            this.txtPassCon.Size = new System.Drawing.Size(194, 20);
            this.txtPassCon.TabIndex = 5;
            // 
            // chkBxShow
            // 
            this.chkBxShow.AutoSize = true;
            this.chkBxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBxShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBxShow.Location = new System.Drawing.Point(117, 308);
            this.chkBxShow.Name = "chkBxShow";
            this.chkBxShow.Size = new System.Drawing.Size(99, 17);
            this.chkBxShow.TabIndex = 7;
            this.chkBxShow.Text = "Show Password";
            this.chkBxShow.UseVisualStyleBackColor = true;
            this.chkBxShow.CheckedChanged += new System.EventHandler(this.chkBxShow_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(77, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(139, 39);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Sign Up";
            // 
            // lblMovePage
            // 
            this.lblMovePage.AutoSize = true;
            this.lblMovePage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMovePage.Location = new System.Drawing.Point(77, 429);
            this.lblMovePage.Name = "lblMovePage";
            this.lblMovePage.Size = new System.Drawing.Size(127, 13);
            this.lblMovePage.TabIndex = 9;
            this.lblMovePage.Text = "Already have an Account";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Location = new System.Drawing.Point(117, 456);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // UserSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(285, 506);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblMovePage);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.chkBxShow);
            this.Controls.Add(this.lblPasswordCon);
            this.Controls.Add(this.txtPassCon);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSubmit);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSIgnUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPasswordCon;
        private System.Windows.Forms.TextBox txtPassCon;
        private System.Windows.Forms.CheckBox chkBxShow;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMovePage;
        private System.Windows.Forms.Label lblLogin;
    }
}
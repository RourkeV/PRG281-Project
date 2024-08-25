namespace PRG281_Project
{
    partial class enterCheck
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
            this.head = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Location = new System.Drawing.Point(230, 114);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(125, 13);
            this.head.TabIndex = 0;
            this.head.Text = "What do you wish to do?";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(343, 184);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(103, 34);
            this.login.TabIndex = 1;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.White;
            this.signUp.Location = new System.Drawing.Point(119, 184);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(115, 34);
            this.signUp.TabIndex = 2;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(632, 315);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.head);
            this.Name = "enterCheck";
            this.Text = "enterCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signUp;
    }
}
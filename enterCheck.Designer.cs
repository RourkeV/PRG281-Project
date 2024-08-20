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
            this.head.Location = new System.Drawing.Point(307, 140);
            this.head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(140, 16);
            this.head.TabIndex = 0;
            this.head.Text = "what do you wish to do";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(457, 226);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(137, 42);
            this.login.TabIndex = 1;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(159, 226);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(153, 42);
            this.signUp.TabIndex = 2;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 388);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.head);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
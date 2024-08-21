namespace PRG281_Project
{
    partial class UserLogin
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
            this.testText = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testText
            // 
            this.testText.Location = new System.Drawing.Point(435, 28);
            this.testText.Name = "testText";
            this.testText.Size = new System.Drawing.Size(100, 20);
            this.testText.TabIndex = 5;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(445, 71);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 6;
            this.testBtn.Text = "test";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 363);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.testText);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Controls.SetChildIndex(this.testText, 0);
            this.Controls.SetChildIndex(this.testBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testText;
        private System.Windows.Forms.Button testBtn;
    }
}
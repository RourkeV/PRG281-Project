namespace PRG281_Project
{
    partial class API
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(63, 455);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(268, 46);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Enter Your Message...";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(63, 80);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(370, 354);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "Your conversation will appear here...";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(346, 455);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(95, 46);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Send";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.RosyBrown;
            this.lblHeading.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(59, 48);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(265, 24);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Welcome to the Love Bot";
            // 
            // API
            // 
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(504, 557);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textBox);
            this.Name = "API";
            this.Text = "Love Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lblHeading;
    }
}
﻿namespace PRG281_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(API));
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.imageChatBotList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(41, 577);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(268, 46);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Ask me for any dating advice...";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(41, 71);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(378, 487);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "Your conversation will appear here...";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(324, 577);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(95, 46);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Ask";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(37, 38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(210, 20);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Welcome to the Love Bot";
            // 
            // imageChatBotList
            // 
            this.imageChatBotList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageChatBotList.ImageStream")));
            this.imageChatBotList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageChatBotList.Images.SetKeyName(0, "Profile_Icon1.png");
            this.imageChatBotList.Images.SetKeyName(1, "Chat_Icon.png");
            this.imageChatBotList.Images.SetKeyName(2, "Swipe_Icon.png");
            this.imageChatBotList.Images.SetKeyName(3, "ChatBot_Icon1.png");
            this.imageChatBotList.Images.SetKeyName(4, "Search_Icon.png");
            // 
            // API
            // 
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(467, 674);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textBox);
            this.Name = "API";
            this.Text = "Love Bot";
            this.Load += new System.EventHandler(this.API_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ImageList imageChatBotList;
    }
}
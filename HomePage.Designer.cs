namespace PRG281_Project
{
    partial class HomePage
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSwipe = new System.Windows.Forms.Button();
            this.btnChatBot = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxChatBot = new System.Windows.Forms.PictureBox();
            this.picBoxSwipe = new System.Windows.Forms.PictureBox();
            this.picBoxSearch = new System.Windows.Forms.PictureBox();
            this.picBoxChat = new System.Windows.Forms.PictureBox();
            this.picBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChatBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSwipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(3, 17);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(128, 100);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSwipe
            // 
            this.btnSwipe.Location = new System.Drawing.Point(133, 17);
            this.btnSwipe.Name = "btnSwipe";
            this.btnSwipe.Size = new System.Drawing.Size(122, 100);
            this.btnSwipe.TabIndex = 2;
            this.btnSwipe.UseVisualStyleBackColor = true;
            this.btnSwipe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChatBot
            // 
            this.btnChatBot.Location = new System.Drawing.Point(257, 17);
            this.btnChatBot.Name = "btnChatBot";
            this.btnChatBot.Size = new System.Drawing.Size(122, 100);
            this.btnChatBot.TabIndex = 3;
            this.btnChatBot.UseVisualStyleBackColor = true;
            this.btnChatBot.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(381, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 100);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBoxChatBot);
            this.panel1.Controls.Add(this.picBoxSwipe);
            this.panel1.Controls.Add(this.picBoxSearch);
            this.panel1.Controls.Add(this.picBoxChat);
            this.panel1.Controls.Add(this.picBoxProfile);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnChatBot);
            this.panel1.Controls.Add(this.btnSwipe);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(1, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 120);
            this.panel1.TabIndex = 0;
            // 
            // picBoxChatBot
            // 
            this.picBoxChatBot.Image = global::PRG281_Project.Properties.Resources.Chat_Icon;
            this.picBoxChatBot.Location = new System.Drawing.Point(409, 36);
            this.picBoxChatBot.Name = "picBoxChatBot";
            this.picBoxChatBot.Size = new System.Drawing.Size(64, 64);
            this.picBoxChatBot.TabIndex = 9;
            this.picBoxChatBot.TabStop = false;
            // 
            // picBoxSwipe
            // 
            this.picBoxSwipe.Image = global::PRG281_Project.Properties.Resources.Swipe_Icon;
            this.picBoxSwipe.Location = new System.Drawing.Point(285, 36);
            this.picBoxSwipe.Name = "picBoxSwipe";
            this.picBoxSwipe.Size = new System.Drawing.Size(64, 64);
            this.picBoxSwipe.TabIndex = 8;
            this.picBoxSwipe.TabStop = false;
            // 
            // picBoxSearch
            // 
            this.picBoxSearch.Image = global::PRG281_Project.Properties.Resources.Search_Icon;
            this.picBoxSearch.Location = new System.Drawing.Point(531, 36);
            this.picBoxSearch.Name = "picBoxSearch";
            this.picBoxSearch.Size = new System.Drawing.Size(64, 64);
            this.picBoxSearch.TabIndex = 7;
            this.picBoxSearch.TabStop = false;
            // 
            // picBoxChat
            // 
            this.picBoxChat.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.picBoxChat.Location = new System.Drawing.Point(163, 36);
            this.picBoxChat.Name = "picBoxChat";
            this.picBoxChat.Size = new System.Drawing.Size(64, 64);
            this.picBoxChat.TabIndex = 6;
            this.picBoxChat.TabStop = false;
            this.picBoxChat.Click += new System.EventHandler(this.picBoxChat_Click);
            // 
            // picBoxProfile
            // 
            this.picBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxProfile.Image = global::PRG281_Project.Properties.Resources.Profile_Icon1;
            this.picBoxProfile.Location = new System.Drawing.Point(34, 36);
            this.picBoxProfile.Name = "picBoxProfile";
            this.picBoxProfile.Size = new System.Drawing.Size(64, 64);
            this.picBoxProfile.TabIndex = 5;
            this.picBoxProfile.TabStop = false;
            this.picBoxProfile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(503, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 100);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Click += new System.EventHandler(this.button5_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 717);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChatBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSwipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSwipe;
        private System.Windows.Forms.Button btnChatBot;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picBoxProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxChatBot;
        private System.Windows.Forms.PictureBox picBoxSwipe;
        private System.Windows.Forms.PictureBox picBoxSearch;
        private System.Windows.Forms.PictureBox picBoxChat;
    }
}
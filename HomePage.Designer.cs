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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userCard = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblHobbyOne = new System.Windows.Forms.Label();
            this.lblHobbyThree = new System.Windows.Forms.Label();
            this.lblHobbyTwo = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnChatBot = new System.Windows.Forms.Button();
            this.btnSwipe = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.userCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // userCard
            // 
            this.userCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.userCard.Controls.Add(this.lblAge);
            this.userCard.Controls.Add(this.lblHobbyTwo);
            this.userCard.Controls.Add(this.lblHobbyThree);
            this.userCard.Controls.Add(this.lblHobbyOne);
            this.userCard.Controls.Add(this.lblBio);
            this.userCard.Controls.Add(this.lblUsername);
            this.userCard.Controls.Add(this.userPicture);
            this.userCard.Location = new System.Drawing.Point(128, 105);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(368, 424);
            this.userCard.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 320);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username: Walter White";
            // 
            // lblBio
            // 
            this.lblBio.Location = new System.Drawing.Point(12, 345);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(205, 71);
            this.lblBio.TabIndex = 2;
            this.lblBio.Text = "Chemistry teacher by day, blue crystal enthusiast by night. I’m the guy who knock" +
    "s... with 99.1% pure fun. I’m all about that high-quality product, whether it’s " +
    "in the lab or in life.";
            this.lblBio.Click += new System.EventHandler(this.lblBio_Click);
            // 
            // lblHobbyOne
            // 
            this.lblHobbyOne.Location = new System.Drawing.Point(229, 345);
            this.lblHobbyOne.Name = "lblHobbyOne";
            this.lblHobbyOne.Size = new System.Drawing.Size(116, 13);
            this.lblHobbyOne.TabIndex = 3;
            this.lblHobbyOne.Text = "Hobby 1: Making Meth";
            this.lblHobbyOne.Click += new System.EventHandler(this.lblHobbyOne_Click);
            // 
            // lblHobbyThree
            // 
            this.lblHobbyThree.Location = new System.Drawing.Point(229, 381);
            this.lblHobbyThree.Name = "lblHobbyThree";
            this.lblHobbyThree.Size = new System.Drawing.Size(116, 13);
            this.lblHobbyThree.TabIndex = 4;
            this.lblHobbyThree.Text = "Hobby 3: Meth";
            // 
            // lblHobbyTwo
            // 
            this.lblHobbyTwo.Location = new System.Drawing.Point(229, 363);
            this.lblHobbyTwo.Name = "lblHobbyTwo";
            this.lblHobbyTwo.Size = new System.Drawing.Size(116, 13);
            this.lblHobbyTwo.TabIndex = 5;
            this.lblHobbyTwo.Text = "Hobby 2: Music";
            this.lblHobbyTwo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(250, 320);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:  50";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::PRG281_Project.Properties.Resources.Sign_Out_Icon;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 75);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::PRG281_Project.Properties.Resources.Filter_Icon;
            this.btnFilter.Location = new System.Drawing.Point(525, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::PRG281_Project.Properties.Resources.walter_white;
            this.userPicture.Location = new System.Drawing.Point(24, 21);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(321, 292);
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::PRG281_Project.Properties.Resources.Search_Icon;
            this.btnSearch.Location = new System.Drawing.Point(501, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 100);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.btnFind.Location = new System.Drawing.Point(377, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 100);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnChatBot
            // 
            this.btnChatBot.Image = global::PRG281_Project.Properties.Resources.Swipe_Icon;
            this.btnChatBot.Location = new System.Drawing.Point(252, 17);
            this.btnChatBot.Name = "btnChatBot";
            this.btnChatBot.Size = new System.Drawing.Size(122, 100);
            this.btnChatBot.TabIndex = 3;
            this.btnChatBot.UseVisualStyleBackColor = true;
            this.btnChatBot.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSwipe
            // 
            this.btnSwipe.Image = global::PRG281_Project.Properties.Resources.Chat_Icon;
            this.btnSwipe.Location = new System.Drawing.Point(127, 17);
            this.btnSwipe.Name = "btnSwipe";
            this.btnSwipe.Size = new System.Drawing.Size(122, 100);
            this.btnSwipe.TabIndex = 2;
            this.btnSwipe.UseVisualStyleBackColor = true;
            this.btnSwipe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Image = global::PRG281_Project.Properties.Resources.Profile_Icon1;
            this.btnProfile.Location = new System.Drawing.Point(4, 17);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 100);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 717);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.userCard);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.userCard.ResumeLayout(false);
            this.userCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSwipe;
        private System.Windows.Forms.Button btnChatBot;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel userCard;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblHobbyTwo;
        private System.Windows.Forms.Label lblHobbyThree;
        private System.Windows.Forms.Label lblHobbyOne;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSignOut;
    }
}
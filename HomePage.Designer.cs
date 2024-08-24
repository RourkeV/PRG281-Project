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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.userCard = new System.Windows.Forms.Panel();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHobbyTwo = new System.Windows.Forms.Label();
            this.lblHobbyThree = new System.Windows.Forms.Label();
            this.lblHobbyOne = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabChatPage = new System.Windows.Forms.TabPage();
            this.tabSwipePage = new System.Windows.Forms.TabPage();
            this.tabChatBotPage = new System.Windows.Forms.TabPage();
            this.tabSearchPage = new System.Windows.Forms.TabPage();
            this.imageMainList = new System.Windows.Forms.ImageList(this.components);
            this.userCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.tabList.SuspendLayout();
            this.SuspendLayout();
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
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(250, 320);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:  50";
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
            // lblHobbyThree
            // 
            this.lblHobbyThree.Location = new System.Drawing.Point(229, 381);
            this.lblHobbyThree.Name = "lblHobbyThree";
            this.lblHobbyThree.Size = new System.Drawing.Size(116, 13);
            this.lblHobbyThree.TabIndex = 4;
            this.lblHobbyThree.Text = "Hobby 3: Meth";
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 320);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username: Walter White";
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
            // tabList
            // 
            this.tabList.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabList.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabList.Controls.Add(this.tabPageProfile);
            this.tabList.Controls.Add(this.tabChatPage);
            this.tabList.Controls.Add(this.tabSwipePage);
            this.tabList.Controls.Add(this.tabChatBotPage);
            this.tabList.Controls.Add(this.tabSearchPage);
            this.tabList.ImageList = this.imageMainList;
            this.tabList.ItemSize = new System.Drawing.Size(122, 120);
            this.tabList.Location = new System.Drawing.Point(0, -1);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(629, 718);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabList.TabIndex = 6;
            this.tabList.Tag = "";
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.ImageKey = "Profile_Icon1.png";
            this.tabPageProfile.Location = new System.Drawing.Point(4, 4);
            this.tabPageProfile.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(621, 0);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // tabChatPage
            // 
            this.tabChatPage.ImageIndex = 1;
            this.tabChatPage.Location = new System.Drawing.Point(4, 4);
            this.tabChatPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabChatPage.Name = "tabChatPage";
            this.tabChatPage.Size = new System.Drawing.Size(621, 0);
            this.tabChatPage.TabIndex = 1;
            this.tabChatPage.UseVisualStyleBackColor = true;
            // 
            // tabSwipePage
            // 
            this.tabSwipePage.ImageIndex = 2;
            this.tabSwipePage.Location = new System.Drawing.Point(4, 4);
            this.tabSwipePage.Margin = new System.Windows.Forms.Padding(0);
            this.tabSwipePage.Name = "tabSwipePage";
            this.tabSwipePage.Size = new System.Drawing.Size(621, 0);
            this.tabSwipePage.TabIndex = 2;
            this.tabSwipePage.UseVisualStyleBackColor = true;
            // 
            // tabChatBotPage
            // 
            this.tabChatBotPage.ImageIndex = 3;
            this.tabChatBotPage.Location = new System.Drawing.Point(4, 4);
            this.tabChatBotPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabChatBotPage.Name = "tabChatBotPage";
            this.tabChatBotPage.Size = new System.Drawing.Size(621, 0);
            this.tabChatBotPage.TabIndex = 3;
            this.tabChatBotPage.UseVisualStyleBackColor = true;
            // 
            // tabSearchPage
            // 
            this.tabSearchPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSearchPage.ImageIndex = 4;
            this.tabSearchPage.Location = new System.Drawing.Point(4, 4);
            this.tabSearchPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabSearchPage.Name = "tabSearchPage";
            this.tabSearchPage.Size = new System.Drawing.Size(621, 0);
            this.tabSearchPage.TabIndex = 4;
            this.tabSearchPage.UseVisualStyleBackColor = true;
            // 
            // imageMainList
            // 
            this.imageMainList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageMainList.ImageStream")));
            this.imageMainList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageMainList.Images.SetKeyName(0, "Profile_Icon1.png");
            this.imageMainList.Images.SetKeyName(1, "Chat_Icon.png");
            this.imageMainList.Images.SetKeyName(2, "Swipe_Icon.png");
            this.imageMainList.Images.SetKeyName(3, "ChatBot_Icon1.png");
            this.imageMainList.Images.SetKeyName(4, "Search_Icon.png");
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 717);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.userCard);
            this.Controls.Add(this.tabList);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.userCard.ResumeLayout(false);
            this.userCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.tabList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabChatPage;
        private System.Windows.Forms.TabPage tabSwipePage;
        private System.Windows.Forms.TabPage tabChatBotPage;
        private System.Windows.Forms.TabPage tabSearchPage;
        private System.Windows.Forms.ImageList imageMainList;
    }
}
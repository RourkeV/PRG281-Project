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
            this.lblViewBio = new System.Windows.Forms.Label();
            this.lblViewAge = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabChatPage = new System.Windows.Forms.TabPage();
            this.tabSwipePage = new System.Windows.Forms.TabPage();
            this.tabChatBotPage = new System.Windows.Forms.TabPage();
            this.tabSearchPage = new System.Windows.Forms.TabPage();
            this.imageMainList = new System.Windows.Forms.ImageList(this.components);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.userCard.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userCard
            // 
            this.userCard.BackColor = System.Drawing.Color.White;
            this.userCard.Controls.Add(this.lblViewBio);
            this.userCard.Controls.Add(this.lblViewAge);
            this.userCard.Controls.Add(this.lblSearchName);
            this.userCard.Controls.Add(this.lblAge);
            this.userCard.Controls.Add(this.lblBio);
            this.userCard.Controls.Add(this.lblUsername);
            this.userCard.Controls.Add(this.userPicture);
            this.userCard.Location = new System.Drawing.Point(118, 97);
            this.userCard.Margin = new System.Windows.Forms.Padding(7);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(389, 465);
            this.userCard.TabIndex = 1;
            // 
            // lblViewBio
            // 
            this.lblViewBio.AutoSize = true;
            this.lblViewBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBio.Location = new System.Drawing.Point(44, 371);
            this.lblViewBio.Name = "lblViewBio";
            this.lblViewBio.Size = new System.Drawing.Size(29, 13);
            this.lblViewBio.TabIndex = 9;
            this.lblViewBio.Text = "Bio:";
            // 
            // lblViewAge
            // 
            this.lblViewAge.AutoSize = true;
            this.lblViewAge.Location = new System.Drawing.Point(292, 341);
            this.lblViewAge.Name = "lblViewAge";
            this.lblViewAge.Size = new System.Drawing.Size(51, 13);
            this.lblViewAge.TabIndex = 8;
            this.lblViewAge.Text = "User Age";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(138, 341);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(55, 13);
            this.lblSearchName.TabIndex = 7;
            this.lblSearchName.Text = "Username";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(258, 337);
            this.lblAge.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 18);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // lblBio
            // 
            this.lblBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(123, 371);
            this.lblBio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(220, 79);
            this.lblBio.TabIndex = 2;
            this.lblBio.Click += new System.EventHandler(this.lblBio_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(40, 337);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // userPicture
            // 
            this.userPicture.Image = global::PRG281_Project.Properties.Resources.walter_white;
            this.userPicture.Location = new System.Drawing.Point(30, 28);
            this.userPicture.Margin = new System.Windows.Forms.Padding(7);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(330, 298);
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Image = global::PRG281_Project.Properties.Resources.Sign_Out_Icon;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(7);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 75);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::PRG281_Project.Properties.Resources.Filter_Icon;
            this.btnFilter.Location = new System.Drawing.Point(525, 12);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = false;
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
            this.tabList.Location = new System.Drawing.Point(0, 593);
            this.tabList.Margin = new System.Windows.Forms.Padding(7);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(629, 123);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabList.TabIndex = 6;
            this.tabList.Tag = "";
            this.tabList.SelectedIndexChanged += new System.EventHandler(this.tabList_SelectedIndexChanged);
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.Pink;
            this.tabPageProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageProfile.ImageIndex = 0;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 4);
            this.tabPageProfile.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageProfile.Size = new System.Drawing.Size(621, 0);
            this.tabPageProfile.TabIndex = 0;
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
            this.imageMainList.TransparentColor = System.Drawing.Color.Pink;
            this.imageMainList.Images.SetKeyName(0, "Profile_Icon1.png");
            this.imageMainList.Images.SetKeyName(1, "Chat_Icon.png");
            this.imageMainList.Images.SetKeyName(2, "Swipe_Icon.png");
            this.imageMainList.Images.SetKeyName(3, "ChatBot_Icon1.png");
            this.imageMainList.Images.SetKeyName(4, "Search_Icon.png");
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::PRG281_Project.Properties.Resources.Sign_Out_Icon;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(7);
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
            this.btnFilter.Margin = new System.Windows.Forms.Padding(7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::PRG281_Project.Properties.Resources.walter_white;
            this.userPicture.Location = new System.Drawing.Point(30, 28);
            this.userPicture.Margin = new System.Windows.Forms.Padding(7);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(330, 298);
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(628, 717);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.userCard);
            this.Controls.Add(this.tabList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.userCard.ResumeLayout(false);
            this.userCard.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel userCard;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBio;
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
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblViewAge;
        private System.Windows.Forms.Label lblViewBio;
    }
}
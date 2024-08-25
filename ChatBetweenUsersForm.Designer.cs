namespace PRG281_Project
{
    partial class ChatBetweenUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBetweenUsersForm));
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabChatPage = new System.Windows.Forms.TabPage();
            this.tabSwipePage = new System.Windows.Forms.TabPage();
            this.tabChatBotPage = new System.Windows.Forms.TabPage();
            this.tabSearchPage = new System.Windows.Forms.TabPage();
            this.imgChatBetweenUsersList = new System.Windows.Forms.ImageList(this.components);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.flowLayoutMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.tabList.SuspendLayout();
            this.SuspendLayout();
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
            this.tabList.ImageList = this.imgChatBetweenUsersList;
            this.tabList.ItemSize = new System.Drawing.Size(122, 120);
            this.tabList.Location = new System.Drawing.Point(0, 593);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(629, 124);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabList.TabIndex = 8;
            this.tabList.Tag = "";
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.ImageIndex = 0;
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
            // imgChatBetweenUsersList
            // 
            this.imgChatBetweenUsersList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgChatBetweenUsersList.ImageStream")));
            this.imgChatBetweenUsersList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgChatBetweenUsersList.Images.SetKeyName(0, "Profile_Icon1.png");
            this.imgChatBetweenUsersList.Images.SetKeyName(1, "Chat_Icon.png");
            this.imgChatBetweenUsersList.Images.SetKeyName(2, "Swipe_Icon.png");
            this.imgChatBetweenUsersList.Images.SetKeyName(3, "ChatBot_Icon1.png");
            this.imgChatBetweenUsersList.Images.SetKeyName(4, "Search_Icon.png");
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::PRG281_Project.Properties.Resources.Sign_Out_Icon;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(7);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 75);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // flowLayoutMessage
            // 
            this.flowLayoutMessage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMessage.Location = new System.Drawing.Point(12, 541);
            this.flowLayoutMessage.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutMessage.Name = "flowLayoutMessage";
            this.flowLayoutMessage.Size = new System.Drawing.Size(10, 10);
            this.flowLayoutMessage.TabIndex = 11;
            this.flowLayoutMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutMessage_Paint);
            // 
            // ChatBetweenUsersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(905, 717);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.tabList);
            this.Controls.Add(this.flowLayoutMessage);
            this.Name = "ChatBetweenUsersForm";
            this.Text = "ChatBetweenUsersForm";
            this.Load += new System.EventHandler(this.ChatBetweenUsersForm_Load);
            this.tabList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabChatPage;
        private System.Windows.Forms.TabPage tabSwipePage;
        private System.Windows.Forms.TabPage tabChatBotPage;
        private System.Windows.Forms.TabPage tabSearchPage;
        private System.Windows.Forms.ImageList imgChatBetweenUsersList;
        private System.Windows.Forms.Button btnSignOut;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutMessage;
    }
}
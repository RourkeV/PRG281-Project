namespace PRG281_Project
{
    partial class usersLiked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersLiked));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabChatPage = new System.Windows.Forms.TabPage();
            this.tabSwipePage = new System.Windows.Forms.TabPage();
            this.tabChatBotPage = new System.Windows.Forms.TabPage();
            this.tabSearchPage = new System.Windows.Forms.TabPage();
            this.imageSearchList = new System.Windows.Forms.ImageList(this.components);
            this.tabList.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 424);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::PRG281_Project.Properties.Resources.Sign_Out_Icon;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 75);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::PRG281_Project.Properties.Resources.Filter_Icon;
            this.btnFilter.Location = new System.Drawing.Point(525, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.UseVisualStyleBackColor = true;
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
            this.tabList.ImageList = this.imageSearchList;
            this.tabList.ItemSize = new System.Drawing.Size(122, 120);
            this.tabList.Location = new System.Drawing.Point(0, -1);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(629, 718);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabList.TabIndex = 9;
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
            // imageSearchList
            // 
            this.imageSearchList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSearchList.ImageStream")));
            this.imageSearchList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSearchList.Images.SetKeyName(0, "Profile_Icon1.png");
            this.imageSearchList.Images.SetKeyName(1, "Chat_Icon.png");
            this.imageSearchList.Images.SetKeyName(2, "Swipe_Icon.png");
            this.imageSearchList.Images.SetKeyName(3, "ChatBot_Icon1.png");
            this.imageSearchList.Images.SetKeyName(4, "Search_Icon.png");
            // 
            // usersLiked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 717);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.tabList);
            this.Name = "usersLiked";
            this.Text = "usersLiked";
            this.tabList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabChatPage;
        private System.Windows.Forms.TabPage tabSwipePage;
        private System.Windows.Forms.TabPage tabChatBotPage;
        private System.Windows.Forms.TabPage tabSearchPage;
        private System.Windows.Forms.ImageList imageSearchList;
    }
}
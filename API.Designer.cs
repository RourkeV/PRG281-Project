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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(API));
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabChatPage = new System.Windows.Forms.TabPage();
            this.tabSwipePage = new System.Windows.Forms.TabPage();
            this.tabChatBotPage = new System.Windows.Forms.TabPage();
            this.tabSearchPage = new System.Windows.Forms.TabPage();
            this.imageChatBotList = new System.Windows.Forms.ImageList(this.components);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tabList.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(122, 486);
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
            this.richTextBox.Location = new System.Drawing.Point(122, 111);
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
            this.submitBtn.Location = new System.Drawing.Point(405, 486);
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
            this.lblHeading.BackColor = System.Drawing.Color.RosyBrown;
            this.lblHeading.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(115, 69);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(329, 39);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Welcome to the Love Bot";
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
            this.tabList.ImageList = this.imageChatBotList;
            this.tabList.ItemSize = new System.Drawing.Size(122, 120);
            this.tabList.Location = new System.Drawing.Point(0, 593);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(629, 124);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabList.TabIndex = 7;
            this.tabList.Tag = "";
            this.tabList.SelectedIndexChanged += new System.EventHandler(this.tabList_SelectedIndexChanged);
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
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Image = global::PRG281_Project.Properties.Resources.Sign_Out_Icon;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 75);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::PRG281_Project.Properties.Resources.Filter_Icon;
            this.btnFilter.Location = new System.Drawing.Point(525, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // API
            // 
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(628, 717);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.tabList);
            this.Name = "API";
            this.Text = "Love Bot";
            this.tabList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabChatPage;
        private System.Windows.Forms.TabPage tabSwipePage;
        private System.Windows.Forms.TabPage tabChatBotPage;
        private System.Windows.Forms.TabPage tabSearchPage;
        private System.Windows.Forms.ImageList imageChatBotList;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnFilter;
    }
}
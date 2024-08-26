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
            this.button1 = new System.Windows.Forms.Button();
            this.lblViewBio = new System.Windows.Forms.Label();
            this.lblViewAge = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.imageMainList = new System.Windows.Forms.ImageList(this.components);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblChatBot = new System.Windows.Forms.Label();
            this.btnAPIProfile = new System.Windows.Forms.Button();
            this.rchTxtBio = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAgeProf = new System.Windows.Forms.Label();
            this.lblAgeHead = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblNameHead = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAPIChat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAPISwipe = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAPISearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.userCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userCard
            // 
            this.userCard.BackColor = System.Drawing.Color.White;
            this.userCard.Controls.Add(this.button1);
            this.userCard.Controls.Add(this.lblViewBio);
            this.userCard.Controls.Add(this.lblViewAge);
            this.userCard.Controls.Add(this.lblSearchName);
            this.userCard.Controls.Add(this.lblAge);
            this.userCard.Controls.Add(this.lblBio);
            this.userCard.Controls.Add(this.lblUsername);
            this.userCard.Controls.Add(this.userPicture);
            this.userCard.Location = new System.Drawing.Point(100, 10);
            this.userCard.Margin = new System.Windows.Forms.Padding(7);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(390, 465);
            this.userCard.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::PRG281_Project.Properties.Resources.caution;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(336, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblViewBio
            // 
            this.lblViewBio.AutoSize = true;
            this.lblViewBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBio.Location = new System.Drawing.Point(27, 373);
            this.lblViewBio.Name = "lblViewBio";
            this.lblViewBio.Size = new System.Drawing.Size(29, 13);
            this.lblViewBio.TabIndex = 9;
            this.lblViewBio.Text = "Bio:";
            // 
            // lblViewAge
            // 
            this.lblViewAge.AutoSize = true;
            this.lblViewAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAge.Location = new System.Drawing.Point(273, 333);
            this.lblViewAge.Name = "lblViewAge";
            this.lblViewAge.Size = new System.Drawing.Size(76, 20);
            this.lblViewAge.TabIndex = 8;
            this.lblViewAge.Text = "User Age";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(111, 333);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(83, 20);
            this.lblSearchName.TabIndex = 7;
            this.lblSearchName.Text = "Username";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(237, 333);
            this.lblAge.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 18);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // lblBio
            // 
            this.lblBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(66, 362);
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
            this.lblUsername.Location = new System.Drawing.Point(26, 333);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
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
            this.btnSignOut.BackColor = System.Drawing.Color.White;
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
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::PRG281_Project.Properties.Resources.Filter_Icon;
            this.btnFilter.Location = new System.Drawing.Point(525, 12);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ImageList = this.imageMainList;
            this.tabControl1.ItemSize = new System.Drawing.Size(149, 80);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 600);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lblChatBot);
            this.tabPage1.Controls.Add(this.btnAPIProfile);
            this.tabPage1.Controls.Add(this.rchTxtBio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lblAgeProf);
            this.tabPage1.Controls.Add(this.lblAgeHead);
            this.tabPage1.Controls.Add(this.lblHeading);
            this.tabPage1.Controls.Add(this.lblNameHead);
            this.tabPage1.ImageKey = "Profile_Icon1.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblChatBot
            // 
            this.lblChatBot.AutoSize = true;
            this.lblChatBot.Location = new System.Drawing.Point(473, 404);
            this.lblChatBot.Name = "lblChatBot";
            this.lblChatBot.Size = new System.Drawing.Size(93, 13);
            this.lblChatBot.TabIndex = 21;
            this.lblChatBot.Text = "Need Assistance?";
            this.lblChatBot.Click += new System.EventHandler(this.lblChatBot_Click);
            // 
            // btnAPIProfile
            // 
            this.btnAPIProfile.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.btnAPIProfile.Location = new System.Drawing.Point(480, 420);
            this.btnAPIProfile.Name = "btnAPIProfile";
            this.btnAPIProfile.Size = new System.Drawing.Size(75, 75);
            this.btnAPIProfile.TabIndex = 20;
            this.btnAPIProfile.UseVisualStyleBackColor = true;
            this.btnAPIProfile.Click += new System.EventHandler(this.btnAPIProfile_Click);
            // 
            // rchTxtBio
            // 
            this.rchTxtBio.Location = new System.Drawing.Point(41, 222);
            this.rchTxtBio.Name = "rchTxtBio";
            this.rchTxtBio.Size = new System.Drawing.Size(241, 111);
            this.rchTxtBio.TabIndex = 19;
            this.rchTxtBio.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(310, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 222);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblAgeProf
            // 
            this.lblAgeProf.AutoSize = true;
            this.lblAgeProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeProf.Location = new System.Drawing.Point(163, 182);
            this.lblAgeProf.Name = "label2";
            this.lblAgeProf.Size = new System.Drawing.Size(45, 13);
            this.lblAgeProf.TabIndex = 16;
            this.lblAgeProf.Text = "userage";
            this.lblAgeProf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAgeHead
            // 
            this.lblAgeHead.AutoSize = true;
            this.lblAgeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeHead.Location = new System.Drawing.Point(42, 159);
            this.lblAgeHead.Name = "lblAgeHead";
            this.lblAgeHead.Size = new System.Drawing.Size(41, 18);
            this.lblAgeHead.TabIndex = 15;
            this.lblAgeHead.Text = "Age:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(243, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(90, 29);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Profile";
            // 
            // lblNameHead
            // 
            this.lblNameHead.AutoSize = true;
            this.lblNameHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHead.Location = new System.Drawing.Point(30, 122);
            this.lblNameHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameHead.Name = "lblNameHead";
            this.lblNameHead.Size = new System.Drawing.Size(57, 18);
            this.lblNameHead.TabIndex = 10;
            this.lblNameHead.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnAPIChat);
            this.tabPage2.ImageKey = "Chat_Icon.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Need Assistance?";
            // 
            // btnAPIChat
            // 
            this.btnAPIChat.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.btnAPIChat.Location = new System.Drawing.Point(500, 19);
            this.btnAPIChat.Name = "btnAPIChat";
            this.btnAPIChat.Size = new System.Drawing.Size(75, 75);
            this.btnAPIChat.TabIndex = 22;
            this.btnAPIChat.UseVisualStyleBackColor = true;
            this.btnAPIChat.Click += new System.EventHandler(this.btnAPIProfile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Pink;
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnAPISwipe);
            this.tabPage3.Controls.Add(this.userCard);
            this.tabPage3.ImageKey = "Swipe_Icon.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 512);
            this.tabPage3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Need Assistance?";
            // 
            // btnAPISwipe
            // 
            this.btnAPISwipe.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.btnAPISwipe.Location = new System.Drawing.Point(514, 431);
            this.btnAPISwipe.Name = "btnAPISwipe";
            this.btnAPISwipe.Size = new System.Drawing.Size(75, 75);
            this.btnAPISwipe.TabIndex = 22;
            this.btnAPISwipe.UseVisualStyleBackColor = true;
            this.btnAPISwipe.Click += new System.EventHandler(this.btnAPIProfile_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btnAPISearch);
            this.tabPage4.ImageKey = "Search_Icon.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(592, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Need Assistance?";
            // 
            // btnAPISearch
            // 
            this.btnAPISearch.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.btnAPISearch.Location = new System.Drawing.Point(500, 24);
            this.btnAPISearch.Name = "btnAPISearch";
            this.btnAPISearch.Size = new System.Drawing.Size(75, 75);
            this.btnAPISearch.TabIndex = 22;
            this.btnAPISearch.UseVisualStyleBackColor = true;
            this.btnAPISearch.Click += new System.EventHandler(this.btnAPIProfile_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(41, 354);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 24;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(95, 159);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 25;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(628, 717);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.userCard.ResumeLayout(false);
            this.userCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.ImageList imageMainList;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblViewAge;
        private System.Windows.Forms.Label lblViewBio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rchTxtBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAgeProf;
        private System.Windows.Forms.Label lblAgeHead;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblNameHead;
        private System.Windows.Forms.Button btnAPIProfile;
        private System.Windows.Forms.Label lblChatBot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAPIChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAPISwipe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAPISearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
    }
}
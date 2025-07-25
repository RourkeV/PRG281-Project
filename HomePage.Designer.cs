﻿namespace PRG281_Project
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfilterAge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblViewBio = new System.Windows.Forms.Label();
            this.lblViewAge = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.imageMainList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rchTxtBio = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAgeHead = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblNameHead = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.submitBtnUserChat = new System.Windows.Forms.Button();
            this.textBoxUserChat = new System.Windows.Forms.TextBox();
            this.panelChatBot = new System.Windows.Forms.Panel();
            this.lblUserNameChat = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.lblChatUser = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAPISwipe = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.userCard.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelChatBot.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userCard
            // 
            this.userCard.BackColor = System.Drawing.Color.White;
            this.userCard.Controls.Add(this.pnlFilter);
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
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.Salmon;
            this.pnlFilter.Controls.Add(this.cmbGender);
            this.pnlFilter.Controls.Add(this.btnCancel);
            this.pnlFilter.Controls.Add(this.btnAccept);
            this.pnlFilter.Controls.Add(this.lblMax);
            this.pnlFilter.Controls.Add(this.lblMin);
            this.pnlFilter.Controls.Add(this.numMax);
            this.pnlFilter.Controls.Add(this.numMin);
            this.pnlFilter.Controls.Add(this.label6);
            this.pnlFilter.Controls.Add(this.lblfilterAge);
            this.pnlFilter.Location = new System.Drawing.Point(53, 28);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(267, 249);
            this.pnlFilter.TabIndex = 11;
            this.pnlFilter.Visible = false;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cmbGender.Location = new System.Drawing.Point(81, 126);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(73, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(139, 167);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(55, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(159, 49);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(73, 49);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(160, 71);
            this.numMax.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(45, 20);
            this.numMax.TabIndex = 4;
            this.numMax.Tag = "";
            this.numMax.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(73, 71);
            this.numMin.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(44, 20);
            this.numMin.TabIndex = 3;
            this.numMin.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gender";
            // 
            // lblfilterAge
            // 
            this.lblfilterAge.AutoSize = true;
            this.lblfilterAge.Location = new System.Drawing.Point(85, 32);
            this.lblfilterAge.Name = "lblfilterAge";
            this.lblfilterAge.Size = new System.Drawing.Size(109, 13);
            this.lblfilterAge.TabIndex = 0;
            this.lblfilterAge.Text = "Choose an age range";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::PRG281_Project.Properties.Resources.caution;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(322, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblViewBio
            // 
            this.lblViewBio.AutoSize = true;
            this.lblViewBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBio.Location = new System.Drawing.Point(26, 327);
            this.lblViewBio.Name = "lblViewBio";
            this.lblViewBio.Size = new System.Drawing.Size(36, 20);
            this.lblViewBio.TabIndex = 9;
            this.lblViewBio.Text = "Bio:";
            // 
            // lblViewAge
            // 
            this.lblViewAge.AutoSize = true;
            this.lblViewAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAge.Location = new System.Drawing.Point(284, 266);
            this.lblViewAge.Name = "lblViewAge";
            this.lblViewAge.Size = new System.Drawing.Size(76, 20);
            this.lblViewAge.TabIndex = 8;
            this.lblViewAge.Text = "User Age";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(111, 266);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(83, 20);
            this.lblSearchName.TabIndex = 7;
            this.lblSearchName.Text = "Username";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(237, 266);
            this.lblAge.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // lblBio
            // 
            this.lblBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(66, 330);
            this.lblBio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(294, 79);
            this.lblBio.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(26, 266);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::PRG281_Project.Properties.Resources.DefaultProfilePic2;
            this.userPicture.Location = new System.Drawing.Point(30, 28);
            this.userPicture.Margin = new System.Windows.Forms.Padding(7);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(330, 212);
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
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageMainList;
            this.tabControl1.ItemSize = new System.Drawing.Size(199, 80);
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
            this.tabPage1.BackColor = System.Drawing.Color.Pink;
            this.tabPage1.Controls.Add(this.btnCommit);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.rchTxtBio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lblAgeHead);
            this.tabPage1.Controls.Add(this.lblHeading);
            this.tabPage1.Controls.Add(this.lblNameHead);
            this.tabPage1.ImageKey = "Profile_Icon1.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 512);
            this.tabPage1.TabIndex = 0;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(315, 365);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(80, 45);
            this.btnCommit.TabIndex = 26;
            this.btnCommit.Text = "Save changes";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Visible = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(93, 136);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(189, 20);
            this.txtAge.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 76);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 24;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(202, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 45);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rchTxtBio
            // 
            this.rchTxtBio.Location = new System.Drawing.Point(31, 220);
            this.rchTxtBio.Name = "rchTxtBio";
            this.rchTxtBio.ReadOnly = true;
            this.rchTxtBio.Size = new System.Drawing.Size(250, 73);
            this.rchTxtBio.TabIndex = 19;
            this.rchTxtBio.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PRG281_Project.Properties.Resources.DefaultProfilePic;
            this.pictureBox1.Location = new System.Drawing.Point(315, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 222);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblAgeHead
            // 
            this.lblAgeHead.AutoSize = true;
            this.lblAgeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeHead.Location = new System.Drawing.Point(29, 135);
            this.lblAgeHead.Name = "lblAgeHead";
            this.lblAgeHead.Size = new System.Drawing.Size(41, 18);
            this.lblAgeHead.TabIndex = 15;
            this.lblAgeHead.Text = "Age:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(218, 17);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(152, 29);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Your Profile";
            // 
            // lblNameHead
            // 
            this.lblNameHead.AutoSize = true;
            this.lblNameHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHead.Location = new System.Drawing.Point(29, 75);
            this.lblNameHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameHead.Name = "lblNameHead";
            this.lblNameHead.Size = new System.Drawing.Size(57, 18);
            this.lblNameHead.TabIndex = 10;
            this.lblNameHead.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutMessage);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.submitBtnUserChat);
            this.tabPage2.Controls.Add(this.textBoxUserChat);
            this.tabPage2.Controls.Add(this.panelChatBot);
            this.tabPage2.ImageKey = "Chat_Icon.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutMessage
            // 
            this.flowLayoutMessage.AutoScroll = true;
            this.flowLayoutMessage.BackColor = System.Drawing.Color.Pink;
            this.flowLayoutMessage.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMessage.Name = "flowLayoutMessage";
            this.flowLayoutMessage.Size = new System.Drawing.Size(234, 512);
            this.flowLayoutMessage.TabIndex = 24;
            this.flowLayoutMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutMessage_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, -69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Welcome to the Love Bot";
            // 
            // submitBtnUserChat
            // 
            this.submitBtnUserChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitBtnUserChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtnUserChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtnUserChat.Location = new System.Drawing.Point(499, 441);
            this.submitBtnUserChat.Name = "submitBtnUserChat";
            this.submitBtnUserChat.Size = new System.Drawing.Size(76, 47);
            this.submitBtnUserChat.TabIndex = 27;
            this.submitBtnUserChat.Text = "Ask";
            this.submitBtnUserChat.UseVisualStyleBackColor = false;
            this.submitBtnUserChat.Visible = false;
            // 
            // textBoxUserChat
            // 
            this.textBoxUserChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUserChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserChat.Location = new System.Drawing.Point(255, 441);
            this.textBoxUserChat.Multiline = true;
            this.textBoxUserChat.Name = "textBoxUserChat";
            this.textBoxUserChat.Size = new System.Drawing.Size(230, 47);
            this.textBoxUserChat.TabIndex = 25;
            this.textBoxUserChat.Text = "Type a message...";
            this.textBoxUserChat.Visible = false;
            // 
            // panelChatBot
            // 
            this.panelChatBot.BackColor = System.Drawing.Color.Pink;
            this.panelChatBot.Controls.Add(this.lblUserNameChat);
            this.panelChatBot.Controls.Add(this.richTextBox);
            this.panelChatBot.Controls.Add(this.lblChatUser);
            this.panelChatBot.Location = new System.Drawing.Point(240, 6);
            this.panelChatBot.Name = "panelChatBot";
            this.panelChatBot.Size = new System.Drawing.Size(346, 500);
            this.panelChatBot.TabIndex = 29;
            this.panelChatBot.Visible = false;
            // 
            // lblUserNameChat
            // 
            this.lblUserNameChat.AutoSize = true;
            this.lblUserNameChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameChat.Location = new System.Drawing.Point(193, 41);
            this.lblUserNameChat.Name = "lblUserNameChat";
            this.lblUserNameChat.Size = new System.Drawing.Size(72, 20);
            this.lblUserNameChat.TabIndex = 27;
            this.lblUserNameChat.Text = "example ";
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(15, 99);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(320, 330);
            this.richTextBox.TabIndex = 26;
            this.richTextBox.Text = "Your conversation will appear here...";
            // 
            // lblChatUser
            // 
            this.lblChatUser.AutoSize = true;
            this.lblChatUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatUser.Location = new System.Drawing.Point(11, 41);
            this.lblChatUser.Name = "lblChatUser";
            this.lblChatUser.Size = new System.Drawing.Size(185, 20);
            this.lblChatUser.TabIndex = 0;
            this.lblChatUser.Text = "Welcome to chat with:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Pink;
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
            this.label4.Location = new System.Drawing.Point(265, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Need Assistance?";
            // 
            // btnAPISwipe
            // 
            this.btnAPISwipe.Image = global::PRG281_Project.Properties.Resources.ChatBot_Icon1;
            this.btnAPISwipe.Location = new System.Drawing.Point(274, 12);
            this.btnAPISwipe.Name = "btnAPISwipe";
            this.btnAPISwipe.Size = new System.Drawing.Size(75, 75);
            this.btnAPISwipe.TabIndex = 22;
            this.btnAPISwipe.UseVisualStyleBackColor = true;
            this.btnAPISwipe.Click += new System.EventHandler(this.btnAPIProfile_Click);
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
            this.btnFilter.Location = new System.Drawing.Point(522, 12);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 75);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(625, 717);
            this.Controls.Add(this.btnAPISwipe);
            this.Controls.Add(this.label4);
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
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelChatBot.ResumeLayout(false);
            this.panelChatBot.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RichTextBox rchTxtBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAgeHead;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblNameHead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAPISwipe;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutMessage;
        private System.IO.FileSystemWatcher fileSystemWatcher1;

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitBtnUserChat;
        private System.Windows.Forms.TextBox textBoxUserChat;
        private System.Windows.Forms.Panel panelChatBot;
        private System.Windows.Forms.Label lblChatUser;
        private System.Windows.Forms.Label lblUserNameChat;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblfilterAge;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}
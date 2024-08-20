namespace PRG281_Project
{
    partial class SwipeForm
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
            this.userCard = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.userBio = new System.Windows.Forms.Label();
            this.userInterest1 = new System.Windows.Forms.Label();
            this.userInterest2 = new System.Windows.Forms.Label();
            this.userInterest3 = new System.Windows.Forms.Label();
            this.userCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userCard
            // 
            this.userCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userCard.Controls.Add(this.userInterest3);
            this.userCard.Controls.Add(this.userInterest2);
            this.userCard.Controls.Add(this.userInterest1);
            this.userCard.Controls.Add(this.userBio);
            this.userCard.Controls.Add(this.userName);
            this.userCard.Controls.Add(this.userPicture);
            this.userCard.Location = new System.Drawing.Point(264, 66);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(290, 372);
            this.userCard.TabIndex = 0;
            // 
            // userPicture
            // 
            this.userPicture.Image = global::PRG281_Project.Properties.Resources.jotaro;
            this.userPicture.Location = new System.Drawing.Point(3, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(284, 262);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(4, 272);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(95, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "UserName (Jotaro)";
            // 
            // userBio
            // 
            this.userBio.Location = new System.Drawing.Point(4, 294);
            this.userBio.Name = "userBio";
            this.userBio.Size = new System.Drawing.Size(203, 78);
            this.userBio.TabIndex = 2;
            this.userBio.Text = "The user will enter a bio on their profile which will be saved into a variable. T" +
    "his variable will then be set to this labels .text property, they will have a wo" +
    "rd limit of 30";
            // 
            // userInterest1
            // 
            this.userInterest1.AutoSize = true;
            this.userInterest1.Location = new System.Drawing.Point(213, 294);
            this.userInterest1.Name = "userInterest1";
            this.userInterest1.Size = new System.Drawing.Size(68, 13);
            this.userInterest1.TabIndex = 3;
            this.userInterest1.Text = "userInterest1";
            // 
            // userInterest2
            // 
            this.userInterest2.AutoSize = true;
            this.userInterest2.Location = new System.Drawing.Point(213, 313);
            this.userInterest2.Name = "userInterest2";
            this.userInterest2.Size = new System.Drawing.Size(68, 13);
            this.userInterest2.TabIndex = 4;
            this.userInterest2.Text = "userInterest2";
            // 
            // userInterest3
            // 
            this.userInterest3.AutoSize = true;
            this.userInterest3.Location = new System.Drawing.Point(213, 330);
            this.userInterest3.Name = "userInterest3";
            this.userInterest3.Size = new System.Drawing.Size(68, 13);
            this.userInterest3.TabIndex = 5;
            this.userInterest3.Text = "userInterest3";
            // 
            // SwipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userCard);
            this.Name = "SwipeForm";
            this.Text = "Form1";
            this.userCard.ResumeLayout(false);
            this.userCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userCard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label userBio;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userInterest3;
        private System.Windows.Forms.Label userInterest2;
        private System.Windows.Forms.Label userInterest1;
    }
}
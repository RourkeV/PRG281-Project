namespace PRG281_Project
{
    partial class Profile
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
            this.lblNameHead = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblEmailHead = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeHead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBio = new System.Windows.Forms.Label();
            this.rchTxtBio = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameHead
            // 
            this.lblNameHead.AutoSize = true;

            this.lblNameHead.Font = new System.Drawing.Font("Noto Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHead.Location = new System.Drawing.Point(160, 346);

            this.lblNameHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameHead.Name = "lblNameHead";
            this.lblNameHead.Size = new System.Drawing.Size(57, 18);
            this.lblNameHead.TabIndex = 0;
            this.lblNameHead.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;

            this.lblName.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(284, 349);

            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "username";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(206, 40);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(90, 29);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Profile";
            // 
            // lblEmailHead
            // 
            this.lblEmailHead.AutoSize = true;

            this.lblEmailHead.Font = new System.Drawing.Font("Noto Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailHead.Location = new System.Drawing.Point(161, 371);

            this.lblEmailHead.Name = "lblEmailHead";
            this.lblEmailHead.Size = new System.Drawing.Size(55, 18);
            this.lblEmailHead.TabIndex = 3;
            this.lblEmailHead.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;

            this.lblEmail.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(284, 376);

            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "useremail";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;

            this.lblAge.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(284, 401);

            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "userage";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAgeHead
            // 
            this.lblAgeHead.AutoSize = true;

            this.lblAgeHead.Font = new System.Drawing.Font("Noto Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeHead.Location = new System.Drawing.Point(177, 396);

            this.lblAgeHead.Name = "lblAgeHead";
            this.lblAgeHead.Size = new System.Drawing.Size(41, 18);
            this.lblAgeHead.TabIndex = 5;
            this.lblAgeHead.Text = "Age:";
            // 
            // pictureBox1
            // 

            this.pictureBox1.BackColor = System.Drawing.Color.White;

            this.pictureBox1.Location = new System.Drawing.Point(125, 91);

            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 222);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Font = new System.Drawing.Font("Noto Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(31, 448);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(38, 20);
            this.lblBio.TabIndex = 8;
            this.lblBio.Text = "Bio:";
            // 
            // rchTxtBio
            // 
            this.rchTxtBio.Location = new System.Drawing.Point(22, 471);
            this.rchTxtBio.Name = "rchTxtBio";
            this.rchTxtBio.Size = new System.Drawing.Size(477, 96);
            this.rchTxtBio.TabIndex = 9;
            this.rchTxtBio.Text = "";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(524, 596);
            this.Controls.Add(this.rchTxtBio);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAgeHead);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailHead);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameHead;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblEmailHead;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.RichTextBox rchTxtBio;
    }
}
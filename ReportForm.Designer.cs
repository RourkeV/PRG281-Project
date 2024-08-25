namespace PRG281_Project
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtherText = new System.Windows.Forms.TextBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.UnderAgeBox = new System.Windows.Forms.CheckBox();
            this.PhishingBox = new System.Windows.Forms.CheckBox();
            this.CatfishBox = new System.Windows.Forms.CheckBox();
            this.ExplicitBox = new System.Windows.Forms.CheckBox();
            this.OtherBox = new System.Windows.Forms.CheckBox();
            this.HarrassmentBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.OtherText);
            this.groupBox1.Controls.Add(this.ReportButton);
            this.groupBox1.Controls.Add(this.UnderAgeBox);
            this.groupBox1.Controls.Add(this.PhishingBox);
            this.groupBox1.Controls.Add(this.CatfishBox);
            this.groupBox1.Controls.Add(this.ExplicitBox);
            this.groupBox1.Controls.Add(this.OtherBox);
            this.groupBox1.Controls.Add(this.HarrassmentBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // OtherText
            // 
            this.OtherText.Location = new System.Drawing.Point(505, 114);
            this.OtherText.Multiline = true;
            this.OtherText.Name = "OtherText";
            this.OtherText.Size = new System.Drawing.Size(229, 47);
            this.OtherText.TabIndex = 7;
            this.OtherText.Text = "Please tell us more...";
            this.OtherText.Visible = false;
            this.OtherText.Click += new System.EventHandler(this.OtherText_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(347, 203);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(98, 32);
            this.ReportButton.TabIndex = 6;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // UnderAgeBox
            // 
            this.UnderAgeBox.AutoSize = true;
            this.UnderAgeBox.Location = new System.Drawing.Point(444, 30);
            this.UnderAgeBox.Name = "UnderAgeBox";
            this.UnderAgeBox.Size = new System.Drawing.Size(326, 17);
            this.UnderAgeBox.TabIndex = 5;
            this.UnderAgeBox.Text = "Under-Age: Someone an using account while being underaged.";
            this.UnderAgeBox.UseVisualStyleBackColor = true;
            // 
            // PhishingBox
            // 
            this.PhishingBox.AutoSize = true;
            this.PhishingBox.Location = new System.Drawing.Point(38, 73);
            this.PhishingBox.Name = "PhishingBox";
            this.PhishingBox.Size = new System.Drawing.Size(352, 17);
            this.PhishingBox.TabIndex = 4;
            this.PhishingBox.Text = "Phishing: Attempting to obtain sensitive information from another user.";
            this.PhishingBox.UseVisualStyleBackColor = true;
            // 
            // CatfishBox
            // 
            this.CatfishBox.AutoSize = true;
            this.CatfishBox.Location = new System.Drawing.Point(444, 73);
            this.CatfishBox.Name = "CatfishBox";
            this.CatfishBox.Size = new System.Drawing.Size(337, 17);
            this.CatfishBox.TabIndex = 3;
            this.CatfishBox.Text = "Catfishing: Using images of someone that isnt them on their profile.";
            this.CatfishBox.UseVisualStyleBackColor = true;
            // 
            // ExplicitBox
            // 
            this.ExplicitBox.AutoSize = true;
            this.ExplicitBox.Location = new System.Drawing.Point(38, 114);
            this.ExplicitBox.Name = "ExplicitBox";
            this.ExplicitBox.Size = new System.Drawing.Size(320, 17);
            this.ExplicitBox.TabIndex = 2;
            this.ExplicitBox.Text = "Explicit Images: Sending or using explicit images in their profile.";
            this.ExplicitBox.UseVisualStyleBackColor = true;
            // 
            // OtherBox
            // 
            this.OtherBox.AutoSize = true;
            this.OtherBox.Location = new System.Drawing.Point(444, 114);
            this.OtherBox.Name = "OtherBox";
            this.OtherBox.Size = new System.Drawing.Size(55, 17);
            this.OtherBox.TabIndex = 1;
            this.OtherBox.Text = "Other:";
            this.OtherBox.UseVisualStyleBackColor = true;
            this.OtherBox.CheckedChanged += new System.EventHandler(this.OtherBox_CheckedChanged);
            // 
            // HarrassmentBox
            // 
            this.HarrassmentBox.AutoSize = true;
            this.HarrassmentBox.Location = new System.Drawing.Point(38, 30);
            this.HarrassmentBox.Name = "HarrassmentBox";
            this.HarrassmentBox.Size = new System.Drawing.Size(383, 17);
            this.HarrassmentBox.TabIndex = 0;
            this.HarrassmentBox.Text = "Harrassment:  Repeatidly trying to make contact despite being asked not to.";
            this.HarrassmentBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "What Are You Reporting Them For?";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.CheckBox UnderAgeBox;
        private System.Windows.Forms.CheckBox PhishingBox;
        private System.Windows.Forms.CheckBox CatfishBox;
        private System.Windows.Forms.CheckBox ExplicitBox;
        private System.Windows.Forms.CheckBox OtherBox;
        private System.Windows.Forms.CheckBox HarrassmentBox;
        private System.Windows.Forms.TextBox OtherText;
    }
}
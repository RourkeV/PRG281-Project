namespace PRG281_Project
{
    partial class Splash_Screen
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
            this.lblCreators = new System.Windows.Forms.Label();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.prgBarSplash = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgressAmount = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreators
            // 
            this.lblCreators.AutoSize = true;
            this.lblCreators.BackColor = System.Drawing.Color.Pink;
            this.lblCreators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreators.Location = new System.Drawing.Point(12, 9);
            this.lblCreators.Name = "lblCreators";
            this.lblCreators.Size = new System.Drawing.Size(527, 20);
            this.lblCreators.TabIndex = 0;
            this.lblCreators.Text = "Created by: Calvin Nijenhuis, Rourke Veller, Gabriel Botha, Xavier Barnard";
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 75;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // prgBarSplash
            // 
            this.prgBarSplash.BackColor = System.Drawing.Color.Pink;
            this.prgBarSplash.ForeColor = System.Drawing.Color.Crimson;
            this.prgBarSplash.Location = new System.Drawing.Point(46, 376);
            this.prgBarSplash.Name = "prgBarSplash";
            this.prgBarSplash.Size = new System.Drawing.Size(539, 23);
            this.prgBarSplash.TabIndex = 1;
            this.prgBarSplash.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading ...";
            // 
            // lblProgressAmount
            // 
            this.lblProgressAmount.AutoSize = true;
            this.lblProgressAmount.BackColor = System.Drawing.Color.Pink;
            this.lblProgressAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressAmount.Location = new System.Drawing.Point(172, 332);
            this.lblProgressAmount.Name = "lblProgressAmount";
            this.lblProgressAmount.Size = new System.Drawing.Size(103, 25);
            this.lblProgressAmount.TabIndex = 3;
            this.lblProgressAmount.Text = "AMOUNT";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(634, 120);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(327, 108);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "Amore";
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRG281_Project.Properties.Resources.SplashScreen;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblProgressAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgBarSplash);
            this.Controls.Add(this.lblCreators);
            this.Name = "Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreators;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.ProgressBar prgBarSplash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgressAmount;
        private System.Windows.Forms.Label lblAppName;
    }
}
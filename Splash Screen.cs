﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; 
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (prgBarSplash.Value < 100)
            {
                prgBarSplash.Value += 5;
                lblProgressAmount.Text = prgBarSplash.Value.ToString() + "%";

            }
            else
            {
                timerSplash.Stop();
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

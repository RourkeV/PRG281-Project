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
    public partial class enterCheck : Form
    {
        public enterCheck()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sign up button
            UserSignUp signUpPage = new UserSignUp();
            signUpPage.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login button

        }
    }
}

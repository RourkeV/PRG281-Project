using System;
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
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            SwipeForm swipeForm = new SwipeForm();
            swipeForm.Show();

            swipeForm.FormClosed += (s, args) => Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

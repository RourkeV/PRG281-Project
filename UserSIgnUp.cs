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
        public static UserSignUp instance;
        public TextBox email;
        public UserSignUp()
        {
            InitializeComponent();
            instance = this;
            email = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //need to add validation
            string userEmail = textBox1.Text;
            string userPass = textBox2.Text;
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

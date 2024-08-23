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
    public partial class usersLiked : Form
    {
        public usersLiked()
        {
            InitializeComponent();
        }

       likedUsers lUsers = new likedUsers();


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var user in lUsers.users)
            {
                textBox1.Text += $"{user.name1} - {user.email1}  - {user.password1} - {user.age1}\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

        List<UserDetails> users = new List<UserDetails>();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var user in users)
            {
                listBox1.Text += $"{user.name1} - {user.email1}  - {user.password1} - {user.age1}";
            }
        }
    }
}

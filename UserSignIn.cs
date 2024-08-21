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
    public partial class UserSignIn : Form
    {
        List<UserDetails> users = new List<UserDetails>();
        public UserSignIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string email;
            string password;
            email = txtEmail.Text;
            password = txtPass.Text;

            //need to add validation and checks

            //AddingDetails detailPage = new AddingDetails(); ***this page needs to link to swipe page
            //detailPage.Show();
            Visible = false;
            txtEmail.Clear();
        }

        private void UserSignIn_Load(object sender, EventArgs e)
        {
            FullUserList fullUserList = new FullUserList();
            users = fullUserList.AllUsers;
        }
    }
}

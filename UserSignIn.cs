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
        FullUserList fullUserList = new FullUserList();
        List<UserDetails> users = new List<UserDetails>();
        public UserSignIn()
        {
            InitializeComponent();
        }
        private void UserSignIn_Load(object sender, EventArgs e)
        {
            
            users = fullUserList.AllUsers;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {           
           
            bool check = false;
            foreach (UserDetails item in fullUserList.AllUsers)
            {
                //works
                if (txtEmail.Text == item.email1)
                {
                    
                    if (item.password1 == txtPass.Text)
                    {
                        HomePage homePage = new HomePage();
                        homePage.curEmail = txtEmail.Text;
                        homePage.curPass = txtPass.Text;
                        check = true;
                        homePage.Show();
                        this.Hide();
                    }
                }
                
                
            }
            if (check == false)
            {
                MessageBox.Show("invalid email, please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtPass.Text = "";
            }
            
            
            //need to create user alert if login details arent valid
        }

        private void chkBxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxShow.Checked)
            {
                txtPass.PasswordChar = '\0';

            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            new UserSignUp().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

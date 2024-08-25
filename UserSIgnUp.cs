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
        public UserSignUp()
        {
            InitializeComponent();
        }

        public string userEmail;
        public string userPass;

        public virtual void newPage()
        {
            AddingDetails detailPage = new AddingDetails();
            detailPage.Show();
            Visible = false;
            txtEmail.Clear();
        }
        public void emailCheck()
        {
            FullUserList fullUserList = new FullUserList();
            List<UserDetails> list = new List<UserDetails>();
            list = fullUserList.AllUsers;
            foreach (UserDetails user in list)
            {
                if (user.email1 == txtEmail.Text)
                {
                    valid = false;
                }
            }
        }

        public bool valid = true;
        private void button1_Click(object sender, EventArgs e)
        {
            //need to add validation

            if (txtEmail.Text == "" && txtPass.Text == "" && txtPassCon.Text == "")
            {
                MessageBox.Show("A username and password must be provided", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtPassCon.Text) 
            {
                if (txtEmail.Text.Contains('@'))
                {
                    emailCheck();
                    if (valid == true)
                    {
                        userEmail = txtEmail.Text;
                        userPass = txtPass.Text;
                        newPage();
                        MessageBox.Show("Your account has Successfully been Created", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Email already used", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = "";
                        txtPass.Text = "";
                        txtPassCon.Text = "";

                        txtEmail.Focus();
                    }
                }                
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtPassCon.Text = "";
                txtPass.Focus();
            }
        }

        private void chkBxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxShow.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtPassCon.PasswordChar = '\0';

            }
            else
            {
                txtPass.PasswordChar = '*';
                txtPassCon.PasswordChar = '*';
            }
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            new UserSignIn().Show();
            this.Hide();
        }
    }
}

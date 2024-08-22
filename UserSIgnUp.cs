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
            instance = this;
        }

        public string userEmail;
        public string userPass;

        
        public bool valid = true;
        private void button1_Click(object sender, EventArgs e)
        {
            //need to add validation
            
            
            emailCheck();
            if (valid == true)
            {
                userEmail = txtEmail.Text;
                userPass = txtPass.Text;
                newPage();
            }
            else 
            {
                txtPass.Text = "";
                //figure out how to change border style
                //create error message that email in use
            }

            

        }
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
    }
}

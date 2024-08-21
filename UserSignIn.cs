using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
           
            foreach (UserDetails item in fullUserList.AllUsers)
            {
                if (item.email1 == txtEmail.Text)
                {
                    if (item.password1 == txtPass.Text)
                    {
                        current = item;
                        //assign main user must be assigned here
                        //AddingDetails detailPage = new AddingDetails(); ***this page needs to link to swipe page
                        //detailPage.Show();
                        Visible = false;
                        txtEmail.Clear();
                    }
                }
            }            
        }       
    }
}

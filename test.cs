using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        

        private void test_Load(object sender, EventArgs e)
        {
            UserSignUp userSignUp = new UserSignUp();
            AddingDetails details = new AddingDetails();
            UserSignIn userSignIn = new UserSignIn();
            string email;
            string pass;
            if (details.signCheck == true) 
            {
                //if user signed up
                email = userSignUp.userEmail;
                pass = userSignUp.userPass;
                findUser(email, pass);
            }
            if (userSignIn.inCheck == true)
            {
                email = userSignIn.inEmail;
                pass = userSignIn.inEmail;
                findUser(email, pass);
            }
        }
        public string curName;
        public string curEmail;
        public string curPass;
        public decimal curAge;
        public string curSecurity;
        public string curSecAns;
        public void findUser(string email, string password)
        {
            FullUserList userList = new FullUserList();
            List<UserDetails> userDetails = new List<UserDetails>();
            userDetails = userList.AllUsers;
            foreach (UserDetails item in userDetails)
            {
                if (email == item.email1)
                {
                    if (password == item.password1)
                    {
                        curName = item.name1;
                        curEmail = item.email1;
                        curPass = item.password1;
                        curAge = item.age1;
                        curSecurity = item.Security;
                        curSecAns = item.SecAnswer;
                    }
                }
            }
        }
    }
}

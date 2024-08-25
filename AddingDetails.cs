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
    public partial class AddingDetails : Form
    {
        public AddingDetails()
        {
            InitializeComponent();
        }
        public bool signCheck = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //add validation for empty fields
            UserSignUp userSignUp = new UserSignUp();
            string email = userSignUp.userEmail;
            string passw = userSignUp.userPass;
            string first = txtFirst.Text;
            string last = txtLast.Text;
            string fullName = $"{first} {last}";
            decimal age = numAge.Value;
            string gend = cmboGender.Text;
            string bio = rchBio.Text;
            string security = scrtyQstn.Text;
            string secAns = scrtyAnswer.Text;

            
            FullUserList userUserList = new FullUserList();

            userUserList.addUser(fullName, email, passw,gend, age, security, secAns, bio);
            signCheck = true;
            //to add new details UserDetails class needs to be edited (adding new fields), adjust the constructor, and add to newUser
            System.Threading.Thread.Sleep(1000);
            loadingBar load = new loadingBar();
            load.Show();
            this.Hide();
            //loadingBar load = new loadingBar();
            //load.Show(); --> go to loading bar

        }
    }
}

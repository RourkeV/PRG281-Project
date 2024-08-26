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

        private void button1_Click(object sender, EventArgs e)
        {
            //add validation for empty fields
            HomePage homePage = new HomePage();
            FullUserList userUserList = new FullUserList();
            UserSignUp userSignUp = new UserSignUp();

            //curEmail remains blank
            string email = userSignUp.email;
            string password = userSignUp.password;

            homePage.curEmail = email;
            homePage.curPass = password;

            scrtyLbl.Text = homePage.curEmail;


            string first = txtFirst.Text;
            string last = txtLast.Text;
            string fullName = $"{first} {last}";
            homePage.curName = fullName;

            decimal age = numAge.Value;
            homePage.curAge = numAge.Value;
            string gend = cmboGender.Text;
            string bio = rchBio.Text;
            homePage.curBio = rchBio.Text;
            string security = scrtyQstn.Text;
            string secAns = scrtyAnswer.Text;

            
            

            userUserList.addUser(fullName, email, password, gend, age, security, secAns, bio);
            
            //to add new details UserDetails class needs to be edited (adding new fields), adjust the constructor, and add to newUser
            

            homePage.Show();
            this.Hide();

            //loadingBar load = new loadingBar();
            //load.Show(); --> go to loading bar

        }

        private void scrtyAnswer_TextClick(object sender, EventArgs e)
        {
            scrtyAnswer.Text = "";
        }

        private void AddingDetails_Load(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            rchBio.Text = homePage.curEmail;
        }
    }
}

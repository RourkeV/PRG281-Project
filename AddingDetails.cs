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
            UserSignUp userSignUp = new UserSignUp();
            string email = userSignUp.userEmail;
            string passw = userSignUp.userPass;
            string first = txtFirst.Text;
            string last = txtLast.Text;
            string fullName = $"{first} {last}";
            decimal age = numAge.Value;
            UserDetails newUser = new UserDetails(fullName, email, passw, age);
            FullUserList list = new FullUserList();
            list.AllUsers.Add(newUser);
            //to add new details UserDetails class needs to be edited (adding new fields), adjust the constructor, and add to newUser

    }
}

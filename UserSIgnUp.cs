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
        public TextBox email;
        public UserSignUp()
        {
            InitializeComponent();
            instance = this;
        }

        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {

        public string userEmail;
        public string userPass;
        
        private void button1_Click(object sender, EventArgs e)
        {
            //need to add validation
            userEmail = txtEmail.Text;
            userPass = txtPass.Text;
            AddingDetails detailPage = new AddingDetails();
            detailPage.Show();
            Visible = false;
            txtEmail.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

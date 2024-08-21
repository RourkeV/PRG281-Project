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
        
        private void button1_Click(object sender, EventArgs e)
        {
            //need to add validation
            userEmail = txtEmail.Text;
            userPass = txtPass.Text;

            
        }
        public virtual void submit()
        {
            AddingDetails detailPage = new AddingDetails();
            detailPage.Show();
            Visible = false;
            txtEmail.Clear();
        }
    }
}

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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            HomePage user = new HomePage();
            decimal curAge = user.curAge;
            string v = curAge.ToString();
            lblName.Text = user.curName;
            lblEmail.Text = user.curEmail;
            lblAge.Text = v;
            //user.curName
            //user.curEmail
            //user.curPass
            //user.curAge
        }

        
    }
}

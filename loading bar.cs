using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PRG281_Project
{
    public partial class loadingBar : Form
    {
        public loadingBar()
        {
            InitializeComponent();
        }

        private void loadingBar_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            //HomePage homePage = new HomePage();
            //homePage.Show();
            //this.Hide();
        }
    }
}

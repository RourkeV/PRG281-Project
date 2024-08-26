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
    public partial class ReportForm : Form
    {
        HomePage homePage = new HomePage();

       
        public ReportForm()
        {
            InitializeComponent();
        }

        

        private void ReportButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Report has been submitted");
            this.Hide();

            HarrassmentBox.Checked = false;
            ExplicitBox.Checked = false;
            CatfishBox.Checked = false;
            PhishingBox.Checked = false;
            UnderAgeBox.Checked = false;
            OtherBox.Checked = false;
            OtherText.Text= string.Empty;


            
        }

        private void OtherBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OtherBox.Checked == true){  OtherText.Visible = true;}
            else { OtherText.Visible = false;}
        }

        private void OtherText_Click(object sender, EventArgs e)
        {
            OtherText.Text = string.Empty;
        }
    }
}

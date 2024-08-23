using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRG281_Project
{
    public partial class HomePage : Form
    {
        private Point _startPoint;
        private bool _isDragging = false;
        private Point _initialPosition;

        public HomePage()
        {
            InitializeComponent();

            System.Drawing.Image SignOutImg;
            SignOutImg = btnSignOut.Image;
            System.Drawing.Image resizedImage = new Bitmap(SignOutImg, new Size(64, 64));
            btnSignOut.Image = resizedImage;


            userCard.MouseDown += new MouseEventHandler(userCard_MouseDown);
            userCard.MouseMove += new MouseEventHandler(userCard_MouseMove);
            userCard.MouseUp += new MouseEventHandler(userCard_MouseUp);

            userPicture.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            userPicture.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            userPicture.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            userCard_MouseDown(sender, e);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            userCard_MouseMove(sender, e);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            userCard_MouseUp(sender, e);
        }


        private void userCard_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;
            _isDragging = true;
            _initialPosition = userCard.Location;
        }

        private void userCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                var currentPos = this.PointToClient(MousePosition);
                userCard.Left = currentPos.X - _startPoint.X;
                userCard.Top = currentPos.Y - _startPoint.Y;
            }
        }

        private void userCard_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;

            if (userCard.Left > this.Width / 1.7)
            {
                // Swiped right
                MessageBox.Show("Swiped Right!");

                //add user to possible match if other user(maybe a randomiser) also swipes right its a match

                //nextUser();


            }
            else if (userCard.Left < -this.Width / 9092)
            {
                // Swiped left
                MessageBox.Show("Swiped Left!");

                // Dont store user

                //nextUser();
            }

            // Reset the card position
            userCard.Location = _initialPosition;
        }

        private void SwipeForm_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void picBoxChat_Click(object sender, EventArgs e)
        {
            //https://www.flaticon.com/free-icons/chatbot to attribute freepik incase of hassle


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHobbyOne_Click(object sender, EventArgs e)
        {

        }

        private void lblBio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //https://www.flaticon.com/free-icons/filter to attribute freepik incase of hassle
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}

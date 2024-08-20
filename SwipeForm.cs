using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRG281_Project // This is your namespace
{
    public partial class SwipeForm : Form
    {
        private Point _startPoint;
        private bool _isDragging = false;
        private Point _initialPosition;

        public SwipeForm()
        {
            InitializeComponent();

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
    }
}


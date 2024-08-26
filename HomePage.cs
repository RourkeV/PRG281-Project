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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRG281_Project
{
    public partial class HomePage : Form
    {

        private Point _startPoint;
        private bool _isDragging = false;
        private Point _initialPosition;
        usersLiked likedUsers = new usersLiked();



        public HomePage()
        {
            InitializeComponent();
            AddUsersFromList();


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
        likedUsers matchedUsers = new likedUsers();

        private void userCard_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;


            if (userCard.Left > this.Width / 1.7)
            {
                Random random = new Random();
                int number = 0;
                // Swiped right
                MessageBox.Show("Swiped Right!");

                //add user to possible match if other user(maybe a randomiser) also swipes right its a match

                number = random.Next(1, 3);

                if (number == 2)

                {
                    //match = true;
                    matchedUsers.AddUser("Calvin", "Nijenhuis");
                    flowLayoutMessage.Controls.Clear();
                    AddUsersFromList();
                    //matchedUsers.Add(); in brackets add details pushed to form, then add them to tabcontrol
                    //nextUser()
                }
                else
                {
                    matchedUsers.AddUser("Bob", "stone");
                    flowLayoutMessage.Controls.Clear();
                    AddUsersFromList();
                    //nextUser();                  
                }

                displayNew(viewCount);




            }
            else if (userCard.Left < -this.Width / 9092)
            {
                // Swiped left
                MessageBox.Show("Swiped Left!");

                // Dont store user

                //nextUser();
                displayNew(viewCount);
            }

            // Reset the card position
            userCard.Location = _initialPosition;
        }

        private void SwipeForm_Load(object sender, EventArgs e)
        {

        }

        static FullUserList fullUserList = new FullUserList();
        static List<UserDetails> userDetails = new List<UserDetails>();
        static int viewCount = 0;
        private void HomePage_Load(object sender, EventArgs e)
        {//now we have the current user depedning on if the signed in or signed up ***nbnbnb still need to do a full system test

            userDetails = fullUserList.AllUsers;
            findUser(curEmail, curPass);
            txtName.Text = curName;
            txtAge.Text = curAge.ToString();
            rchTxtBio.Text = curBio;
            //for user photo we need to figure out how to store images or just use random images
            displayNew(viewCount);


        }
        public void displayNew(int i)
        {
            string viewName;
            decimal viewAge;
            string viewBio;
            viewName = userDetails[i].name1;
            viewAge = userDetails[i].age1;
            viewBio = userDetails[i].Bio;

            lblSearchName.Text = viewName;
            lblBio.Text = viewBio;
            lblViewAge.Text = viewAge.ToString();

            viewCount++;
        }



        //current user

        public string curName;
        public string curEmail;
        public string curPass;
        public decimal curAge;
        public string curSecurity;
        public string curSecAns;
        public string curBio;



        public void findUser(string email, string password)
        {
            FullUserList userList = new FullUserList();
            List<UserDetails> userDetails = new List<UserDetails>();
            userDetails = userList.AllUsers;
            foreach (UserDetails item in userDetails)
            {
                if (email == item.email1)
                {
                    if (password == item.password1)
                    {
                        curName = item.name1;
                        curEmail = item.email1;
                        curPass = item.password1;
                        curAge = item.age1;
                        curSecurity = item.Security;
                        curSecAns = item.SecAnswer;
                        curBio = item.Bio;
                    }
                }
            }
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

            likedUsers.Show();
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

        private void lblHobbyThree_Click(object sender, EventArgs e)
        {

        }

        private void tabList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAPIProfile_Click(object sender, EventArgs e)
        {
            API displayAPI = new API();
            displayAPI.Show();
        }

        private void lblChatBot_Click(object sender, EventArgs e)
        {

        }
        private void AddUsersFromList()
        {
            foreach (var user in matchedUsers.MatchedUsers)
            {
                AddUser($"{user.Item1} {user.Item2}", matchedUsers.MatchedUsers.IndexOf(user));
            }
        }

        private void AddUser(string userName, int userId)
        {
            // Create a new Button for the user
            System.Windows.Forms.Button userButton = new System.Windows.Forms.Button
            {
                Text = userName,
                BackColor = Color.White,
                Padding = new Padding(3),
                Margin = new Padding(3),
                Width = flowLayoutMessage.Width - 20, // Adjust button width based on panel's size
                Height = 50,
                Parent = flowLayoutMessage,
                Tag = userId
            };

            userButton.Click += UserButton_Click;

            // Add the button to the FlowLayoutPanel
            flowLayoutMessage.Controls.Add(userButton);
            flowLayoutMessage.Invalidate();  // Invalidate the panel to trigger a redraw
            flowLayoutMessage.PerformLayout();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            int userId = (int)clickedButton.Tag;

            // Open chat for the selected user
            //MessageBox.Show($"Opening chat for {clickedButton.Text}");
        }

        private void flowLayoutMessage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

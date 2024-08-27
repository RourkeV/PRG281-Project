using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Runtime.Remoting.Messaging;

using System.Net.Http;
using System.Net.Http.Headers;
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

        bool clickedbtn = false;
        public static readonly HttpClient client = new HttpClient();
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

            textBoxUserChat.KeyDown += new KeyEventHandler(textBox_KeyDown);
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
                //MessageBox.Show("Swiped Right!");

                //add user to possible match if other user(maybe a randomiser) also swipes right its a match

                number = random.Next(1, 3);

                if (number == 2)
                {
                    MessageBox.Show("You have matched!");
                    userChatName = lblSearchName.Text;
                    //match = true;
                    matchedUsers.AddUser(userChatName, userSur);
                    flowLayoutMessage.Controls.Clear();
                    AddUsersFromList();
                    //matchedUsers.Add(); in brackets add details pushed to form, then add them to tabcontrol
                    //nextUser()
                }
                else
                {
                    AddUsersFromList();
                    //nextUser();                  
                }


                displayNew(viewCount);

            }
            else if (userCard.Left < -this.Width / 9092)
            {
                // Swiped left
                //MessageBox.Show("Swiped Left!");

                // Dont store user

                //nextUser();

                displayNew(viewCount);


            }

            // Reset the card position
            userCard.Location = _initialPosition;
        }

        public void displayNew(int i)
        {
            string viewName;
            decimal viewAge;
            string viewBio;

            if (hasFilter == true)
            {
                filter(i);
            }


            viewName = userDetails[viewCount].name1;
            viewAge = userDetails[viewCount].age1;
            viewBio = userDetails[viewCount].Bio;


            lblSearchName.Text = viewName;
            lblBio.Text = viewBio;
            lblViewAge.Text = viewAge.ToString();

            viewCount++;
        }

        static HomePage homePage = new HomePage();
        
        
        public void filter(int userCount)
        {
            decimal viewAge;
            string viewGender;

            viewAge = userDetails[userCount].age1;
            viewGender = userDetails[userCount].Gender;

            decimal minAge = numMin.Value;
            decimal maxAge = numMax.Value;
            string gender = cmbGender.Text;




            while (true)
            {
                
                viewAge = userDetails[viewCount].age1;
                viewGender = userDetails[viewCount].Gender;
                MessageBox.Show(minAge.ToString());
                MessageBox.Show(gender);
                MessageBox.Show(viewAge.ToString());
                MessageBox.Show(viewGender);

                if (viewAge >= minAge && viewAge <= maxAge)
                {

                    if (viewGender == gender)
                    {

                        break;
                    }
                    else 
                    { 
                        viewCount++; 
                    }
                }
                else 
                { 
                    viewCount++;
                }
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            pnlFilter.Visible = false;
            hasFilter = true;

            displayNew(viewCount);
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

        static string userChatName;
        static string userSur = "";





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

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            //https://www.flaticon.com/free-icons/filter to attribute freepik incase of hassle
            pnlFilter.Visible = true;
            

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

        static string nameOfMatchedUser;

        private void UserButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            int userId = (int)clickedButton.Tag;

            // Assuming you have some way to retrieve user details like Name and Bio
            string userName = clickedButton.Text;
            string userBio = "This is the bio of " + userName; // Example bio, replace with actual data retrieval

            nameOfMatchedUser = userName;
            panelChatBot.Visible = true;
            lblChatUser.Visible = true;
            lblUserNameChat.Visible = true;
            textBoxUserChat.Visible = true;
            submitBtnUserChat.Visible = true;

            lblUserNameChat.Text = userName;
        }

        private async Task<string> GetAIResponseAsync(string userInput)
        {
            try
            {
                string apiKey = "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";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var payload = new
                {
                    model = "gpt-3.5-turbo-0125",
                    messages = new[]
                    {
                        new { role = "system", content = "You are to act as a person, this person is being implemented into a chat to simulate what it would be like to chat to another person in our dating app." },
                        new { role = "user", content = userInput }
                    },
                    max_tokens = 350,
                    temperature = 0.7,
                    top_p = 0.85
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(payload),
                    System.Text.Encoding.UTF8,
                    "application/json"
                );

                HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                var jsonResponse = JObject.Parse(result);

                if (jsonResponse["choices"] != null &&
                    jsonResponse["choices"].Any() &&
                    jsonResponse["choices"][0]["message"] != null &&
                    jsonResponse["choices"][0]["message"]["content"] != null)
                {
                    var aiResponse = jsonResponse["choices"][0]["message"]["content"].ToString();
                    return aiResponse;
                }
                else
                {
                    return "AI response not available.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return "Error occurred.";
            }
        }

        private bool lengthValidation(string input)
        {
            return input.Length > 0;
        }

        private async Task SubmitUserInputAsync()
        {
            string userInput = textBoxUserChat.Text.Trim();

            if (lengthValidation(userInput))
            {

                richTextBox.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox.AppendText("User: " + userInput + Environment.NewLine + Environment.NewLine);
                textBoxUserChat.Clear();
                richTextBox.ScrollToCaret();

                string aiResponse = await GetAIResponseAsync(userInput);

                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox.AppendText(nameOfMatchedUser + ": " + aiResponse + Environment.NewLine + Environment.NewLine);
                richTextBox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Input is invalid. Please try again.");
            }
        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            if (clickedbtn == false)
            {
                richTextBox.Clear();
                clickedbtn = true;
            }

            await SubmitUserInputAsync();


        }

        private async void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clickedbtn == false)
                {
                    richTextBox.Clear();
                    clickedbtn = true;
                }

                await SubmitUserInputAsync();
            }
        }

        private void flowLayoutMessage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtAge.ReadOnly = false;
            rchTxtBio.ReadOnly = false;
            btnCommit.Visible = true;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            curName = txtName.Text;
            curAge = int.Parse(txtAge.Text);
            curBio = rchTxtBio.Text;
            btnCommit.Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e, int i)
        {
            string viewName;
            decimal viewAge;
            string gender;
            string viewBio;
            viewName = userDetails[i].name1;
            viewAge = userDetails[i].age1;
            gender = userDetails[i].Gender;
            viewBio = userDetails[i].Bio;

            lblSearchName.Text = viewName;
            lblBio.Text = viewBio;
            lblViewAge.Text = viewAge.ToString();

            viewCount++;

            pnlFilter.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlFilter.Visible = false;
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class ChatBetweenUsersForm : Form
    {
        private likedUsers likedUsers;

        private void ChatBetweenUsersForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutMessage.Controls)
            {
                control.Width = flowLayoutMessage.ClientSize.Width - 20;
            }
            flowLayoutMessage.Invalidate();
            flowLayoutMessage.PerformLayout();
        }

        public ChatBetweenUsersForm()
        {
            InitializeComponent();          // Step 1: Initialize form components
            InitializeUserListPanel();      // Step 2: Initialize and add the FlowLayoutPanel

            likedUsers = new likedUsers();

            AddUsersFromList();             // Step 3: Add users to the FlowLayoutPanel

            this.Resize += new EventHandler(ChatBetweenUsersForm_Resize);
            this.Load += new EventHandler(ChatBetweenUsersForm_Load);
        }

        private void InitializeUserListPanel()
        {
            // Initialize and configure the FlowLayoutPanel
            flowLayoutMessage = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,       // Ensure the panel fills the form
                AutoScroll = true,           // Enable scrolling if content exceeds the panel size
                BorderStyle = BorderStyle.FixedSingle, // Add a border for clarity
                FlowDirection = FlowDirection.TopDown, // Ensure buttons stack vertically
                Padding = new Padding(3),    // Remove padding
                Margin = new Padding(3),
                WrapContents = false
            };

            this.Controls.Add(flowLayoutMessage); // Add it to the form
        }

        private void AddUsersFromList()
        {
            foreach (var user in likedUsers.MatchedUsers)
            {
                AddUser($"{user.Item1} {user.Item2}", likedUsers.MatchedUsers.IndexOf(user));
            }
        }

        private void AddUser(string userName, int userId)
        {
            // Create a new Button for the user
            Button userButton = new Button
            {
                Text = userName,
                BackColor = Color.White,
                Padding = new Padding(3),
                Margin = new Padding(3),
                Width = flowLayoutMessage.ClientSize.Width - 50, // Adjust button width based on panel's size
                Height = 50,
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
            Button clickedButton = sender as Button;
            int userId = (int)clickedButton.Tag;

            // Open chat for the selected user
            MessageBox.Show($"Opening chat for {clickedButton.Text}");
        }

        private void ChatBetweenUsersForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400); // Adjust to a reasonable minimum size

            // Optional: Resize FlowLayoutPanel on load if necessary
            flowLayoutMessage.Width = this.ClientSize.Width;
            flowLayoutMessage.Height = this.ClientSize.Height - 100;
        }

        private void flowLayoutMessage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

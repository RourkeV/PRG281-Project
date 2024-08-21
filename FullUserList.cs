using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    internal class FullUserList
    {       

        private List<UserDetails> allUsers = new List<UserDetails>{
            new UserDetails("John Doe", "john.doe@example.com", "password123", 30, "What was the name of your first pet?", "Max"),
            new UserDetails("Jane Smith", "jane.smith@example.com", "password456", 25, "In what city were you born?", "Denver"),
            new UserDetails("Alice Johnson", "alice.johnson@example.com", "alicepass789", 22, "What is your mother’s maiden name?", "Thompson"),
            new UserDetails("Bob Brown", "bob.brown@example.com", "bobpass000", 28, "What was the make and model of your first car?", "Honda Civic"),
            new UserDetails("Charlie Davis", "charlie.davis@example.com", "charliepass321", 35, "What was the name of your first school?", "Lincoln Elementary"),
            new UserDetails("Diana Evans", "diana.evans@example.com", "dianapass654", 27, "What is the name of the street you grew up on?", "Maple Avenue"),
            new UserDetails("George Hall", "george.hall@example.com", "georgepass222", 31, "What was your childhood nickname?", "Sparky"),
            new UserDetails("Fiona Green", "fiona.green@example.com", "fionapass111", 29, "What is the name of your favorite childhood friend?", "Emma"),
            new UserDetails("Hannah King", "hannah.king@example.com", "hannahpass333", 26, "What was the name of your first employer?", "Burger King"),
            new UserDetails("randTest", "test@test.com", "testing321", 99, "rand", "randans")
        };

        public List<UserDetails> AllUsers { get => allUsers; set => allUsers = value; }

        public void addUser(string name, string email, string password, decimal age, string security, string secAns)
        {
            UserDetails newUser = new UserDetails(name, email, password, age, security, secAns);
            allUsers.Add(newUser);
        }
    }
}
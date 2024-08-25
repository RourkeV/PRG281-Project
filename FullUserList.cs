using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    internal class FullUserList
    {       

        private List<UserDetails> allUsers = new List<UserDetails>{
            new UserDetails("John Doe", "john.doe@example.com", "password123","male", 30,  "What was the name of your first pet?", "Max", "A creative graphic designer with a passion for minimalist designs and vibrant colors. Alex loves photography and experimenting with new art techniques"),
            new UserDetails("Jane Smith", "jane.smith@example.com", "password456", "female", 25, "In what city were you born?", "Denver", "An experienced content writer and editor who specializes in storytelling and brand voice. Sophia enjoys reading historical fiction and baking on weekends."),
            new UserDetails("Alice Johnson", "alice.johnson@example.com", "alicepass789", "female", 22, "What is your mother’s maiden name?", "Thompson", "A software engineer focused on developing scalable web applications. David is an avid hiker and enjoys exploring national parks."),
            new UserDetails("Bob Brown", "bob.brown@example.com", "bobpass000", "male", 28, "What was the make and model of your first car?", "Honda Civic", "A digital marketing strategist with expertise in social media campaigns and SEO. Priya spends her free time volunteering at local animal shelters"),
            new UserDetails("Charlie Davis", "charlie.davis@example.com", "charliepass321", "male", 35, "What was the name of your first school?", "Lincoln Elementary", "A data analyst with a knack for finding trends and patterns in large datasets. Michael is a marathon runner and a coffee enthusiast."),
            new UserDetails("Diana Evans", "diana.evans@example.com", "dianapass654", "female", 27, "What is the name of the street you grew up on?", "Maple Avenue", "A public relations specialist with a strong background in corporate communications. Emily loves traveling and discovering new cuisines."),
            new UserDetails("George Hall", "george.hall@example.com", "georgepass222", "male", 31, "What was your childhood nickname?", "Sparky", "A bilingual educator passionate about fostering inclusive learning environments. Nina is a yoga practitioner and enjoys writing poetry"),
            new UserDetails("Fiona Green", "fiona.green@example.com", "fionapass111", "female", 29, "What is the name of your favorite childhood friend?", "Emma", "A financial advisor helping clients achieve long-term financial goals. Amir is a chess enthusiast and enjoys teaching the game to kids"),
            new UserDetails("Hannah King", "hannah.king@example.com", "hannahpass333", "female", 26, "What was the name of your first employer?", "Burger King", "A UX/UI designer dedicated to creating intuitive digital experiences. Lily is passionate about watercolor painting and collecting vintage stamps."),
            new UserDetails("randTest", "test@test.com", "testing321", "other", 99, "rand", "randans", "A mechanical engineer with a focus on sustainable energy solutions. James enjoys woodworking and is working on building his own furniture.")
        };

        public List<UserDetails> AllUsers { get => allUsers; set => allUsers = value; }

        public void addUser(string name, string email, string password, string gender, decimal age, string security, string secAns, string bio)
        {
            UserDetails newUser = new UserDetails(name, email, password, gender, age, security, secAns, bio);
            allUsers.Add(newUser);
        }
    }
}
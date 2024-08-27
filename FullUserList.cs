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
    internal class FullUserList : IUser
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
            new UserDetails("John Smith", "john.smith@example.com", "johnnyS123", "male", 30, "What is your mother's maiden name?", "Johnson", "A front-end developer who enjoys working with React and exploring new JavaScript frameworks. John is an avid traveler and amateur photographer."),
            new UserDetails("Emily Brown", "emily.brown@example.com", "emilyB456", "female", 24, "What was the make of your first car?", "Toyota", "A data analyst who loves crunching numbers and creating insightful visualizations. Emily is a foodie who enjoys trying new recipes in her spare time."),
            new UserDetails("Michael Johnson", "michael.johnson@example.com", "mikeJ789", "male", 35, "What is the name of your first pet?", "Max", "A project manager with a knack for organization and efficiency. Michael is also a fitness enthusiast who enjoys marathon running."),
            new UserDetails("Sophia Davis", "sophia.davis@example.com", "sophieD321", "female", 28, "What was the name of your elementary school?", "Lincoln Elementary", "A content writer and editor with a love for storytelling. Sophia enjoys writing fiction and hiking in the mountains."),
            new UserDetails("James Wilson", "james.wilson@example.com", "jamesW654", "male", 29, "What city were you born in?", "Boston", "A software engineer specializing in backend development and cloud computing. James enjoys playing chess and reading sci-fi novels."),
            new UserDetails("Olivia Martinez", "olivia.martinez@example.com", "oliviaM987", "female", 27, "What was the name of your childhood best friend?", "Sarah", "A marketing specialist who excels in social media strategies. Olivia is passionate about yoga and sustainable living."),
            new UserDetails("David Lee", "david.lee@example.com", "daveL147", "male", 32, "What was the name of your first pet?", "Buddy", "A cybersecurity expert who loves solving complex security challenges. David enjoys woodworking and building custom furniture."),
            new UserDetails("Emma White", "emma.white@example.com", "emmaW258", "female", 22, "What is your favorite book?", "Pride and Prejudice", "A graphic designer with a passion for brand identity and typography. Emma enjoys digital illustration and playing the piano."),
            new UserDetails("Daniel Thompson", "daniel.thompson@example.com", "danT369", "male", 31, "What was your favorite place to visit as a child?", "Disneyland", "A DevOps engineer focused on automation and continuous integration. Daniel enjoys mountain biking and playing video games."),
            new UserDetails("Ava Anderson", "ava.anderson@example.com", "avaA852", "female", 23, "What is your favorite movie?", "The Matrix", "A copywriter with a talent for crafting compelling narratives. Ava enjoys photography and learning about different cultures."),
            new UserDetails("Benjamin Garcia", "benjamin.garcia@example.com", "benG741", "male", 34, "What was your first job?", "Paperboy", "A network engineer who thrives on troubleshooting and problem-solving. Benjamin enjoys playing guitar and exploring new music genres."),
            new UserDetails("Mia Rodriguez", "mia.rodriguez@example.com", "miaR963", "female", 25, "What is your favorite color?", "Blue", "A product manager with a focus on user-centered design. Mia enjoys gardening and hosting dinner parties."),
            new UserDetails("William Harris", "william.harris@example.com", "willH159", "male", 33, "What was the make of your first car?", "Ford", "A systems architect with expertise in cloud infrastructure. William enjoys fishing and restoring vintage cars."),
            new UserDetails("Isabella Clark", "isabella.clark@example.com", "bellaC753", "female", 26, "What was the name of your first pet?", "Fluffy", "A customer support specialist with a passion for helping people. Isabella enjoys crafting and attending live music events."),
            new UserDetails("Lucas Lewis", "lucas.lewis@example.com", "lucL357", "male", 28, "What was your favorite subject in school?", "History", "A data scientist who loves uncovering patterns and trends. Lucas enjoys playing board games and cooking Italian cuisine."),
            new UserDetails("Charlotte Walker", "charlotte.walker@example.com", "charW654", "female", 27, "What is your favorite sport?", "Soccer", "A digital marketer specializing in SEO and content strategy. Charlotte enjoys jogging and painting landscapes."),
            new UserDetails("Elijah Young", "elijah.young@example.com", "eliY963", "male", 29, "What is the name of your favorite teacher?", "Mr. Thompson", "A UX designer focused on creating seamless digital experiences. Elijah enjoys playing the violin and experimenting with new recipes."),
            new UserDetails("Amelia King", "amelia.king@example.com", "ameliaK852", "female", 24, "What was the name of your childhood pet?", "Whiskers", "A web developer who enjoys building interactive websites. Amelia enjoys reading mystery novels and baking cookies."),
            new UserDetails("Ethan Scott", "ethan.scott@example.com", "ethanS147", "male", 31, "What is your favorite outdoor activity?", "Hiking", "A machine learning engineer who loves working on AI projects. Ethan enjoys rock climbing and playing tennis."),
            new UserDetails("Harper Green", "harper.green@example.com", "harpG258", "female", 26, "What was the name of your high school?", "Riverside High", "A financial analyst with a keen eye for detail and accuracy. Harper enjoys yoga and collecting antique books."),
            new UserDetails("randTest", "test@test.com", "testing321", "other", 99, "rand", "randans", "A mechanical engineer with a focus on sustainable energy solutions. James enjoys woodworking and is working on building his own furniture."),
        };

        public List<UserDetails> AllUsers { get => allUsers; set => allUsers = value; }

        public void addUser(string name, string email, string password, string gender, decimal age, string security, string secAns, string bio)
        {
            UserDetails newUser = new UserDetails(name, email, password, gender, age, security, secAns, bio);
            allUsers.Add(newUser);
        }
    }
}
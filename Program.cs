using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("hellos");
            Console.WriteLine("hell yes");
            Application.Run(new UserSignUp());

        }
        public static List<UserDetails> allUsers = new List<UserDetails>{
            new UserDetails("John Doe", "john.doe@example.com", "password123", 30),
            new UserDetails("Jane Smith", "jane.smith@example.com", "password456", 25),
            new UserDetails("Alice Johnson", "alice.johnson@example.com", "alicepass789", 22),
            new UserDetails("Bob Brown", "bob.brown@example.com", "bobpass000", 28),
            new UserDetails("Charlie Davis", "charlie.davis@example.com", "charliepass321", 35),
            new UserDetails("Diana Evans", "diana.evans@example.com", "dianapass654", 27),
            new UserDetails("George Hall", "george.hall@example.com", "georgepass222", 31),
            new UserDetails("Fiona Green", "fiona.green@example.com", "fionapass111", 29),
            new UserDetails("Hannah King", "hannah.king@example.com", "hannahpass333", 26)
        };
    }
}

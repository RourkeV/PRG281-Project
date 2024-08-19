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

            Console.WriteLine("yo");

            Application.Run(new UserSIgnUp());

        }
        public static List<UserDetails> allUsers = new List<UserDetails>();
    }
}

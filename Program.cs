using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{

    interface IUser
    {
        void addUser(string name, string email, string password, string gender, decimal age, string security, string secAns, string bio);
    }
    internal class Program
    {

        public event DisplayAppHandler DisplayApp;

        public delegate void DisplayAppHandler();
        static void Main(string[] args)
        {
            
            HomePage home = new HomePage();
            Events Event = new Events();
            Program program = new Program();
            program.DisplayApp += program.Run;

            program.DisplayApp.Invoke();

            

            likedUsers liked = new likedUsers();

            // Add specific users to the group (e.g., users older than 30)

            TabControl tab = new TabControl();
            TabPage page = new TabPage();   
            tab.BackColor = System.Drawing.Color.Pink;

        }
        public void Run()
        {
            Application.Run(new Splash_Screen());
            Application.Run(new HomePage());
        }

        

    }
}

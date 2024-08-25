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
            Application.Run(new HomePage());

            likedUsers liked = new likedUsers();

            // Add specific users to the group (e.g., users older than 30)

            TabControl tab = new TabControl();
            TabPage page = new TabPage();   
            tab.BackColor = System.Drawing.Color.Pink;

        }

        

    }
}

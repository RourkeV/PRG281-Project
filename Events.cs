using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    internal class Events
    {
       
        
       
        public int Random()
        {
            Random random = new Random();
            int number = 0;
            // Swiped right
            //MessageBox.Show("Swiped Right!");

            //add user to possible match if other user(maybe a randomiser) also swipes right its a match

            number = random.Next(1, 3);
            return number;
        }
    }
}

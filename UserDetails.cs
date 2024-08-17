using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    internal class UserDetails
    {

        private string name;
        private string email;
        private string password;

        public string name1 { get => name; set => name = value; }
        public string email1 { get => email; set => email = value; }
        public string password1 { get => password; set => password = value; }

        public UserDetails(string name, string email, string password)
        {
            this.name1 = name;
            this.email1 = email;
            this.password1 = password;
        }
    }
}

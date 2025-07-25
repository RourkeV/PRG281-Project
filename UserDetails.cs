﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    internal class UserDetails
    {

        private string name;
        private string email;
        private string password;
        private decimal age;
        private string security;
        private string secAnswer;
        private string bio;
        private string gender;

        public string name1 { get => name; set => name = value; }
        public string email1 { get => email; set => email = value; }
        public string password1 { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public decimal age1 { get => age; set => age = value; }
        public string Security { get => security; set => security = value; }
        public string SecAnswer { get => secAnswer; set => secAnswer = value; }
        public string Bio { get => bio; set => bio = value; }

        public UserDetails(string name, string email, string password,string gender, decimal age, string security, string secAnswer, string bio)
        {
            this.name1 = name;
            this.email1 = email;
            this.password1 = password;
            this.Gender = gender;
            this.age1 = age;
            this.Security = security;
            this.SecAnswer = secAnswer;
            this.Bio = bio;
        }
        
    }
}

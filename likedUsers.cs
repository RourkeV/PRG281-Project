using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    internal class likedUsers
    {
        public List<UserDetails> Users
        { get; set; }

        public void UserGroup()
        {
            Users = new List<UserDetails>();
        }

        public void AddUser(UserDetails user)
        {
            Users.Add(user);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    internal class likedUsers
    {
        FullUserList list = new FullUserList();
        public List<UserDetails> users = new List<UserDetails>();

        public likedUsers()
        {
            users = list.AllUsers;
        }

        

        public void AddUser(UserDetails user)
        {
            users.Add(user);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    internal class likedUsers
    {
        List<Tuple<string, string>> matchedUsers = new List<Tuple<string, string>>();
       
        public void AddUser(string name, string lastname)
        {
            matchedUsers.Add(Tuple.Create(name, lastname));
        }

        public List<Tuple<string, string>> MatchedUsers
        {
            get { return matchedUsers; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{

    internal class LikeObject
    {
        private string fullName;
        private double age;
        private string gender;
        private string bio;
        public LikeObject(string fullName, double age, string gender, string bio) 
        {
            this.FullName = fullName;
            this.Age = age;
            this.Gender = gender;  
            this.Bio = bio;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public double Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Bio { get => bio; set => bio = value; }

        List<LikeObject> likeObjectsList;

        public void addingLiked(string name, double likedAge, string gend, string bio)
        {
            LikeObject newLiked = new LikeObject(name, likedAge, gend, bio);
        }
    }
}

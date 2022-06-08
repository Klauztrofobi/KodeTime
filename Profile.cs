using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodetime
{
    internal class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Bosted { get; set; }
        public string Bursdag { get; set; }
        public bool Loggedin { get; set; }
        public List<Profile> Friends { get; set; }

        public Profile(string name, int age, string bosted, string bursdag, bool loggedin)
        {
            Name = name;
            Age = age;
            Bosted = bosted;
            Bursdag = bursdag;
            Loggedin = loggedin;

        }

        public List<Profile> addFriend(Profile user)
        {

            //Friends = new Profile[] { user };
            Friends.Add(user);
            return Friends;
        }

        public string showFriends()
        {
            string output = "";
           
            for(var i = 0; i < Friends.Count; i++)
            {
                output += Friends[i].Name;
            }
            return output;
          
            //for (var i = 0; i < Friends.Length; i++)
            //{
            //    output += Friends[i].Name;
            //}
            //return output;
        }
    }
}

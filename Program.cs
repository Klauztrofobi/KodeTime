using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Kodetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var therese = new Profile("Therese", 32, "sandefjord", "02.04", true);
            var Thomas = new Profile("Thomas", 30, "Sandefjord", "16.08", false);
            var Truls = new Profile("Truls", 24, "tbg", "06.08", true);


            //Profile[] alleprofiler = new Profile[] { therese, Thomas };

            //therese.addFriend(Thomas);
            //therese.addFriend(Truls);
            //Console.WriteLine(therese.showFriends());
            //for(int i = 0;i < alleprofiler.Length;i++)
            //{
                //Console.WriteLine(alleprofiler[i].Name);
            //}

            var AddFriend = new List<Profile>();
            AddFriend.Add(therese);
            AddFriend.Add(Thomas);

            
        }
    }
}

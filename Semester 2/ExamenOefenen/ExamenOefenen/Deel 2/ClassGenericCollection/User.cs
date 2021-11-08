using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Deel_2.ClassGenericCollection
{
    public class User
    {
        public string Username { get; set; }

        public static List<User> lstUsers = new List<User>();

        public User(string usern)
        {
            Username = usern;
        }

        public void AddToList(User user)
        {
            lstUsers.Add(new User(Username));
        }

    }
}

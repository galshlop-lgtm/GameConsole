using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameConsole.Data
{
    public class UserDb
    {
        private static List<User> users;
        public static User RegisterUser(string name, string uName, string password)
        {
            if (users.Any(u => u.Username == uName))
            {
                throw new InvalidOperationException("the user exists already");
            }
            User newus = new User(name, uName, password);
            users.Add(newus);
            return newus;
        }
        public static User Login(string name, string password)
        {
            return users.FirstOrDefault(u => u.Username == name && u.Password == password);
        }
        public static void Update(User u)
        {
            if (users.Any(user => user == u))
            {
                users.Where(user => user == u).FirstOrDefault().Password = null;
                users.Where(user => user == u).FirstOrDefault().Name = null;
            }
            else
                throw new InvalidOperationException("no such user exists");
        }

    }
}

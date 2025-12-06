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
        public static User Login(string username, string password)
        {
             return users.FirstOrDefault(u => u.Username == username && u.Password == password); 
        }
        public static void Update(User u)
        {
            if (users.Any(user => user.Username == u.Username))
            {
                users.Where(user => user.Username == u.Username).ToList().FirstOrDefault().Password = u.Password;
                users.Where(user => user.Username == u.Username).ToList().FirstOrDefault().Name = u.Name;
            }
            else
                throw new InvalidOperationException("no such user exists");
        }

    }
}

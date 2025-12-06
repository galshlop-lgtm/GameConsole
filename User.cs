using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        List<HighScore> HighScores { get; set; }
        public User(string name, string username, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.HighScores = new List<HighScore>();
        }


    }
}

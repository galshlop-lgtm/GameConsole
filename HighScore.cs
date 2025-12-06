using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        string GameName { get; set; }
        int Score { get; set; }
        DateTime Date { get; set; }
        public HighScore(string gameName, int score)
        {
            this.GameName = gameName;
            this.Score = score;
            this.Date = DateTime.Now;
        }
    }
}

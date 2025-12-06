using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameMenu : Base.MenuScreen
    {
        public GameMenu() : base("GAME MENU")
        {
            Add("Fluffy", new GameScreen(new Games.FluffyBirdGame()));
            Add("PacMan", new GameScreen(new Games.PacManGame()));
            Add("Tetris", new GameScreen(new Games.TetrisGame()));
        }
    }
}

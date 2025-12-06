using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameScreen : Base.Screen
    {
        private IGamePlay game;

        public GameScreen(IGamePlay g) : base(g.Name)
        {
            game = g;
        }

        public override void Show()
        {
            base.Show();
            CenterText($"Starting {game.Name}...");
            game.Play();

            Console.ReadKey();
        }

    }
}

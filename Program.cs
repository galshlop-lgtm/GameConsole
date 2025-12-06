<<<<<<< HEAD
﻿using GameConsole.App;
using GameConsole.Base;
using GameConsole.Games;
=======
﻿using GameConsole.Base;
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
using GameConsole.Interfaces;
using GameConsole.Pages;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======
            //        List<IGamePlay> games = new List<IGamePlay>();
            //        games.Add(new Games.TetrisGame());
            //        games.Add(new Games.FluffyBirdGame());
            //        games.Add(new Games.PacManGame());

            //        foreach (var game in games)
            //        {
            //            game.Play();
            //Console.Write($" Game:{game.Name}");
            //Console.WriteLine($"Score:{game.Score}");
            //        }
         //  Screen mainScreen = new Screen("Home Page");
           // mainScreen.Show();
            Screen welcome = new WelcomeScreen();
            welcome.Show();

>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba


            ConsoleGameApp app = new ConsoleGameApp();
            app.StartApp();


            //List<IGamePlay> games = new List<IGamePlay>();
            //games.Add(new Games.TetrisGame());
            //games.Add(new Games.FluffyBirdGame());
            //games.Add(new Games.PacManGame());

            //foreach (var game in games)
            //{
            //    game.Play();
            //	Console.Write($" Game:{game.Name}");
            //	Console.WriteLine($"Score:{game.Score}");
            //}

        }
    }
}

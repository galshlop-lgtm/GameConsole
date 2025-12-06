using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameConsole.Pages
{
    public class StartScreen : Screen
    {
        public StartScreen() : base("WELCOME TO FIRST PAGE!")
        {
            Show();
        }

        public override void Show()
        {
            base.Show();

            String bob = "WELCOME YA MELEH";
            CenterText(bob);

            Console.ReadKey();

            Screen next = new MainMenu();
            next.Show();
        }
    }


}

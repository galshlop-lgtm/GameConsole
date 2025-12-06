using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
<<<<<<< HEAD
    public class LoginScreen : Screen
    {
        public LoginScreen() : base("LOGIN SCREEN")
        {

        }

        public override void Show()
        {
            base.Show();

            CenterText("Welcome back");
            Screen next = new GameMenu();
            next.Show();

            Console.ReadKey();
        }
    }
=======
	internal class LoginScreen : Screen
	{
		public LoginScreen() : base("Login Page")
		{
		}
		public override void Show()
		{
			base.Show();
			CenterText("Enter Login Info");
			Console.ReadKey();
		}
	}
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
}

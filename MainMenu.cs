using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
<<<<<<< HEAD
    public class MainMenu : MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            Add(new MenuItem("Register", new RegisterScreen()));
            Add("Login", new LoginScreen());
        }
    }
=======
	internal class MainMenu:MenuScreen
	{
		public MainMenu() : base("Main Menu")
		{
			Add(new MenuItem("Register", new RegisterScreen()));
			Add("Login",new LoginScreen());
		}
	}
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
}

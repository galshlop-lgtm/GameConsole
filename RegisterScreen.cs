using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
<<<<<<< HEAD
    public class RegisterScreen : Screen
    {
        public RegisterScreen() : base("REGISTER PAGE")
        {
        }

        public override void Show()
        {
            base.Show();
            CenterText("Enter Your Desired Details");
            Console.ReadKey();
        }
    }
=======
	internal class RegisterScreen : Screen
	{
		public RegisterScreen() : base("Register Page")
		{
		}
		public override void Show()
		{
			base.Show();
			CenterText("Enter Your Desired Details");
			Console.ReadKey();
		}
	}
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
}

using GameConsole.Base;
using GameConsole.Data;
using System;

namespace GameConsole.Pages
{
	internal class LoginScreen : Screen
	{
		public LoginScreen() : base("Login Page")
		{
		}

		public override void Show()
		{
			while (true)
			{
				base.Show();
				CenterText("1) Register");
				CenterText("2) Login");
				CenterText("3) Back");
				Console.Write("Choose (1-3): ");
				var choice = Console.ReadLine()?.Trim();

				if (choice == "1")
				{
					var reg = new RegisterScreen();
					reg.Show();
					continue;
				}
				else if (choice == "2")
				{
					Console.Write("Username: ");
					var username = Console.ReadLine() ?? string.Empty;
					Console.Write("Password: ");
					var password = Console.ReadLine() ?? string.Empty;

					var user = UserDb.Login(username.Trim(), password);
					if (user != null)
					{
						CenterText("Login successful. Press any key to continue.");
						Console.ReadKey();
						var next = new GameMenu();
						next.Show();
						return;
					}
					else
					{
						CenterText("Invalid username or password. Press any key to try again.");
						Console.ReadKey();
						continue;
					}
				}
				else if (choice == "3")
				{
					// go back / exit this screen
					return;
				}
			}
		}
	}
}

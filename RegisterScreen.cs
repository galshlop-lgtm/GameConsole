using GameConsole.Base;
using GameConsole.Data;
using System;

namespace GameConsole.Pages
{
    internal class RegisterScreen : Screen
    {
        public RegisterScreen() : base("Register Page")
        {
        }

        public override void Show()
        {
            while (true)
            {
                base.Show();
                CenterText("Enter Your Details");
                Console.Write("Name: ");
                var name = Console.ReadLine() ?? string.Empty;
                Console.Write("Username: ");
                var username = Console.ReadLine() ?? string.Empty;
                Console.Write("Password: ");
                var password = Console.ReadLine() ?? string.Empty;

                try
                {
                    UserDb.RegisterUser(name.Trim(), username.Trim(), password);
                    CenterText("Registered successfully. Press any key.");
                    Console.ReadKey();
                    return;
                }
                catch (InvalidOperationException)
                {
                    CenterText("That username already exists. Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }
    }
}

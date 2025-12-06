using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
<<<<<<< HEAD
    public class MenuScreen : Screen
    {

        private List<MenuItem> items;
        public MenuScreen(string title) : base("WELCOME TO MENU SCREEN")
        {
            items = new List<MenuItem>();
        }
        public void Add(MenuItem item)
        {
            if (item! != null)
                items.Add(item);
        }
        public void Add(string displayName, Screen sc)
        {
            items.Add(new MenuItem(displayName, sc));
        }
        public override void Show()
        {
            base.Show();

            CenterText("Choose your Screen:");
            bool exit = false;
            int choose = 0;
            while (!exit)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    CenterText($"{i + 1} - {items[i].DisplayName}");
                }
                CenterText($"{items.Count + 1}-Exit");

                CenterText($"choose between 1-{items.Count + 1})");
                int.TryParse(Console.ReadLine(), out choose);
                if (choose > 0 && choose <= items.Count)
                    exit = true;


                if (choose <= items.Count)
                {
                    items[choose - 1].Screen.Show();
                    Console.Clear();
                    Show();
                }
                else
                {
                    exit = true;
                }
            }
            Console.ReadKey();
        }
=======
	internal class MenuScreen : Screen
	{
		private List<MenuItem> items;
		public MenuScreen(string title) : base(title)
		{
			items=new List<MenuItem>();
		}
		public void Add(MenuItem item)
		{
			if(item!!=null)
			items.Add(item);
		}
		public void Add(string displayName, Screen sc)
		{
			items.Add(new MenuItem(displayName, sc));
		}
		public override void Show()
		{
			base.Show();

			CenterText("Choose your Screen:");
			bool exit = false;
			int choose = 0;
			while (!exit)
			{
				for (int i = 0; i < items.Count; i++)
				{
					CenterText($"{i + 1} - {items[i].DisplayName}");
				}
				CenterText($"{items.Count+1}-Exit");

				CenterText($"choose between 1-{items.Count+1})"); 
				int.TryParse(Console.ReadLine(),out choose );
				if (choose > 0 && choose <= items.Count)
					exit = true;


				if (choose <= items.Count)
				{
					items[choose - 1].Screen.Show();
					Console.Clear();
					Show();
				}
				else
				{
					exit = true;
				}
			}
			Console.ReadKey();
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba





<<<<<<< HEAD
    }
=======











		}
		
	}
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
}

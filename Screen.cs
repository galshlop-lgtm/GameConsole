using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace GameConsole.Base
{
    public class Screen
    {
        public String Title
        {
            get; set;
        }

        public Screen(string title)
        {
            Title = title;

        }

        public virtual void Show()
        {

            Console.Clear();
            CenterText(Title);
        }

        public void CenterText(String text)
        {
            Console.SetCursorPosition(Console.WindowTop + (Console.WindowWidth / 2) - (text.Length / 2), Console.CursorTop);
            Console.WriteLine(text);
        }

    }
=======
using Towel.Measurements;

namespace GameConsole.Base
{
	public class Screen
	{
		public string Title
		{
			get; set;
		}

		public Screen(string title)
		{
			Title = title;
		}
		public virtual void Show()
		{
			Console.Clear();

			CenterText(Title);
		    	
		}

		public void CenterText(string text)
		{
			Console.SetCursorPosition((Console.WindowTop + Console.WindowWidth / 2)-text.Length/2, Console.CursorTop);
			Console.WriteLine(text);
		}

		

		

	}
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
}

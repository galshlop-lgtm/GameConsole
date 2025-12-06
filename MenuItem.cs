using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel;
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
<<<<<<< HEAD
    public class MenuItem
    {
        public string DisplayName { get; set; }
        public Screen Screen { get; set; }

        public MenuItem(string displayName, Screen screen)
        {
            this.DisplayName = displayName;
            this.Screen = screen;
        }
    }
=======
	internal class MenuItem
	{
		public string DisplayName
		{
			get; set;
		}
		public Screen Screen
		{
			get; set;
		}

		public MenuItem(string displayName, Screen screen)
		{
			this.DisplayName = displayName;
			this.Screen = screen;
		}

	}
>>>>>>> 689c9d49b1b5e0acc8df0cb55b9216d7101284ba
}

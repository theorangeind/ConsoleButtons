using System;

namespace Console_Graphics_Test
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleColor c1 = ConsoleColor.DarkRed;
			ConsoleColor c2 = ConsoleColor.DarkGreen;
			ConsoleColor c3 = ConsoleColor.White;
			ConsoleColor c4 = ConsoleColor.Black;

			Button b0 = new Button("CLICK", () => b0Action(), c1, c2, c3, c4);
			Button b1 = new Button("CLACK", () => b1Action(), c1, c2, c3, c4);
			Button b2 = new Button("CLOCK", () => b2Action(), c1, c2, c3, c4);

			Button[] list = { b0, b1, b2 };

			GuiMenu menu0 = new GuiMenu(list);

			menu0.run();

			Console.Read();
		}

		private static void b0Action()
		{
			Console.Write("You activated a first button!");
		}

		private static void b1Action()
		{
			Console.Write("You activated a second button!");
		}

		private static void b2Action()
		{
			Console.Write("You activated a third button!");
		}
	}
}

using System;

namespace Console_Graphics_Test
{
	class Button
	{
		const uint nameMaxLength = 24;
		private String buttonName;
		private int buttonPos;

		public ConsoleColor background = ConsoleColor.DarkGray;
		public ConsoleColor backgroundActive = ConsoleColor.Blue;
		public ConsoleColor foreground = ConsoleColor.White;
		public ConsoleColor foregroundActive = ConsoleColor.White;

		public Action buttonAction;

		public Button(String name, Action action)
		{
			this.buttonName = name.Length <= nameMaxLength ? name : name.Substring(0, (int)nameMaxLength);
			this.buttonAction = action;
		}

		public Button(String name, Action action, ConsoleColor cb0, ConsoleColor cb1, ConsoleColor cf0, ConsoleColor cf1)
		{
			this.buttonName = name.Length <= nameMaxLength ? name : name.Substring(0, (int)nameMaxLength);
			this.buttonAction = action;

			this.background = cb0;
			this.backgroundActive = cb1;
			this.foreground = cf0;
			this.foregroundActive = cf1;
		}

		public String getName()
		{
			return this.buttonName;
		}

		public void setState(bool active)
		{
			Console.SetCursorPosition(0, this.buttonPos);

			Console.Write("\t");
			if (!active)
			{
				Console.BackgroundColor = background;
				Console.ForegroundColor = foreground;
			}
			else
			{
				Console.BackgroundColor = backgroundActive;
				Console.ForegroundColor = foregroundActive;
			}

			int space = (int)(Math.Floor((double)((nameMaxLength - this.buttonName.Length) / 2)));
			for (int i = 0; i <= space; i++)
			{
				Console.Write(" ");
			}
			Console.Write(this.buttonName);
			for (int i = space + this.buttonName.Length; i <= nameMaxLength; i++)
			{
				Console.Write(" ");
			}

			Console.ResetColor();
		}

		public void draw()
		{
			Console.Write("\n\t");
			this.buttonPos = Console.CursorTop;
			Console.BackgroundColor = background;
			Console.ForegroundColor = foreground;
			int space = (int)(Math.Floor((double)((nameMaxLength - this.buttonName.Length) / 2)));
			for (int i = 0; i <= space; i++)
			{
				Console.Write(" ");
			}
			Console.Write(this.buttonName);
			for (int i = space + this.buttonName.Length; i <= nameMaxLength; i++)
			{
				Console.Write(" ");
			}

			Console.ResetColor();
			Console.Write("\n");
		}

		public void delete()
		{
			Console.SetCursorPosition(0, this.buttonPos);
			Console.Write("\t");
			for (int i = 0; i < nameMaxLength + 2; i++) Console.Write(" ");
			Console.Write("\r");
		}
	}
}
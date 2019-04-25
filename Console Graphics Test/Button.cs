using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Graphics_Test
{
    class Button
    {
        const uint nameMaxLength = 24;
        private String buttonName;
        private int buttonPos;

        public Action buttonAction;

        public Button(String name, Action action)
        {
            this.buttonName = name.Length <= nameMaxLength ? name : name.Substring(0, (int)nameMaxLength);
            this.buttonAction = action;
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
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
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
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
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
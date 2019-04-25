using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Graphics_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Button b0 = new Button("CLICK", () => b0Action());
            Button b1 = new Button("CLACK", () => b1Action());
            Button b2 = new Button("CLOCK", () => b2Action());

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

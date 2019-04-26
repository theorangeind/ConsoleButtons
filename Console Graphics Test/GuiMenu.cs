using System;

namespace Console_Graphics_Test
{
    class GuiMenu
    {
        Button[] buttonList = { };

        public GuiMenu(Button[] buttons)
        {
            this.buttonList = buttons;
        }

        public void run()
        {
            uint id = 0;

            for (int i = 0; i < buttonList.Length; i++)
                buttonList[i].draw();

            buttonList[0].setState(true);

            for (; ; )
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        buttonList[id].setState(false);
                        id = id > 0 ? id - 1 : (uint)buttonList.Length - 1;
                        buttonList[id].setState(true);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        buttonList[id].setState(false);
                        id = id < buttonList.Length - 1 ? id + 1 : 0;
                        buttonList[id].setState(true);
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        stop();
                        buttonList[id].buttonAction();
                        return;
                    }
                    else { }
                }
            }
        }

        public void stop()
        {
            for (int i = 0; i < buttonList.Length; i++)
            {
                buttonList[i].delete();
            }
            Console.SetCursorPosition(0,0);
        }
    }
}

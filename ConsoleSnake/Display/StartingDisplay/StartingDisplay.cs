using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class StartingDisplay
    {
        public static string[] ASCILogo = new string[] {"             ____",
        "            / . .\\", "            \\  ---<", "             \\  /",
        "   __________/ /", "-=:___________/;"};

        public static string GameTitle = "SNAKE";

        public static void DrawLogo()
        {
            Console.SetCursorPosition(Console.CursorLeft + 4, Console.CursorTop);
            foreach (string line in ASCILogo)
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(line);
                Console.SetCursorPosition(Console.CursorLeft + 4, Console.CursorTop);
            }
            Console.SetCursorPosition(Console.CursorLeft + 6, Console.CursorTop);

            Blinker.Blink(GameTitle);

            Console.SetCursorPosition(7, Console.CursorTop + 1);
            Console.SetCursorPosition(7, Console.CursorTop + 1);
            Console.WriteLine("PRESS ENTER");

            InputListener.ListenToKeyPress(() =>
            {
                Console.Clear();
                Game.Configure();
                Game.StartGame();
            }, ConsoleKey.Enter);
        }

    }
}

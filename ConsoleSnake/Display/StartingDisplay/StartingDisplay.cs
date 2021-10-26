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
        public static string GameSubtitle = "...stupida f*ckin game...";

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
            for (int i = 1; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(GameTitle.ToLower());
                    Console.SetCursorPosition(Console.CursorLeft + 10, Console.CursorTop - 1);
                    System.Threading.Thread.Sleep(250);
                }
                else
                {
                    Console.WriteLine(GameTitle);
                    Console.SetCursorPosition(Console.CursorLeft + 10, Console.CursorTop - 1);
                    System.Threading.Thread.Sleep(250);
                }

            }
            Console.SetCursorPosition(Console.CursorLeft - 10, Console.CursorTop + 1);
            for (int i = 0; i < GameSubtitle.Length; i++)
            {
                Console.Write(GameSubtitle[i]);
                System.Threading.Thread.Sleep(20);
            }
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(7, Console.CursorTop + 1);
            Console.SetCursorPosition(7, Console.CursorTop + 1);
            Console.WriteLine("PRESS ENTER");
            InputListener.ListenToKeyPress(() =>
            {
                Console.Clear();
                Game SnakeGame = new Game();
                SnakeGame.Configure();
                SnakeGame.StartGame();
            }, ConsoleKey.Enter);
        }

    }
}

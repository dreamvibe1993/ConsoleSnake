using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class DisplayActions
    {
        public static void DrawTopBoundary()
        {
            for (int i = 0; i < Display.Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('▒');
            }
        }
        public static void DrawRightBoundary()
        {
            for (int i = 0; i < Display.Height; i++)
            {
                Console.SetCursorPosition(Display.Width, i);
                Console.Write('▒');
            }
        }
        public static void DrawBottomBoundary()
        {
            for (int i = Display.Width; i > 0; i--)
            {
                Console.SetCursorPosition(i, Display.Height);
                Console.Write('▒');
            }
        }
        public static void DrawLeftBoundary()
        {
            for (int i = 0; i < Display.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('▒');
            }
        }

        public static void ErasePoint(Snake snake)
        {
            Console.SetCursorPosition(snake.posX, snake.posY);
            Console.Write(' ');
        }

        public static void DrawPoint(Snake snake)
        {
            Console.SetCursorPosition(snake.posX, snake.posY);
            Console.Write('█');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class DisplayActions
    {
        public static List<Coords> drawnPoints = new List<Coords>();

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
            Console.SetCursorPosition(40, 8);
            Console.Write($"drawn points count: {drawnPoints.Count}");
            Console.SetCursorPosition(40, 7);
            Console.Write($"snake length: {snake.length}");
            Coords coords = new Coords() { posX = 2, posY = 2 };

            if (drawnPoints.Count > 0)
            {
                coords = drawnPoints.ElementAt(0);
            }

            Console.SetCursorPosition(coords.posX, coords.posY);
            Console.Write(' ');
        }

        public static void DrawPoint(Snake snake)
        {
            AddToCoordsHistory(snake);
            Console.SetCursorPosition(snake.posX, snake.posY);
            Console.Write('*');
        }

        public static void AddToCoordsHistory(Snake snake)
        {
            drawnPoints.Add(new Coords() { posX = snake.posX, posY = snake.posY });
            if (drawnPoints.Count > snake.length + 1)
            {
                drawnPoints.RemoveAt(0);
            }
        }
    }
}

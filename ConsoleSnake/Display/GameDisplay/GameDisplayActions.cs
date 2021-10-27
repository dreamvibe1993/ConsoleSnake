using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class GameDisplayActions
    {
        public static List<Coords> DrawnPointsHistory = new List<Coords>();

        public static void DrawTopBoundary()
        {
            for (int i = 0; i < GameDisplay.Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('▒');
            }
        }
        public static void DrawRightBoundary()
        {
            for (int i = 0; i < GameDisplay.Height; i++)
            {
                Console.SetCursorPosition(GameDisplay.Width, i);
                Console.Write('▒');
            }
        }
        public static void DrawBottomBoundary()
        {
            for (int i = GameDisplay.Width; i > 0; i--)
            {
                Console.SetCursorPosition(i, GameDisplay.Height);
                Console.Write('▒');
            }
        }
        public static void DrawLeftBoundary()
        {
            for (int i = 0; i < GameDisplay.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('▒');
            }
        }

        public static void ErasePoint()
        {
            Coords Coords = new Coords() { PosX = Snake.PosX, PosY = Snake.PosY };

            if (DrawnPointsHistory.Count > 0)
            {
                Coords = DrawnPointsHistory.ElementAt(0);
            }

            Console.SetCursorPosition(Coords.PosX, Coords.PosY);
            Console.Write(' ');
        }

        public static void DrawPoint()
        {
            AddToCoordsHistory();
            Console.SetCursorPosition(Snake.PosX, Snake.PosY);
            Console.Write('■');
        }

        public static void AddToCoordsHistory()
        {
            DrawnPointsHistory.Add(new Coords() { PosX = Snake.PosX, PosY = Snake.PosY });
            if (DrawnPointsHistory.Count > Snake.Length + 1)
            {
                DrawnPointsHistory.RemoveAt(0);
            }
        }
    }
}

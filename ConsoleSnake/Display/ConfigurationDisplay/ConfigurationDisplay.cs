using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class ConfigurationDisplay
    {
        static Dictionary<ConsoleKey, int[]> TimerIntervals = new Dictionary<ConsoleKey, int[]>() {
            { ConsoleKey.D1, new int[] { 8000, 500, 250, 250 } },
            { ConsoleKey.D2, new int[] { 6000, 400, 200, 200 } },
            { ConsoleKey.D3, new int[] { 1500, 200, 110, 110 } },
            { ConsoleKey.D4, new int[] { 1000, 150, 50, 50 } },
        };

        static Dictionary<ConsoleKey, string> Levels = new Dictionary<ConsoleKey, string>() {
            { ConsoleKey.D1, "EASY" },
            { ConsoleKey.D2, "NORMAL" },
            { ConsoleKey.D3, "HARD" },
            { ConsoleKey.D4, "NUTS MODE!" },
        };

        public static int[] Intervals;
        public static ConsoleKey KeyPressed;
        public static string Level;

        public static void AskHowHard()
        {
            Console.SetCursorPosition(2, Console.CursorTop + 1);
            Console.SetCursorPosition(2, Console.CursorTop + 1);

            Console.Write("Choose your level. \n  Press 1 for easy, \n  2 for normal, \n  3 for hard, \n  4 for nuts mode.");

            InputListener.ListenToKeysPress((ConsoleKey key) =>
            {
                Intervals = TimerIntervals.GetValueOrDefault(key);
                Level = Levels.GetValueOrDefault(key);
            }, new ConsoleKey[4] { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.D4 });

            if (Intervals == null)
            {
                Console.Clear();
                throw new Exception("Something went wrong at configuration display. Intervals are null.");
            }

            Console.Clear();
            Console.SetCursorPosition(5, GameDisplay.Height / 4);
            Console.WriteLine($"You chose {Level}.");
            Console.SetCursorPosition(5, GameDisplay.Height / 4 + 1);
            Console.SetCursorPosition(5, GameDisplay.Height / 4 + 1);
            Console.WriteLine("TO START PRESS: \n     W || A || S || D");
            Thread.Sleep(2500);
            Console.Clear();

        }
    }
}

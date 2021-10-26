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
            { ConsoleKey.D1, "you chose easy" },
            { ConsoleKey.D2, "you chose normal" },
            { ConsoleKey.D3, "you chose hard" },
            { ConsoleKey.D4, "you f*cking nuts man. seek help." },
        };

        public static int[] Intervals;
        public static ConsoleKey KeyPressed;
        public static string Level;

        public static void AskHowHard()
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
            Console.WriteLine("Choose your level. \nPress 1 for easy, \n2 for normal, \n3 for hard, \n4 for nuts mode.");
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
            Console.SetCursorPosition(GameDisplay.Width / 2 - 10, GameDisplay.Height / 2);
            Console.WriteLine($"{Level}");
            Thread.Sleep(1500);
            Console.Clear();

        }
    }
}

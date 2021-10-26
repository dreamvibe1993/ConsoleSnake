using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleSnake.Delegates;

namespace ConsoleSnake
{
    public class InputListener
    {
        static bool ContinueListening = true;
        static TimerActions Timer = new TimerActions(250, 250);

        public static void ListenWASD(Snake Snake)
        {
            ConsoleKeyInfo KeyInfo;
            SnakeActions SnakeControl = new SnakeActions();

            Timer = new TimerActions(Snake.SpeedIntervals[0], Snake.SpeedIntervals[1]);

            GameDisplayActions.AddToCoordsHistory(Snake);

            while (ContinueListening)
            {
                KeyInfo = Console.ReadKey(true);
                if (KeyInfo.Key == ConsoleKey.W)
                {
                    Timer.RepeatSnakeAction(SnakeControl.MoveUp, Snake, KeyInfo.Key);
                }
                if (KeyInfo.Key == ConsoleKey.A)
                {
                    Timer.RepeatSnakeAction(SnakeControl.MoveLeft, Snake, KeyInfo.Key);
                }
                if (KeyInfo.Key == ConsoleKey.S)
                {
                    Timer.RepeatSnakeAction(SnakeControl.MoveDown, Snake, KeyInfo.Key);
                }
                if (KeyInfo.Key == ConsoleKey.D)
                {
                    Timer.RepeatSnakeAction(SnakeControl.MoveRight, Snake, KeyInfo.Key);
                }

            }
        }

        public static void ListenToKeyPress(Action Action, ConsoleKey Key)
        {
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            while (true)
            {
                if (KeyInfo.Key == Key)
                {
                    break;
                }
                else
                {
                    KeyInfo = Console.ReadKey(true);
                }
            }
            Action();
        }

        public static void ListenToKeysPress(KeyPressedHandler Action, ConsoleKey[] Keys)
        {
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            while (true)
            {
                if (Keys.Contains(KeyInfo.Key))
                {
                    break;
                }
                else
                {
                    KeyInfo = Console.ReadKey(true);
                }
            }
            Action(KeyInfo.Key);
        }
        public static void StopListening()
        {
            Timer.Timer.Dispose();
            ContinueListening = false;
        }

    }
}

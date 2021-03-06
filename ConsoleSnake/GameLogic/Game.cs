using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class Game
    {
        static TimerActions TimerAction;
        public static void Configure()
        {

            GameDisplay.Width = 30;
            GameDisplay.Height = 30 / 2;

            ConfigurationDisplay.AskHowHard();

            TimerAction = new TimerActions(ConfigurationDisplay.Intervals[0], ConfigurationDisplay.Intervals[1]);

            Snake.PosX = GameDisplay.Width / 2;
            Snake.PosY = GameDisplay.Height / 2;

            Snake.SpeedIntervals = new int[] { ConfigurationDisplay.Intervals[2], ConfigurationDisplay.Intervals[3] };

        }
        public static void StartGame()
        {

            Thread SnekThread = new Thread(InputListener.ListenWASD);

            GameDisplayActions.DrawTopBoundary();
            GameDisplayActions.DrawRightBoundary();
            GameDisplayActions.DrawLeftBoundary();
            GameDisplayActions.DrawBottomBoundary();

            Console.SetCursorPosition(GameDisplay.Width + 2, 2);
            Console.Write("Score: 0");

            TimerAction.RepeatFruitCreationAction();
            Threads.AddToTimersCollection(TimerAction.Timer);
            SnekThread.Start();
        }
    }
}

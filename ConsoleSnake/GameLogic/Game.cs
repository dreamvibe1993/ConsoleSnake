using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Game
    {
        TimerActions TimerAction;

        Snake Snake;
        public void Configure()
        {

            GameDisplay.Width = 30;
            GameDisplay.Height = 30 / 2;

            ConfigurationDisplay.AskHowHard();

            TimerAction = new TimerActions(ConfigurationDisplay.Intervals[0], ConfigurationDisplay.Intervals[1]);

            Snake = new Snake(GameDisplay.Width / 2, GameDisplay.Height / 2);

            Snake.SpeedIntervals = new int[] { ConfigurationDisplay.Intervals[2], ConfigurationDisplay.Intervals[3] };

        }
        public void StartGame()
        {


            GameDisplayActions.DrawTopBoundary();
            GameDisplayActions.DrawRightBoundary();
            GameDisplayActions.DrawLeftBoundary();
            GameDisplayActions.DrawBottomBoundary();

            Console.SetCursorPosition(40, 10);
            Console.Write("Score: ");

            TimerAction.RepeatFruitCreationAction();
            Threads.AddToTimersCollection(TimerAction.Timer);
            InputListener.ListenWASD(Snake);
        }
    }
}

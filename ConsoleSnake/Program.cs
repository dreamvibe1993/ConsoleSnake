using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {

            Display.Width = 30;
            Display.Height = 30 / 2;
            StepTimer timerForFruitAddition = new StepTimer(500, 500);

            Snake snake = new Snake(1, 2);


            DisplayActions.DrawTopBoundary();
            DisplayActions.DrawRightBoundary();
            DisplayActions.DrawLeftBoundary();
            DisplayActions.DrawBottomBoundary();

            timerForFruitAddition.RepeatAction();
            Threads.SetTimers(timerForFruitAddition.timer);
            InputListener.Listen(snake);

        }
    }
}

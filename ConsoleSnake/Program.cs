using System;
using System.Threading;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {

            Display.Width = 30;
            Display.Height = 30 / 2;

            StepTimer timerForFruitAddition = new StepTimer(8000, 500);

            Snake snake = new Snake(1, 2);
            Thread threadForSnake = new Thread(InputListener.Listen);
            Thread threadForFruits = new Thread(timerForFruitAddition.RepeatAction);


            threadForSnake.Start(snake);
            threadForFruits.Start();


            DisplayActions.DrawTopBoundary();
            DisplayActions.DrawRightBoundary();
            DisplayActions.DrawLeftBoundary();
            DisplayActions.DrawBottomBoundary();
        }
    }
}

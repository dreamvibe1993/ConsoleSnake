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
            Snake snake = new Snake(1, 2);

            Thread thread = new Thread(InputListener.Listen);

            thread.Start(snake);

            DisplayActions.DrawTopBoundary();
            DisplayActions.DrawRightBoundary();
            DisplayActions.DrawLeftBoundary();
            DisplayActions.DrawBottomBoundary();
        }
    }
}

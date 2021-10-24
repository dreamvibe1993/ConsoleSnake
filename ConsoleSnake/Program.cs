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
            TimerActions TimerAction = new TimerActions(8000, 500);

            Snake Snake = new Snake(1, 2);

            Console.CursorVisible = false;

            DisplayActions.DrawTopBoundary();
            DisplayActions.DrawRightBoundary();
            DisplayActions.DrawLeftBoundary();
            DisplayActions.DrawBottomBoundary();

            Console.SetCursorPosition(40, 10);
            Console.Write("Score: ");

            TimerAction.RepeatFruitCreationAction();
            Threads.SetTimers(TimerAction.Timer);
            InputListener.Listen(Snake);

        }
    }
}

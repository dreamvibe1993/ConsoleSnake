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


            Snake snake = new Snake(1, 2);


            //Threads threads = new Threads();
            //threads.SetCancellationSources(cancellationSource);
            //Threads.test = cancellationSource.Token;

            //Task threadForFruits = new Task(() =>
            //{
            //    Console.WriteLine("YA V AHUE");
            //    if (token.IsCancellationRequested)
            //    {
            //        Console.WriteLine("YA V AHUE");
            //        token.ThrowIfCancellationRequested();
            //    }

            //    timerForFruitAddition.RepeatAction();
            //}, token);

            DisplayActions.DrawTopBoundary();
            DisplayActions.DrawRightBoundary();
            DisplayActions.DrawLeftBoundary();
            DisplayActions.DrawBottomBoundary();

            //threadForFruits.Start();
            Threads.StartThreadForFruits();
            InputListener.Listen(snake);

        }
    }
}

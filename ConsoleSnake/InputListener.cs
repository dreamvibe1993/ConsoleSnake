using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class InputListener
    {
        static bool continueListening = true;
        static StepTimer timer = new StepTimer(250, 250);
        public static void Listen(object snakeInitPos)
        {
            ConsoleKeyInfo keyInfo;
            SnakeActions snakeControl = new SnakeActions();
            Snake snake = (Snake)snakeInitPos;


            while (continueListening)
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.W)
                {
                    timer.RepeatAction(snakeControl.MoveUp, snake, keyInfo.Key);
                }
                if (keyInfo.Key == ConsoleKey.A)
                {
                    timer.RepeatAction(snakeControl.MoveLeft, snake, keyInfo.Key);
                }
                if (keyInfo.Key == ConsoleKey.S)
                {
                    timer.RepeatAction(snakeControl.MoveDown, snake, keyInfo.Key);
                }
                if (keyInfo.Key == ConsoleKey.D)
                {
                    timer.RepeatAction(snakeControl.MoveRight, snake, keyInfo.Key);
                }

            }
        }
        public static void StopListening()
        {
            timer.timer.Dispose();
            continueListening = false;
        }

    }
}

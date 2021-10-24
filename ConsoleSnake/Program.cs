using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {

            Game SnakeGame = new Game();

            SnakeGame.Configure();

            SnakeGame.StartGame();

        }
    }
}

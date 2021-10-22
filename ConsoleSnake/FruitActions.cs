using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class FruitActions
    {
        public static void DrawFruit()
        {

            Random randomX = new Random();

            Random randomY = new Random();

            Fruit fruit = new Fruit(randomX.Next(1, Display.Width), randomY.Next(2, Display.Height));

            Console.SetCursorPosition(fruit.posX, fruit.posY);
            Console.Write('§');
        }
    }
}

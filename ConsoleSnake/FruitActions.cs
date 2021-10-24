using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class FruitActions
    {
        public static List<Fruit> fruitsOnDisplay = new List<Fruit>();
        public void DrawFruit()
        {

            Random randomX = new Random();

            Random randomY = new Random();


            Fruit fruit = new Fruit(randomX.Next(1, Display.Width), randomY.Next(2, Display.Height));

            bool isFruitCoordsOccupated = DisplayActions.drawnPoints.Exists((point) => fruit.posX == point.posX && fruit.posY == point.posY);

            if (isFruitCoordsOccupated)
            {
                Console.SetCursorPosition(60, 50);
                Console.Write("REDRAW");
                DrawFruit();
                return;
            }

            fruitsOnDisplay.Add(fruit);

            Console.SetCursorPosition(fruit.posX, fruit.posY);
            Console.Write('§');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class FruitActions
    {
        public static List<Fruit> FruitsCurrentlyOnDisplay = new List<Fruit>();
        public void DrawFruit()
        {

            Random RandomX = new Random();

            Random RandomY = new Random();

            Fruit Fruit = new(RandomX.Next(1, GameDisplay.Width), RandomY.Next(2, GameDisplay.Height));

            Coords IsFruitCoordsOccupated = GameDisplayActions.DrawnPointsHistory.Find((point) => Fruit.PosX == point.PosX || Fruit.PosY == point.PosY);

            if (IsFruitCoordsOccupated != null)
            {
                return;
            }

            FruitsCurrentlyOnDisplay.Add(Fruit);

            Console.SetCursorPosition(Fruit.PosX, Fruit.PosY);
            Console.Write('☻');
        }
    }
}

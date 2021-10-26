using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Checks
    {
        public void CheckIfWin()
        {

        }

        public static void CheckIfOutOfBounds(Snake Snake)
        {
            if (Snake.PosX < 1 || Snake.PosX > GameDisplay.Width - 1)
            {
                Threads.DropAllTimers();
                InputListener.StopListening();
            }

            if (Snake.PosY < 1 || Snake.PosY > GameDisplay.Height - 1)
            {
                Threads.DropAllTimers();
                InputListener.StopListening();
            }
        }

        public static void CheckIfAteItself(Snake Snake)
        {

            if (GameDisplayActions.DrawnPointsHistory.Count < 5) return;

            bool isBitten = GameDisplayActions.DrawnPointsHistory
                .GetRange(0, GameDisplayActions.DrawnPointsHistory.Count - 2)
                .Exists((point) => Snake.PosX == point.PosX && Snake.PosY == point.PosY);

            if (isBitten)
            {
                Threads.DropAllTimers();
                InputListener.StopListening();
                Console.SetCursorPosition(40, 5);
                Console.Write($"SNEK ATE HIMSELF");
            }
        }

        public static void CheckIfAteFruit(Snake Snake)
        {
            Fruit eatenFruit = FruitActions.FruitsCurrentlyOnDisplay.Find(
                fruit => fruit.PosX == Snake.PosX && fruit.PosY == Snake.PosY
            );
            if (eatenFruit != null)
            {
                Snake.Length++;
                FruitActions.FruitsCurrentlyOnDisplay.Remove(eatenFruit);
                Console.SetCursorPosition(40, 5);
                Console.Write($"Score: {Snake.Length}");
                Console.SetCursorPosition(40, 11);
                Console.Write($"Fruits history: {FruitActions.FruitsCurrentlyOnDisplay.Count}");
                Console.SetCursorPosition(40, 12);
                Console.Write($"Drawn points history: {GameDisplayActions.DrawnPointsHistory.Count}");
            }
        }
    }
}

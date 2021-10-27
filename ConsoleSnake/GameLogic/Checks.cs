using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Checks
    {
        public void CheckIfWin()
        {

        }

        public static void CheckIfOutOfBounds()
        {
            if (Snake.PosX < 1 || Snake.PosX > GameDisplay.Width - 1)
            {
                Threads.DropAllTimers();
                InputListener.StopListening();
                Thread.Sleep(500);
                GameOverDisplay.InformPlayerThatTheyLose("Your snek crashed into the wall!");
            }

            if (Snake.PosY < 1 || Snake.PosY > GameDisplay.Height - 1)
            {
                Threads.DropAllTimers();
                InputListener.StopListening();
                Thread.Sleep(500);
                GameOverDisplay.InformPlayerThatTheyLose("Your snek crashed into the wall!");
            }
        }

        public static void CheckIfAteItself()
        {

            if (GameDisplayActions.DrawnPointsHistory.Count < 5) return;

            bool isBitten = GameDisplayActions.DrawnPointsHistory
                .GetRange(0, GameDisplayActions.DrawnPointsHistory.Count - 2)
                .Exists((point) => Snake.PosX == point.PosX && Snake.PosY == point.PosY);

            if (isBitten)
            {
                Threads.DropAllTimers();
                InputListener.StopListening();
                Thread.Sleep(500);
                GameOverDisplay.InformPlayerThatTheyLose("Your snek bit himself!");
            }
        }

        public static void CheckIfAteFruit()
        {
            Fruit eatenFruit = FruitActions.FruitsCurrentlyOnDisplay.Find(
                fruit => fruit.PosX == Snake.PosX && fruit.PosY == Snake.PosY
            );
            if (eatenFruit != null)
            {
                Snake.Length++;
                Console.SetCursorPosition(GameDisplay.Width + 2, 2);
                Console.Write($"Score: {Snake.Length}");
                FruitActions.FruitsCurrentlyOnDisplay.Remove(eatenFruit);
            }
        }
    }
}

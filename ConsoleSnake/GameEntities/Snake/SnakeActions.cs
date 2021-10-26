using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class SnakeActions
    {
        public void MoveToInitialPosition(Snake Snake)
        {
            GameDisplayActions.DrawPoint(Snake);
        }
        public void MoveUp(Snake Snake)
        {
            GameDisplayActions.ErasePoint(Snake);
            GameDisplayActions.DrawPoint(Snake);
            Snake.PosY -= 1;
            Checks.CheckIfOutOfBounds(Snake);
            Checks.CheckIfAteItself(Snake);
            Checks.CheckIfAteFruit(Snake);
        }

        public void MoveDown(Snake Snake)
        {
            GameDisplayActions.ErasePoint(Snake);
            GameDisplayActions.DrawPoint(Snake);
            Snake.PosY += 1;
            Checks.CheckIfOutOfBounds(Snake);
            Checks.CheckIfAteItself(Snake);
            Checks.CheckIfAteFruit(Snake);
        }

        public void MoveRight(Snake Snake)
        {
            GameDisplayActions.ErasePoint(Snake);
            GameDisplayActions.DrawPoint(Snake);
            Snake.PosX += 1;
            Checks.CheckIfOutOfBounds(Snake);
            Checks.CheckIfAteItself(Snake);
            Checks.CheckIfAteFruit(Snake);
        }

        public void MoveLeft(Snake Snake)
        {
            GameDisplayActions.ErasePoint(Snake);
            GameDisplayActions.DrawPoint(Snake);
            Snake.PosX -= 1;
            Checks.CheckIfOutOfBounds(Snake);
            Checks.CheckIfAteItself(Snake);
            Checks.CheckIfAteFruit(Snake);
        }
    }
}

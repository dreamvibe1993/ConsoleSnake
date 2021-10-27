using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class SnakeActions
    {
        public void MoveToInitialPosition()
        {
            GameDisplayActions.DrawPoint();
        }
        public void MoveUp()
        {
            GameDisplayActions.ErasePoint();
            Snake.PosY -= 1;
            GameDisplayActions.DrawPoint();
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }

        public void MoveDown()
        {
            GameDisplayActions.ErasePoint();
            Snake.PosY += 1;
            GameDisplayActions.DrawPoint();
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }

        public void MoveRight()
        {
            GameDisplayActions.ErasePoint();
            Snake.PosX += 1;
            GameDisplayActions.DrawPoint();
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }

        public void MoveLeft()
        {
            GameDisplayActions.ErasePoint();
            Snake.PosX -= 1;
            GameDisplayActions.DrawPoint();
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }
    }
}

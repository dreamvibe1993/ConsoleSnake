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
            GameDisplayActions.DrawPoint();
            Snake.PosY -= 1;
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }

        public void MoveDown()
        {
            GameDisplayActions.ErasePoint();
            GameDisplayActions.DrawPoint();
            Snake.PosY += 1;
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }

        public void MoveRight()
        {
            GameDisplayActions.ErasePoint();
            GameDisplayActions.DrawPoint();
            Snake.PosX += 1;
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }

        public void MoveLeft()
        {
            GameDisplayActions.ErasePoint();
            GameDisplayActions.DrawPoint();
            Snake.PosX -= 1;
            Checks.CheckIfOutOfBounds();
            Checks.CheckIfAteItself();
            Checks.CheckIfAteFruit();
        }
    }
}

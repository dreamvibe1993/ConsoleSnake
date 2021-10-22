using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class SnakeActions
    {
        public void MoveToInitialPosition(Snake snake)
        {
            DisplayActions.DrawPoint(snake);
        }
        public void MoveUp(Snake snake)
        {
            DisplayActions.ErasePoint(snake);
            snake.posY -= 1;
            DisplayActions.DrawPoint(snake);
            Checks.CheckIfLose(snake);
            Checks.CheckIfAteFruit(snake);
        }

        public void MoveDown(Snake snake)
        {
            DisplayActions.ErasePoint(snake);
            snake.posY += 1;
            DisplayActions.DrawPoint(snake);
            Checks.CheckIfLose(snake);
            Checks.CheckIfAteFruit(snake);
        }

        public void MoveRight(Snake snake)
        {
            DisplayActions.ErasePoint(snake);
            snake.posX += 1;
            DisplayActions.DrawPoint(snake);
            Checks.CheckIfLose(snake);
            Checks.CheckIfAteFruit(snake);
        }

        public void MoveLeft(Snake snake)
        {
            DisplayActions.ErasePoint(snake);
            snake.posX -= 1;
            DisplayActions.DrawPoint(snake);
            Checks.CheckIfLose(snake);
            Checks.CheckIfAteFruit(snake);
        }
    }
}

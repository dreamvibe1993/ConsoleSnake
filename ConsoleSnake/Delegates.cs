using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Delegates
    {
        public delegate void MovingSnakeActionDelegate();

        public delegate void AddingFruitActionDelegate();

        public delegate void KeyPressedHandler(ConsoleKey Key);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Delegates
    {
        public delegate void MovingSnakeActionDelegate(Snake snake);

        public delegate void AddingFruitActionDelegate();
    }
}

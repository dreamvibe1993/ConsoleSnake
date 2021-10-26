using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Snake : Coords
    {
        public int Length = 0;
        public int[] SpeedIntervals { get; set; }
        public Snake (int x, int y)
        {
            PosX = x;
            PosY = y;
        }

    }
}

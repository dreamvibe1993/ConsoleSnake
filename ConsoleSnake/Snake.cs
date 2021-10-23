using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Snake : Coords
    {
        public int length = 0;
        public Snake (int x, int y)
        {
            posX = x;
            posY = y;
        }

    }
}

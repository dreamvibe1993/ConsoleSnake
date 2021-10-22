using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleSnake.Delegates;

namespace ConsoleSnake
{
    class StepTimer
    {
        Timer timer = null;

        private int __interval = 2500;
        private int __delay = 0;

        private ConsoleKey keyPressedFirstTime;

        public StepTimer(int interval, int delay)
        {
            __interval = interval;
            __delay = delay;
        }
        public void RepeatAction(MovingSnakeActionDelegate action, Snake snake, ConsoleKey key)
        {
            if (key == keyPressedFirstTime) return;

            if (timer != null)
            {
                timer.Dispose();
            }

            keyPressedFirstTime = key;

            timer = new Timer((fuckoff) =>
            {
                action(snake);
            },
            null,
            __delay,
            __interval
                );
        }
        public void RepeatAction()
        {
            if (timer != null)
            {
                timer.Dispose();
            }

            timer = new Timer((fuckoff) =>
            {
                FruitActions.DrawFruit();
            },
            null,
            __delay,
            __interval
                );
        }
    }
}

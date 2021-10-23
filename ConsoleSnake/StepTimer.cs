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
        public Timer timer = null;

        private int interval = 2500;
        private int delay = 0;

        private ConsoleKey keyPressedFirstTime;

        public StepTimer(int interval, int delay)
        {
            this.interval = interval;
            this.delay = delay;
        }
        public void RepeatAction(MovingSnakeActionDelegate action, Snake snake, ConsoleKey key)
        {
            if (key == keyPressedFirstTime) return;

            if (timer != null)
            {
                timer.Dispose();
            }

            keyPressedFirstTime = key;

            timer = TimerActions.SetNewTimer((fuckoff) =>
            {
                action(snake);
            }, null, delay, interval);

        }
        public void RepeatAction()
        {
            timer = TimerActions.SetNewTimer((fuckoff) =>
            {
                FruitActions fruitActions = new FruitActions();
                fruitActions.DrawFruit();
            }, null, delay, interval);

        }
    }
}

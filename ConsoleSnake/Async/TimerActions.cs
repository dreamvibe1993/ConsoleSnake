using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleSnake.Delegates;

namespace ConsoleSnake
{
    public class TimerActions
    {
        public Timer Timer = null;

        private int interval = 2500;
        private int delay = 0;

        private ConsoleKey keyPressedFirstTime;

        public TimerActions(int interval, int delay)
        {
            this.interval = interval;
            this.delay = delay;
        }
        public void RepeatSnakeAction(MovingSnakeActionDelegate action, Snake snake, ConsoleKey key)
        {
            if (key == keyPressedFirstTime) return;
            if (snake.Length > 0 && key == ConsoleKey.W && keyPressedFirstTime == ConsoleKey.S) return;
            if (snake.Length > 0 && key == ConsoleKey.S && keyPressedFirstTime == ConsoleKey.W) return;
            if (snake.Length > 0 && key == ConsoleKey.A && keyPressedFirstTime == ConsoleKey.D) return;
            if (snake.Length > 0 && key == ConsoleKey.D && keyPressedFirstTime == ConsoleKey.A) return;


            if (Timer != null)
            {
                Timer.Dispose();
            }

            keyPressedFirstTime = key;

            Timer = SetNewTimer((fuckoff) =>
            {
                action(snake);
            }, null, delay, interval);

        }
        public void RepeatFruitCreationAction()
        {
            Timer = SetNewTimer((fuckoff) =>
            {
                FruitActions fruitActions = new FruitActions();
                fruitActions.DrawFruit();
            }, null, delay, interval);

        }

        public void DisposeTimer()
        {
            Timer.Dispose();
        }

        public static Timer SetNewTimer(TimerCallback timerCallback, object state, int delay, int interval)
        {
            return new Timer(timerCallback, state, delay, interval);
        }
    }
}

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

        private ConsoleKey KeyPressedFirstTime;

        public TimerActions(int interval, int delay)
        {
            this.interval = interval;
            this.delay = delay;
        }
        public void RepeatSnakeAction(MovingSnakeActionDelegate MoveSnake, ConsoleKey Key)
        {
            if (Key == KeyPressedFirstTime) return;

            if (Snake.Length > 0 && Key == ConsoleKey.W && KeyPressedFirstTime == ConsoleKey.S) return;
            if (Snake.Length > 0 && Key == ConsoleKey.S && KeyPressedFirstTime == ConsoleKey.W) return;
            if (Snake.Length > 0 && Key == ConsoleKey.A && KeyPressedFirstTime == ConsoleKey.D) return;
            if (Snake.Length > 0 && Key == ConsoleKey.D && KeyPressedFirstTime == ConsoleKey.A) return;

            KeyPressedFirstTime = Key;
            if (Timer != null)
            {
                Timer.Dispose();
            }


            Timer = SetNewTimer((fuckoff) =>
            {
                MoveSnake();
            }, null, 1, interval);

        }
        public void RepeatFruitCreationAction()
        {
            Timer = SetNewTimer((fuckoff) =>
            {
                FruitActions FruitActions = new FruitActions();
                FruitActions.DrawFruit();
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

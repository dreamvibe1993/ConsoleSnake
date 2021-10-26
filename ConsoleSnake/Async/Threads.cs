using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    static class Threads
    {
        static List<Timer> Timers = new List<Timer>();
        public static void AddToTimersCollection(params Timer[] timers)
        {
            foreach (Timer timer in timers)
            {
                Timers.Add(timer);
            }
        }

        public static void DropAllTimers()
        {
            Timers.ForEach(timer => timer.Dispose());
        }
    }
}

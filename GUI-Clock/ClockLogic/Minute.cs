using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace ClockLogic
{
    class Minute : IMinute
    {
        Timer t = new Timer();
       
        /// <summary>
        /// Current Minute, restricted to correct timeformat.
        /// </summary>
        public int MinuteValue
        {
            get { return MinuteValue; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException();
                }
                MinuteValue = value;
            }
        }

        /// <summary>
        /// Adds time, parameter is bool: start or stop.
        /// </summary>
        public void Tick()
        {
            MinuteValue += 1;
        }
    }
}

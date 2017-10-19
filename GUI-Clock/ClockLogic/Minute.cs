using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace ClockLogic //TEstar
{
    public class Minute : IMinute
    {
        Timer t = new Timer();

        private int _MinuteValue;
        /// <summary>
        /// Current Minute, restricted to correct timeformat.
        /// </summary>
        public int MinuteValue
        {
            get { return _MinuteValue; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _MinuteValue = value;
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

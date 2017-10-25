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
        public event OnTick OnTick;

        private int _minutevalue;

        /// <summary>
        /// Controls _minutevalue, restricted to correct timeformat.
        /// </summary>
        public int MinuteValue
        {
            get { return _minutevalue; }
            set
            {
                if (value < -1 || value > 60)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _minutevalue = value;
            }
        }

        /// <summary>
        /// Adds time, parameter is bool: start or stop.
        /// </summary>
        public void Tick()
        {
            MinuteValue += 1;
            OnTick();
        }
    }
}

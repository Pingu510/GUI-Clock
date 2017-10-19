using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClockLogic
{
    class Hour : IHour
    {
        //private static Timer timer;

        /// <summary>
        /// Current Hour, restricted to correct timeformat
        /// </summary>
        private int _HourValue;
        public int HourValue
        {
            get { return _HourValue; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _HourValue = value;
            }
        }

        /// <summary>
        /// Adds time, parameter is bool: start or stop.
        /// </summary>
        /// 
        public void Tick()
        {
            HourValue += 1;
        }
    }
}


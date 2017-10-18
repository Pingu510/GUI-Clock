using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    class Hour : IHour
    {
        /// <summary>
        /// Current Hour, restricted to correct timeformat
        /// </summary>
        public int HourValue
        {
            get { return HourValue; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    throw new ArgumentOutOfRangeException();
                }
                HourValue = value;
            }
        }

        /// <summary>
        /// Adds time, parameter is bool: start or stop.
        /// </summary>
        public void Tick(bool runstate)
        {

        }
    }
}


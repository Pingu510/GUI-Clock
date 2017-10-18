using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    class Alarm : IAlarm
    {
        private int _hour { get; set; }
        private int _minute { get; set; }

        /// <summary>
        /// Checks if sent in values are equal to set values returns bool 
        /// </summary>
        public bool CheckAlarm(int hour, int minute)
        {
            if (_hour == hour && _minute == minute)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets alarm if in correct timeformat returns true, othervise false 
        /// </summary>
        public bool SetAlarm(int hour, int minute)
        {
            if ((hour >= 0 && hour < 24) && (minute >= 0 && minute < 60))
            {
                _hour = hour;
                _minute = minute;
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    class Alarm : IAlarm
    {
        private int _hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _hour = value;
            }
        }

        private int _minute {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _minute = value;
            }
        }

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
        /// Sets alarm, values are restricted to correct timeformat
        /// </summary>
        public void SetAlarm(int hour, int minute)
        {
            _hour = hour;
            _minute = minute; 
        }
    }
}

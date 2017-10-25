using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    public class Alarm : IAlarm
    {
        private bool _isactive { get; set; }
        private int _alarmhour;
        private int _alarmminute;

        /// <summary>
        /// Controls _alarmhour, restricted to correct timeformat.
        /// </summary>
        private int Alarmhour
        {
            get { return _alarmhour; }
            set 
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _alarmhour = value;
            }
        }

        /// <summary>
        /// Controls _alarmminute, restricted to correct timeformat.
        /// </summary>
        public int Alarmminute
        {
            get { return _alarmminute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _alarmminute = value;
            }
        }

        /// <summary>
        /// Sets the alarm to active or inactive.
        /// </summary>
        public void SetToActive(bool value)
        {
            _isactive = value;
        }

        /// <summary>
        /// Checks if sent in values are equal to set values returns bool 
        /// </summary>
        public bool CheckAlarm(int hour, int minute)
        {
            if (_isactive && this._alarmhour == hour && this._alarmminute == minute)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets alarm, values are restricted to correct timeformat, automaticly sets the alarm to active
        /// </summary>
        public void SetAlarm(int hour, int minute)
        {
            _alarmhour = hour;
            _alarmminute = minute;
            SetToActive(true);
        }
    }
}

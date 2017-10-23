using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    public class Alarm : IAlarm
    {
        private int _alarmHour;
        public int alarmHour
        {
            get { return _alarmHour; }
            set 
            {
                _alarmHour = value;
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException();
                }
                
                _alarmHour = value;
            }
        }

        private int _alarmMinute;
        public int alarmMinute

        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _alarmMinute = value;
            }
        }

        /// <summary>
        /// Checks if sent in values are equal to set values returns bool 
        /// </summary>
        public bool CheckAlarm(int hour, int minute)
        {
            if (this._alarmHour == hour && this._alarmMinute == minute)
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
            _alarmHour = hour;
            _alarmMinute = minute; 
        }
    }
}

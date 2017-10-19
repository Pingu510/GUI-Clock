using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClockLogic

{    class Clock : IClock
    {
        private Hour _currentHour = new Hour();
        private Minute _currentMinute = new Minute();
        private Alarm _alarm1 = new Alarm();
        private Alarm _alarm2 = new Alarm();

        /// <summary>
        /// Returns current hour.
        /// </summary>
        /// <returns></returns>
        public int GetHours()
        {
            return _currentHour.HourValue;
        }

        /// <summary>
        /// Returns current minute.
        /// </summary>
        public int GetMinutes()
        {
            return _currentMinute.MinuteValue;
        }

        /// <summary>
        /// Sets new time from parameters.
        /// </summary>
        public void SetTime(int hour, int minute)
        {
            _currentHour.HourValue = hour;
            _currentMinute.MinuteValue = minute;
        }

        public void IsAlarmTime()
        {
            bool isAlarmOn1 =_alarm1.CheckAlarm(GetHours(), GetMinutes());
            bool isAlarmOn2 =_alarm2.CheckAlarm(GetHours(), GetMinutes());
            if (isAlarmOn1 || isAlarmOn2)
            {

            }
        }

        /// <summary>
        /// Starts the clock.
        /// </summary>
        public void StartClock()
        {
            _currentHour.Tick(true);
            _currentMinute.Tick(true);
        }

        /// <summary>
        /// Stops the clock.
        /// </summary>
        public void StopClock()
        {
            _currentHour.Tick(false);
            _currentMinute.Tick(false);
        }
    }    
}

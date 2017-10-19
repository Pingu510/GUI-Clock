using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_Clock;
using System.Timers;

namespace ClockLogic

{    class Clock : IClock
    {
        Timer timer;
        private Hour _currentHour = new Hour();
        private Minute _currentMinute = new Minute();
        private Alarm _alarm1 = new Alarm();
        private Alarm _alarm2 = new Alarm();

        public Clock()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_currentMinute.MinuteValue == 59)
            {
                if (_currentHour.HourValue == 23)
                    _currentHour.HourValue = 0;
                else
                    _currentHour.Tick();
            }
            else
            {
                _currentMinute.Tick();
            }
            
        }

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
            timer.Start();
        }

        /// <summary>
        /// Stops the clock.
        /// </summary>
        public void StopClock()
        {
            timer.Stop();
        }
    }    
}

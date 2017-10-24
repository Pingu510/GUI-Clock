using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClockLogic

{
    public delegate void OnTick();
    public class Clock : IClock
    {
        public Hour Hour;
        public Minute Minute;

        private Timer _timer;

        /// <summary>
        /// Constructor that creates needed objects: hour, minute, timer etc.
        /// </summary>
        public Clock()
        {
            Hour = new Hour();
            Minute = new Minute();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += Timer_Elapsed;
        }

        /// <summary>
        /// Controls clock logic such as definition of hour and minute.
        /// </summary>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Minute.MinuteValue == 59)
            {
                Minute.MinuteValue = -1;
                if (Hour.HourValue == 23)
                {
                    Hour.HourValue = 0;
                }
                else
                    Hour.Tick();
            }
            Minute.Tick();
        }

        /// <summary>
        /// Returns current hour.
        /// </summary>
        /// <returns></returns>
        public int GetHours()
        {
            return Hour.HourValue;
        }

        /// <summary>
        /// Returns current minute.
        /// </summary>
        public int GetMinutes()
        {
            return Minute.MinuteValue;
        }

        /// <summary>
        /// Sets new time from parameters.
        /// </summary>
        public void SetTime(int setnewhour, int setnewminute)
        {
            Hour.HourValue = setnewhour;
            Minute.MinuteValue = setnewminute;
        }

        /// <summary>
        /// Starts the clock.
        /// </summary>
        public void StartClock()
        {
            _timer.Start();
        }

        /// <summary>
        /// Stops the clock.
        /// </summary>
        public void StopClock()
        {
            _timer.Stop();
        }
    }
}

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
        Timer timer;
        private Hour _hour;
        private Minute _minute;

        public Hour Hour { get => _hour; set => _hour = value; }
        public Minute Minute { get => _minute; set => _minute = value; }

        public Clock()
        {
            Hour = new Hour();
            Minute = new Minute();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Minute.MinuteValue == 59)
            {
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
        public void SetTime(int hour, int minute)
        {
            Hour.HourValue = hour;
            Minute.MinuteValue = minute;
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

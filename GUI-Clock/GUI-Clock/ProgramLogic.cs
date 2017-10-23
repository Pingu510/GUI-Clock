using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClockLogic;
// test
namespace GUI_Clock
{
    public class ProgramLogic
    {
        public Clock clock = new Clock();
        public Alarm _alarm1 = new Alarm();
        public Alarm _alarm2 = new Alarm();

        public ProgramLogic()
        {
            //test
            //Thread ThreadAlarmTime = new Thread(new ThreadStart(TimeForSetOffAlarm));
            //ThreadAlarmTime.Start();
        }


        
        /// <summary>
        /// Creates a correct format string for windows forms clock text.
        /// </summary>
        public string CreateTimeString()
        {
            string currenttime;
            string strhours = clock.GetHours().ToString();
            string strminutes = clock.GetMinutes().ToString();

            if (strhours.Length < 2)
            {
                strhours = "0" + strhours;
            }

            if(clock.GetMinutes().ToString().Length < 2)
            {
                strminutes = "0" + strminutes;
            }

            currenttime = strhours + ":" + strminutes;
            return currenttime;
        }

        /// <summary>
        /// Converts from string to clocktime int
        /// </summary>
        /// <returns></returns>
        public int CreateTimeIntiger(string time)
        {
            try
            {
                return int.Parse(time);
            }
            catch (Exception)
            {
                throw;
            }
        }


            public bool TimeForSetOffAlarm()
        {
            if (_alarm1.CheckAlarm(clock.GetHours(), clock.GetMinutes()) || _alarm2.CheckAlarm(clock.GetHours(), clock.GetMinutes()))
                return true;
            return false;            
        }
    }
}

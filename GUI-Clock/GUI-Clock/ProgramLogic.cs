using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClockLogic;

namespace GUI_Clock
{
    public class ProgramLogic
    {
        public Clock clock = new Clock();
        private Alarm _alarm1 = new Alarm();
        private Alarm _alarm2 = new Alarm();

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

        public bool TimeForSetOffAlarm()
        {
            if (_alarm1.CheckAlarm(clock.GetHours(), clock.GetMinutes()) || _alarm2.CheckAlarm(clock.GetHours(), clock.GetMinutes()))
                return true;
            return false;            
        }
    }
}

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
        public Alarm Alarm1 = new Alarm();
        public Alarm Alarm2 = new Alarm();
        
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
    }
}

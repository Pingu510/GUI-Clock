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
            
            Thread ThreadAlarmTime = new Thread(new ThreadStart(TimeForSetOffAlarm));
            ThreadAlarmTime.Start();
        }

        public void TickingClock()
        {
            clock.ClockFunction();
        }

        public bool TimeForSetOffAlarm()
        {
            if (_alarm1.CheckAlarm(clock.GetHours(), clock.GetMinutes()) || _alarm2.CheckAlarm(clock.GetHours(), clock.GetMinutes()))
                return true;
            return false;            
        }
    }
}

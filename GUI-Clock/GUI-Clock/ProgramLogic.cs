using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClockLogic;

namespace GUI_Clock
{
    class ProgramLogic
    {
        private Clock clock = new Clock();
        private Alarm _alarm1 = new Alarm();
        private Alarm _alarm2 = new Alarm();

        public ProgramLogic()
        {
            Thread ThreadTime = new Thread(new ThreadStart(TickingClock));
            ThreadTime.Start();
            Thread AlarmTime = new Thread(new ThreadStart(TimeForSetOffAlarm));
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

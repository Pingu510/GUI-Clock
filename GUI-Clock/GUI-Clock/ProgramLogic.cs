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

        public Alarm Alarm2 { get => _alarm2; set => _alarm2 = value; }
        public Alarm Alarm1 { get => _alarm1; set => _alarm1 = value; }

        public ProgramLogic()
        {

            //Thread ThreadAlarmTime = new Thread(new ThreadStart(TimeForSetOffAlarm));
            //ThreadAlarmTime.Start();

            clock.Minute.OnTick += Minute_OnTick;
        }

        private void Minute_OnTick()
        {
            
        }

        public void TickingClock()
        {
            //clock.Clock();
        }

        public bool TimeForSetOffAlarm()
        {
            if (Alarm1.CheckAlarm(clock.GetHours(), clock.GetMinutes()) || Alarm2.CheckAlarm(clock.GetHours(), clock.GetMinutes()))
                return true;
            return false;            
        }

        public void StartClock()
        {
            clock.StartClock();
        }
    }
}

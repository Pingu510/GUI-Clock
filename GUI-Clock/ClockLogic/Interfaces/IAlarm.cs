using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    interface IAlarm
    {
        bool CheckAlarm();
        void SetAlarm(int hour, int minute);
    }
}

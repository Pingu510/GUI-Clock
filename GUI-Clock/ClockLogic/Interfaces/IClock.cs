using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    interface IClock
    {
        int GetHours();
        int GetMinutes();
        void SetTime(int hour, int minute);
        void StartClock();
        void StopClock();
    }
}

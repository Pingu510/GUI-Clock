using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    interface IMinute
    {
        int MinuteValue { get; set; }

        void Tick();
    }
}

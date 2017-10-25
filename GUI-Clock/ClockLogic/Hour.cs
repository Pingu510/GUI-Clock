using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClockLogic
{
  
    public class Hour : IHour
    {
        private int _hourvalue;

        /// <summary>
        /// Controls _hourvalue, restricted to correct timeformat.
        /// </summary>        
        public int HourValue
        {
            get { return _hourvalue; }
            set
            {
                if (value < 0 || value > 24)
                {
                    try
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        
                    }
                }
               
                _hourvalue = value;
            }
        }

        /// <summary>
        /// Adds time, parameter is bool: start or stop.
        /// </summary>
        /// 
        public void Tick()
        {
            HourValue += 1;          
        }
    }
}


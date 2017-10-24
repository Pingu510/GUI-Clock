﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClockLogic
{
  
    public class Hour : IHour
    {
        private int _HourValue;

        /// <summary>
        /// Current Hour, restricted to correct timeformat
        /// </summary>        
        public int HourValue
        {
            get { return _HourValue; }
            set
            {
                if (value < 0 || value >24)
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
               
                _HourValue = value;
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


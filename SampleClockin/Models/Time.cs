using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleClockin.Models
{
    public class Time
    {
        public int Id { get; set; }

        private DateTime _ClockIn = DateTime.Now;

        public DateTime ClockIn
        {
            get
            {
                return _ClockIn;
            }
            set
            {
                _ClockIn = value;
            }
        }

        public string WorkType { get; set; }
    }

    public class Time1
    {
        public int Id { get; set; }
        private DateTime _ClockOut = DateTime.Now;

        public DateTime ClockOut
        {
            get
            {
                return _ClockOut;
            }
            set
            {
                _ClockOut = value;
            }
        }

    }



    public class TotalTime
    {
        public int Id { get; set; }
        Time TimeData = new Time();
        Time1 Time1Data = new Time1();
        TimeSpan Result;
        
        public TimeSpan RegHour
        {
            get
            {
                //Result = TimeData.ClockIn.Subtract(Time1Data.ClockOut);
                //return Result;

                TimeSpan hours = (TimeData.ClockIn - Time1Data.ClockOut);
                return hours;
            }

            set 
           {
               Result = value;
           }
        }
    }
}
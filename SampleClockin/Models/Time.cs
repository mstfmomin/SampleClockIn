using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleClockin.Models
{
    public class Time
    {
        public int ID { get; set; }

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
        public int ID { get; set; }
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

        public string WorkType { get; set; }
    }


    public class TotalTime
    {
        public int ID { get; set; }
        public TimeSpan TotalHours { get; set; }
    }

}
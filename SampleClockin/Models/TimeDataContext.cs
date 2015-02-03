using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleClockin.Models
{
    public class TimeDataContext : DbContext
    {
        public DbSet<Time> Times { get; set; }
        public DbSet<Time1> Times1 { get; set; }
        public DbSet<TotalTime> TotalTimes { get; set; }
    }

}
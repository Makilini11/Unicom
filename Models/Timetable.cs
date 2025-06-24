using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    public class Timetable
    {
        public int Id { get; set; }
        public class TimeSlot
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public TimeSpan Duration => End - Start;
        }
    }
}

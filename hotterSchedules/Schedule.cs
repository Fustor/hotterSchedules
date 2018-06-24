using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotterSchedules
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }
        public int NumberOfDays { get; set; }
        public List<WorkDay> DaysWorking { get; set; }

        [Required]
        public virtual Employee Employee { get; set; }
    }

    public struct WorkDay
    {
        public DateTime Day;
        public String ClockIn;
        public String ClockOut;
        public String Position;
    }
}

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
        public int scheduleID { get; set; }
        public int numberOfDays { get; set; }
        public List<WorkDay> daysWorking { get; set; }

        [Required]
        public virtual Employee Employee { get; set; }
    }

    public struct WorkDay
    {
        public DateTime day;
        public String clockIn;
        public String clockOut;
        public String position;
    }
}

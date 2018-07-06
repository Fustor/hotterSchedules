using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotterSchedules
{
    public class Schedule//Actually a single workday
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [ForeignKey("Employee")]
        public String EmployeeId { get; set; }

        
        public DateTime Day { get; set; }
        public String ClockIn { get; set; }
        public String ClockOut { get; set; }
        public String Position { get; set; }

        [Required]
        public virtual Employee Employee { get; set; }

        public Schedule() { }
        public Schedule(DateTime NewDay, String Id,String Start,String End,String Job)
        {
            Day = NewDay;
            EmployeeId = Id;
            ClockIn = Start;
            ClockOut = End;
            Position = Job;
        }
    }

   
}

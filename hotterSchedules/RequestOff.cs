using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotterSchedules
{
    public class RequestOff
    {
        public RequestOff(String Id, DateTime Request)
        {
            EmployeeId = Id;
            DayOff = Request;
        }
        public RequestOff() { }

        [ForeignKey("Employee")]
        public String EmployeeId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public DateTime DayOff { get; set; }

        [Required]
        public Employee Employee { get; set; }
    }
}

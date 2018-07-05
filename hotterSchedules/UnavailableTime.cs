using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotterSchedules
{
    public class UnavailableTime
    {
        public UnavailableTime(String Id, DateTime Day)
        {
            EmployeeId = Id;
            NotAvailable = Day;
        }
        public UnavailableTime() { }

        [ForeignKey("Employee")]
        [Key]
        public String EmployeeId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public DateTime NotAvailable { get; set; }

        [Required]
        public Employee Employee { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotterSchedules
{
    public class Job
    {
        public Job(String Id, String Title)
        {
            EmployeeId = Id;
            JobName = Title;
            //number = num;
        }
        public Job() { }

        [ForeignKey("Employee")]
        public String EmployeeId { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        /*
        [Key]
        public int number { get; set; }
        */
        public String JobName { get; set; }

        [Required]
        public Employee Employee { get; set; }
    }
}

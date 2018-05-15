using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotterSchedules
{
    public class Employee
    {
        public Employee(string employeeName, String id)
        {
            name = employeeName;
            EmployeeID = id;
            

        }

        public Employee() { }
        [Key]
        public String EmployeeID { get; set; }

        
        public String name { get; set; }
        public List<String> Jobs { get; set; }
        public Schedule EmployeeSchedule { get; set; }
        public List<String> UnavailableTimes { get; set; }
        public List<String> RequestsOff { get; set; }

        //[Required]
         //public Restaurant Restaurant { get; set; }
    }
}

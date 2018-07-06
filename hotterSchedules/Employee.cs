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
        public Employee(string employeeName, String id,String RestaurantID)
        {
            name = employeeName;
            EmployeeID = id;
            restaurantID = RestaurantID;
            
        }

        public Employee() { }
        [Key]
        public String EmployeeID { get; set; }

        [ForeignKey("Restaurant")]
        public String restaurantID { get; set; }
        
        public String name { get; set; }
       
       
        

        [Required]
        public Restaurant Restaurant { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hotterSchedules
{
    public class Restaurant
    {
        public Restaurant(String id,string restName)
        {
            restaurantID = id;
            name = restName;
            EmployeeList = new List<Employee>();
        }
        public Restaurant()
        {

        }
        [Key]
        public String restaurantID { get; set; }

        public String name { get; set; }
        public virtual List<Employee> EmployeeList { get; set; }
        public virtual List<Schedule> CurrentSchedules { get; set; }
        
    }
}

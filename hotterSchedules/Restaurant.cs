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
            EmployeeIdList = new List<String>();
            EmployeeIdString = "";
        }
        public Restaurant()
        {

        }
        [Key]
        public String restaurantID { get; set; }

        public String name { get; set; }

        public String EmployeeIdString { get; set; }

        public List<String> EmployeeIdList { get; set; }
       
        public void AddEmployee(String newID)
        {
            EmployeeIdString = String.Concat(String.Concat(EmployeeIdString, ","), newID);
            EmployeeIdList = EmployeeIdString.Split(',').ToList();
        }
        public virtual List<Schedule> CurrentSchedules { get; set; }
        
    }
}

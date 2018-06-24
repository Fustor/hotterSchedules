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
            
        }
        public Restaurant()
        {

        }
        
        [Key]
        public String restaurantID { get; set; }

        public String name { get; set;}
        
    }
}

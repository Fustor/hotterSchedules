using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace hotterSchedules
{
    public class MyContext: DbContext
    {
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

    }
}

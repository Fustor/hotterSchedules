using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hotterSchedules
{
    /// <summary>
    /// Interaction logic for EmployeeViewer.xaml
    /// </summary>
    public partial class EmployeeViewer : Window
    {
        String RestaurantID;
        public EmployeeViewer(String RestID)
        {
            RestaurantID = RestID;
            
            InitializeComponent();
            PopulateEmployees();

        }
        public void PopulateEmployees()
        {
            var db = new MyContext();
            var Employees = (from e in db.Employees where e.restaurantID == RestaurantID select e).ToList();
            EmployeeDataGrid.ItemsSource = Employees;
        }

        
    }
}

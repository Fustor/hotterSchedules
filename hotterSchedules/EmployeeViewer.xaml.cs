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
        MyContext db = new MyContext();
        public EmployeeViewer(String RestID)
        {
            RestaurantID = RestID;
            
            InitializeComponent();
            PopulateEmployees();

        }
        public void PopulateEmployees()//add employees to datagrid and combobox, combobox only displays their names
        {
            
            var Employees = (from e in db.Employees where e.restaurantID == RestaurantID select e).ToList();
            EmployeeDataGrid.ItemsSource = Employees;
            EmployeeComboBox.ItemsSource = Employees;
            EmployeeComboBox.DisplayMemberPath = "name";
            
        }

        private void ModifyEmployeeButton_Click(object sender, RoutedEventArgs e)//takes combobox selection, casts it to employee object and passes it to the new window
        {
            Employee SelectedEmployee = (Employee) EmployeeComboBox.SelectedItem;
            
            ModifyEmployeeWindow ModifyEmployee = new ModifyEmployeeWindow(SelectedEmployee,db);
            ModifyEmployee.Show();
            
        }

        private void ViewScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            Employee SelectedEmployee = (Employee)EmployeeComboBox.SelectedItem;
            ViewEmployeeSchedule ViewSchedule = new ViewEmployeeSchedule(SelectedEmployee, db);
            ViewSchedule.Show();
        }
    }
}

using System;
using System.Collections.Generic;
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
    /// Interaction logic for ModifyEmployeeWindow.xaml
    /// </summary>
    public partial class ModifyEmployeeWindow : Window
    {
        public ModifyEmployeeWindow(Employee CurrentEmployee, MyContext db)
        {//TODO: store job relations in new table
            var SelectedEmployee = db.Employees.SingleOrDefault(i => i.EmployeeID == CurrentEmployee.EmployeeID);
            //SelectedEmployee.name = "Dave";//this sucessfully changes name
           // db.SaveChanges();
            InitializeComponent();
            NameLabel.Content = CurrentEmployee.name;
            IdLabel.Content = CurrentEmployee.EmployeeID;
        }
    }
}

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
        
        public EmployeeViewer()
        {
            
            InitializeComponent();
            populateEmployees();

        }
        public void populateEmployees()
        {
            var db = new MyContext();
            EmployeeDataGrid.ItemsSource = db.Employees.ToList();
        }

        
    }
}

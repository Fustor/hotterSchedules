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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        String Username, RestaurantID;

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeViewer EmployeeViewWindow = new EmployeeViewer(RestaurantID);
            EmployeeViewWindow.Show();
        }

        public Window1(String name,String restaurantID)
        {
            Username = name;
            RestaurantID = restaurantID;
            
            InitializeComponent();
           // UserLabel.Content = Username;
        }
    }
}

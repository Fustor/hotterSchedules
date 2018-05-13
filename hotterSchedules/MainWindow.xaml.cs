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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hotterSchedules
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String username;
        
        public MainWindow()
        {
            // var context = new MyContext();
            /*  ******fiddling with creating and saving data********
            List<string> Jobs = new List<string>();
            Jobs.Add("host");
            Jobs.Add("togo");
            Employee first = new Employee("Dave", Jobs,123);
            Restaurant uno = new Restaurant(222, "chilis");
            uno.EmployeeList.Add(first);
            context.Restaurants.Add(uno);
            context.Employees.Add(first);
            context.SaveChanges();
            */


            /*  *******Checking if values were saved***** Saved multiple times**********
            var rants = (from s in context.Restaurants orderby s.name select s).ToList<Restaurant>();
            foreach(var a in rants)
            {
                string nam = a.name;
                MessageBox.Show(nam);
            }
            */
            
            var context = new MyContext();
           
            InitializeComponent();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            var context = new MyContext();

            String RestaurantName = RestaurantTextBox.Text;
            var SelectedRestaurant = (from s in context.Restaurants where s.name == RestaurantName select s );//grabs entities where their .name is equal to RestaurantName
            Restaurant curRest = SelectedRestaurant.Single();//creates a Restaurant object curRest from a Single entity selected above, error is more than one is selected
            username = usernameTextBox.Text;
            Employee emp = new Employee(username, 2223);
            MessageBox.Show(username + curRest.name);
            Window1 Window = new Window1();
            Window.Show();
            this.Close();
        }

        private void CreateNewButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

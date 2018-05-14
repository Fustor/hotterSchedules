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
        
        
        public MainWindow()
        {
            /* var context = new MyContext();
             ******fiddling with creating and saving data********
            List<string> Jobs = new List<string>();
            Jobs.Add("host");
            Jobs.Add("togo");
            Employee first = new Employee("Dave",123);
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
            /*
             * TODO:
             * 1. DONE: delete all garbage currently int database
             * 2. create new restaurant if it doesnt already exist
             * 3. employee creation/login
             */
            var context = new MyContext();

            String RestaurantName = RestaurantTextBox.Text;
            String username = usernameTextBox.Text;

            var SelectedRestaurant = (from s in context.Restaurants where s.name == RestaurantName select s ).ToList<Restaurant>();//grabs entities where their .name is equal to RestaurantName

            if(SelectedRestaurant.Count() > 0)
            {
                Restaurant curRest = SelectedRestaurant[0];//creates a Restaurant object curRest from a Single entity selected above, error is more than one is selected
                MessageBox.Show(username + curRest.name);

                Window1 Window = new Window1();
                Window.Show();
                this.Close();
            }
            if(SelectedRestaurant.Count() > 1)
            {
                //create new window asking for restaurantID, select that restaurant from list of current restaurants

            }
            else
            {
                MessageBox.Show(RestaurantName + " was not found.");
            }
            
            Employee emp = new Employee(username, "2234");
            
            
        }

        private void CreateNewButton_Click(object sender, RoutedEventArgs e)
        {
            /* 
             * open window asking to create new employee or new restaurant
             * close and open corresponding creation window
             * add to db and take back to main window
             */
            NewItemWindow NewItemWin = new NewItemWindow();
            NewItemWin.Show();
        }
    }
}

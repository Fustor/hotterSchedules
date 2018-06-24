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
    /// Interaction logic for NewItemWindow.xaml
    /// </summary>
    public partial class NewItemWindow : Window
    {
        public NewItemWindow()
        {
            InitializeComponent();
            
        }

        private void CancelNewItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubmitNewItemButton_Click(object sender, RoutedEventArgs e)
        {
            String Name = NameTextbox.Text;
            String ID = IDTextbox.Text;
           
            if (NewEmployeeRadioButton.IsChecked == true)
            {
                String RestaurantID = EmployeeRestaurantIDTextbox.Text;
                Employee NewEmployee = new Employee(Name, ID, RestaurantID);
                using (var db = new MyContext())//adds the employee to their restaurants employeeList and creates employee
                {
                   
                    var CurrentRestaurant = db.Restaurants.SingleOrDefault(b => b.restaurantID == RestaurantID);
                    if (CurrentRestaurant != null)
                    {

                        
                        db.Employees.Add(NewEmployee);
                        db.SaveChanges();






                    }
                    
                }
                this.Close();
               

                

                //figure out how to select the restaurant they are added to
            }

            else if(NewRestaurantRadioButton.IsChecked == true)//creates new restaurant with unique id
            {
                using(var db  = new MyContext())
                {
                    var ExistingRestaurant = db.Restaurants.SingleOrDefault(b => b.restaurantID == ID);
                    if(ExistingRestaurant != null)
                    {
                        MessageBox.Show("Restaurant with that ID already exists. Please select a unique ID.");
                    }
                    else
                    {
                        Restaurant NewRestaurant = new Restaurant(ID, Name);
                        db.Restaurants.Add(NewRestaurant);
                        db.SaveChanges();
                        this.Close();
                    }
                    

                }
                
            }
            else
            {
                MessageBox.Show("Please select either option or cancel.");
            }
        }

        private void NewEmployeeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            EmployeeRestaurantIDTextbox.IsEnabled = true;
        }

        private void NewRestaurantRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            EmployeeRestaurantIDTextbox.IsEnabled = false;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
           
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
        

    }
}

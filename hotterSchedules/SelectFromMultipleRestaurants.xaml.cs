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
    /// Interaction logic for SelectFromMultipleRestaurants.xaml
    /// </summary>
    public partial class SelectFromMultipleRestaurants : Window
    {
        String Username, RestaurantID;
        public SelectFromMultipleRestaurants(String username,String RestaurantName)
        {
            Username = username;
            
            InitializeComponent();
            NameLabel.Content = RestaurantName;

            var context = new MyContext();
            var SelectedRestaurant = (from s in context.Restaurants where s.name == RestaurantName select s).ToList<Restaurant>();
            foreach(var Restaurant in SelectedRestaurant)
            {
                IDComboBox.Items.Add(Restaurant.restaurantID);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow newMain = new MainWindow();
            newMain.Show();
            this.Close();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window = new Window1(Username, IDComboBox.Text);
            Window.Show();
            this.Close();
            
        }
    }
}

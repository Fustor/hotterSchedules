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
    /// Interaction logic for AddJobWindow.xaml
    /// </summary>
    public partial class AddJobWindow : Window
    {
        MyContext data;
        Employee CurEmployee;
        public AddJobWindow(Employee CurrentEmployee,MyContext Db )
        {
            data = Db;
            CurEmployee = CurrentEmployee;
            InitializeComponent();
            EmployeeLabel.Content = CurrentEmployee.name;

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Job ThisJob = new Job(CurEmployee.EmployeeID, JobTextBox.Text);
            data.Jobs.Add(ThisJob);
            data.SaveChanges();
            this.Close();
        }
    }
}

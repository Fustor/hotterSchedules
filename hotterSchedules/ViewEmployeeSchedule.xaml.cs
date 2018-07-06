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
/*
 * TODO:
 * 1:Update after adding a new day
 * 2:Account for not selecting a day to add
 * 3:Only see columns for name, job, day, and hours
 * 
 */
namespace hotterSchedules
{
    /// <summary>
    /// Interaction logic for ViewEmployeeSchedule.xaml
    /// </summary>
    public partial class ViewEmployeeSchedule : Window
    {
        MyContext db;
        Employee CurrentEmployee;
        public ViewEmployeeSchedule(Employee CurEmployee, MyContext data)
        {
            CurrentEmployee = CurEmployee;
            db = data;
            var Schedules = (from e in db.Schedules where e.EmployeeId == CurrentEmployee.EmployeeID select e).ToList();
            InitializeComponent();
            EmployeeNameLabel.Content = CurrentEmployee.name;
            ScheduleGrid.ItemsSource = Schedules;
        }

        private void AddToScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            Schedule NewDay = new Schedule(ScheduleCalendar.SelectedDate.Value,CurrentEmployee.EmployeeID,TimeInTextbox.Text,TimeOutTextbox.Text,JobTextbox.Text);
            db.Schedules.Add(NewDay);
            db.SaveChanges();
            
        }
    }
}

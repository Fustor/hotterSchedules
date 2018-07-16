using System;
using System.Data;
using System.Linq;
using System.Windows;
/*
 * TODO:
 * DONE 1:Update after adding a new day
 * DONE 2:Account for not selecting a day to add
 * Deal with this 3:Only see columns for name, job, day, and hours
 * 4. Colors for days working
 * DONE 5. Ability to delete days
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
            var Schedules = (from s in db.Schedules where s.EmployeeId == CurrentEmployee.EmployeeID select s).ToList();
            InitializeComponent();
            EmployeeNameLabel.Content = CurrentEmployee.name;
           
            ScheduleGrid.ItemsSource = Schedules;
            ScheduleCalendar.SelectedDate = DateTime.Today;
            
           // ScheduleGrid.Columns[1].Visibility = Visibility.Collapsed;
            //ScheduleGrid.Columns[7].Visibility = Visibility.Collapsed;
        }

        private void AddToScheduleButton_Click(object sender, RoutedEventArgs e)
        {
           
                Schedule NewDay = new Schedule(ScheduleCalendar.SelectedDate.Value, CurrentEmployee.EmployeeID, TimeInTextbox.Text, TimeOutTextbox.Text, JobTextbox.Text);
                db.Schedules.Add(NewDay);
                db.SaveChanges();
                var Schedules = (from s in db.Schedules where s.EmployeeId == CurrentEmployee.EmployeeID select s).ToList();
                ScheduleGrid.ItemsSource = Schedules;
           
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            Schedule SelectedSchedule = (Schedule)ScheduleGrid.SelectedItem;
            db.Schedules.Attach(SelectedSchedule);
            db.Schedules.Remove(SelectedSchedule);
            db.SaveChanges();
            var Schedules = (from s in db.Schedules where s.EmployeeId == CurrentEmployee.EmployeeID select s).ToList();
            ScheduleGrid.ItemsSource = Schedules;
            
        }
    }
}

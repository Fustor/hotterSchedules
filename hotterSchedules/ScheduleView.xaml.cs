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
    /// Interaction logic for ScheduleView.xaml
    /// </summary>
    public partial class ScheduleView : Window
    {
        public ScheduleView()
        {//TODO: Find how to show the schedule on a datagrid
            //NEW IDEAS: desktop app for managers only, modify schedule by job type, sends email to employees upon publishing
            InitializeComponent();
            List<String> a = new List<String>();
            a.Add("a");
            a.Add("b");
            DataGridTextColumn firstColumn = new DataGridTextColumn();
            firstColumn.Header = "Daga";
            ScheduleDataGrid.Columns.Add(firstColumn);
        }
    }
}

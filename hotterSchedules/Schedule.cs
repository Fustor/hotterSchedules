using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotterSchedules
{
    public class Schedule
    {
        int numberOfDays;
        List<WorkDay> daysWorking;


    }

    public struct WorkDay
    {
        DateTime day;
        String clockIn;
        String clockOut;
        String position;
    }
}

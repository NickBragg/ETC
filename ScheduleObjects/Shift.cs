using ScheduleObjects;
using ScheduleObjects.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleObjects
{
    public class Shift
    {
        public List<Employee> Employees { get; set; }
        public ShiftType ShiftType { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public Location ShiftLocation { get; set; }

    }
}

using ScheduleObjects;
using ScheduleObjects.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleObjects
{
    public class Shift
    {
        public Employee Employee { get; set; }
        public ShiftType ShiftType { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}

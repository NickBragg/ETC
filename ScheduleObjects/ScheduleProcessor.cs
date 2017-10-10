using ScheduleObjects.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleObjects
{
    public class ScheduleProcessor
    {

        public void Process()
        {

            //Designate openers/schlep
            //Designate Mids
            //Designate Closers
            //Designate 


            //Initialize Location will need to be done by user in future
            Location northLocation = new Location();
            northLocation.DaysOpen.Add(DayOfWeek.Friday);
            northLocation.DaysOpen.Add(DayOfWeek.Monday);
            northLocation.DaysOpen.Add(DayOfWeek.Saturday);
            northLocation.DaysOpen.Add(DayOfWeek.Sunday);
            northLocation.DaysOpen.Add(DayOfWeek.Thursday);
            northLocation.DaysOpen.Add(DayOfWeek.Tuesday);
            northLocation.DaysOpen.Add(DayOfWeek.Wednesday);


            List<Employee> employeeList = Employee.GetAllActiveEmployees();


            foreach (DayOfWeek day in northLocation.DaysOpen)
            {

                int schlepers = 1;
                int openers = (day.Equals(DayOfWeek.Friday) || day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday)) ? 2 : 1;
                int midsAndClosers = (day.Equals(DayOfWeek.Friday) || day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday)) ? 3 : 2;

                for (int i = 1; i <= schlepers; i++)
                {
                    northLocation.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.SCHLEP,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.SCHLEP, day, x))
                    });
                }

                for (int i = 1; i <= openers; i++)
                {
                    northLocation.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.OPEN,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.OPEN, day, x))
                    });
                }

                //Add three mid
                for (int i = 1; i <= midsAndClosers; i++)
                {
                    northLocation.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.MID,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.MID, day, x))
                    });
                }

                for (int i = 1; i <= midsAndClosers; i++)
                {
                    northLocation.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.CLOSE,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.CLOSE, day, x))
                    });
                }


            }

        }

    }
}

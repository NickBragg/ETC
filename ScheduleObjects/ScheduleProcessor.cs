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

        public void Process(Location location)
        {
            


            
            

            List<Employee> employeeList = Employee.GetAllActiveEmployees();


            foreach (DayOfWeek day in location.DaysOpen)
            {

                int schlepers = 1;
                int openers = (day.Equals(DayOfWeek.Friday) || day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday)) ? 2 : 1;
                int midsAndClosers = (day.Equals(DayOfWeek.Friday) || day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday)) ? 3 : 2;

                for (int i = 1; i <= schlepers; i++)
                {
                    location.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.SCHLEP,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.SCHLEP, day, x, location))
                    });
                }

                for (int i = 1; i <= openers; i++)
                {
                    location.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.OPEN,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.OPEN, day, x, location))
                    });
                }

                //Add three mid
                for (int i = 1; i <= midsAndClosers; i++)
                {
                    location.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.MID,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.MID, day, x, location))
                    });
                }

                for (int i = 1; i <= midsAndClosers; i++)
                {
                    location.Shifts.Add(new Shift()
                    {
                        DayOfWeek = day,
                        ShiftType = ShiftType.CLOSE,
                        Employee = employeeList.FirstOrDefault(x => x.IsAvailable(ShiftType.CLOSE, day, x, location))
                    });
                }


            }

        }

    }
}

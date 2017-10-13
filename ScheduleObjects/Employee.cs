using MongoDB.Bson;
using ScheduleObjects.DatabaseFactory;
using ScheduleObjects.Enum;
using System;
using System.Collections.Generic;

namespace ScheduleObjects
{
    public class Employee
    {

        #region Properties
        public ObjectId _id { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool IsActive { get; set; }
        public List<DayOfWeek> DaysNeededOff { get; set; }
        public List<DayOfWeek> DaysPrefferedOff { get; set; }
        public int MaxNumberOfDaysToWork { get; set; }
        public int MaxNumberOfHoursToWork { get; set; }
        public int CurrentNumberOfShifts { get; set; }
        #endregion

        #region Public Methods

        public static bool CreateEmployee(Employee employee)
        {
            //Store New Employee info

            MongoConnector.InsertEmployee(employee);

            return false;
        }

        public static Employee GetEmployee(int employeeID)
        {
            Employee employee = new Employee();
            return employee;
        }

        public static List<Employee> GetAllActiveEmployees()
        {
            return MongoConnector.GetEmployees();
        }

        public static bool UpdateEmployeeInfo(Employee info)
        {
            return false;
        }

        public bool IsAvailable(ShiftType shiftType, DayOfWeek dayOfWeek, Employee employee, Location location)
        {
            if (employee.CurrentNumberOfShifts < employee.MaxNumberOfDaysToWork
                && !employee.DaysNeededOff.Contains(dayOfWeek)
                && employee.ShiftTypeIsValidForDay(shiftType, dayOfWeek, employee, location))
            {
                    
            }


            return false;
        }
        #endregion

         
        #region Private Methods

        private bool ShiftTypeIsValidForDay(ShiftType shiftType, DayOfWeek dayOfWeek, Employee employee, Location location)
        {
            if(location.EmployeeTypesAccepted.Contains(employee.EmployeeType))
            {

            }


            return false;
        }

        #endregion

    }
}

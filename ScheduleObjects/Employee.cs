using ScheduleObjects.DatabaseFactory;
using ScheduleObjects.Enum;
using System;
using System.Collections.Generic;

namespace ScheduleObjects
{
    public class Employee
    {

        #region Properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool IsActive { get; set; }
        public List<DateTime> DaysNeededOff { get; set; }
        public int NumberOfDaysToWork { get; set; }
        #endregion

        #region Public Methods

        public bool CreateEmployee(Employee employee)
        {
            //Store New Employee info

            MongoConnector.InsertEmployee(employee);

            return false;
        }

        public Employee GetEmployee(int employeeID)
        {
            Employee employee = new Employee();
            return employee;
        }

        public bool UpdateEmployeeInfo(Employee info)
        {
            return false;
        }

        #endregion


    }
}

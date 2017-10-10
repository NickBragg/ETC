using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScheduleObjects;
using ScheduleObjects.DatabaseFactory;
using System.Collections.Generic;
using ScheduleObjects.Enum;

namespace ScheduleTest
{
    [TestClass]
    public class ScheduleTest
    {
        [TestMethod]
        public void Process()
        {
            ScheduleProcessor processor = new ScheduleProcessor();
            processor.Process();
        }

        [TestMethod]
        public void GenerateEmployees()
        {

            List<DayOfWeek> daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);

            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 0,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Toney",
                LastName = "Little",
                IsActive = true,
                NumberOfDaysToWork = 5
            });

            daysNeededOff.Add(DayOfWeek.Sunday);
            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 1,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.RED,
                FirstName = "Nick",
                LastName = "Bragg",
                IsActive = true,
                NumberOfDaysToWork = 3
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Wednesday);
            daysNeededOff.Add(DayOfWeek.Tuesday);
            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 2,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.YELLOW,
                FirstName = "Seth",
                LastName = "Carroll",
                IsActive = true,
                NumberOfDaysToWork = 6
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Thursday);
            daysNeededOff.Add(DayOfWeek.Tuesday);
            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 3,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Jean",
                LastName = "Rhodes",
                IsActive = true,
                NumberOfDaysToWork = 6
            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Sunday);
            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 4,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.RED,
                FirstName = "Test1",
                LastName = "Test1",
                IsActive = true,
                NumberOfDaysToWork = 3
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Sunday);
            daysNeededOff.Add(DayOfWeek.Wednesday);
            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 5,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.YELLOW,
                FirstName = "Test2",
                LastName = "Test2",
                IsActive = true,
                NumberOfDaysToWork = 5

            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);
            daysNeededOff.Add(DayOfWeek.Tuesday);
            MongoConnector.InsertEmployee(new Employee()
            {
                EmployeeID = 6,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test3",
                LastName = "Test3",
                IsActive = true,
                NumberOfDaysToWork = 5
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Thursday);
            daysNeededOff.Add(DayOfWeek.Wednesday);
            MongoConnector.InsertEmployee(new Employee()
            {

                EmployeeID = 7,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test4",
                LastName = "Test4",
                IsActive = true,
                NumberOfDaysToWork = 5

            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);
            MongoConnector.InsertEmployee(new Employee()
            {

                EmployeeID = 8,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test5",
                LastName = "Test5",
                IsActive = true,
                NumberOfDaysToWork = 6

            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Saturday);
            MongoConnector.InsertEmployee(new Employee()
            {

                EmployeeID = 9,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.YELLOW,
                FirstName = "Test6",
                LastName = "Test6",
                IsActive = true,
                NumberOfDaysToWork = 6

            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Thursday);
            MongoConnector.InsertEmployee(new Employee()
            {

                EmployeeID = 10,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test7",
                LastName = "Test7",
                IsActive = true,
                NumberOfDaysToWork = 6

            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);
            daysNeededOff.Add(DayOfWeek.Wednesday);
            daysNeededOff.Add(DayOfWeek.Thursday);
            daysNeededOff.Add(DayOfWeek.Saturday);
            MongoConnector.InsertEmployee(new Employee()
            {

                EmployeeID = 11,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.RED,
                FirstName = "Test8",
                LastName = "Test8",
                IsActive = true,
                NumberOfDaysToWork = 3

            });

        }

    }
}

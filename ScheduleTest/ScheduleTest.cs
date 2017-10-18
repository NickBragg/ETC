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
        ScheduleProcessor processor = new ScheduleProcessor();

        [TestMethod]
        public void ProcessNorthLocation()
        {
            

            Location location = new Location();
            location.DaysOpen.Add(DayOfWeek.Friday);
            location.DaysOpen.Add(DayOfWeek.Monday);
            location.DaysOpen.Add(DayOfWeek.Saturday);
            location.DaysOpen.Add(DayOfWeek.Sunday);
            location.DaysOpen.Add(DayOfWeek.Thursday);
            location.DaysOpen.Add(DayOfWeek.Tuesday);
            location.DaysOpen.Add(DayOfWeek.Wednesday);
            location.EmployeeTypesAccepted.Add(EmployeeType.GREEN);
            location.EmployeeTypesAccepted.Add(EmployeeType.YELLOW);
            location.EmployeeTypesAccepted.Add(EmployeeType.RED);

            processor.Process(location);
        }

        [TestMethod]
        public void ProcessSouthLocation()
        {
            ScheduleProcessor processor = new ScheduleProcessor();

            Location location = new Location();
            location.DaysOpen.Add(DayOfWeek.Monday);
            location.DaysOpen.Add(DayOfWeek.Tuesday);
            location.DaysOpen.Add(DayOfWeek.Wednesday);
            location.DaysOpen.Add(DayOfWeek.Thursday);
            location.DaysOpen.Add(DayOfWeek.Friday);
            location.DaysOpen.Add(DayOfWeek.Saturday);
            location.EmployeeTypesAccepted.Add(EmployeeType.GREEN);
            location.EmployeeTypesAccepted.Add(EmployeeType.YELLOW);

            processor.Process(location);
        }

        [TestMethod]
        public void GenerateEmployees()
        {

            List<DayOfWeek> daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);

            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 0,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Toney",
                LastName = "Little",
                IsActive = true,
                MaxNumberOfDaysToWork = 5
            });

            daysNeededOff.Add(DayOfWeek.Sunday);
            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 1,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.RED,
                FirstName = "Nick",
                LastName = "Bragg",
                IsActive = true,
                MaxNumberOfDaysToWork = 3
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Wednesday);
            daysNeededOff.Add(DayOfWeek.Tuesday);
            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 2,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.YELLOW,
                FirstName = "Seth",
                LastName = "Carroll",
                IsActive = true,
                MaxNumberOfDaysToWork = 6
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Thursday);
            daysNeededOff.Add(DayOfWeek.Tuesday);
            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 3,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Jean",
                LastName = "Rhodes",
                IsActive = true,
                MaxNumberOfDaysToWork = 6
            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Sunday);
            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 4,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.RED,
                FirstName = "Test1",
                LastName = "Test1",
                IsActive = true,
                MaxNumberOfDaysToWork = 3
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Sunday);
            daysNeededOff.Add(DayOfWeek.Wednesday);
            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 5,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.YELLOW,
                FirstName = "Test2",
                LastName = "Test2",
                IsActive = true,
                MaxNumberOfDaysToWork = 5

            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);
            daysNeededOff.Add(DayOfWeek.Tuesday);
            MongoConnector.Insert(new Employee()
            {
                EmployeeID = 6,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test3",
                LastName = "Test3",
                IsActive = true,
                MaxNumberOfDaysToWork = 5
            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Thursday);
            daysNeededOff.Add(DayOfWeek.Wednesday);
            MongoConnector.Insert(new Employee()
            {

                EmployeeID = 7,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test4",
                LastName = "Test4",
                IsActive = true,
                MaxNumberOfDaysToWork = 5

            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);
            MongoConnector.Insert(new Employee()
            {

                EmployeeID = 8,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test5",
                LastName = "Test5",
                IsActive = true,
                MaxNumberOfDaysToWork = 6

            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Saturday);
            MongoConnector.Insert(new Employee()
            {

                EmployeeID = 9,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.YELLOW,
                FirstName = "Test6",
                LastName = "Test6",
                IsActive = true,
                MaxNumberOfDaysToWork = 6

            });

            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Thursday);
            MongoConnector.Insert(new Employee()
            {

                EmployeeID = 10,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.GREEN,
                FirstName = "Test7",
                LastName = "Test7",
                IsActive = true,
                MaxNumberOfDaysToWork = 6

            });


            daysNeededOff = new List<DayOfWeek>();
            daysNeededOff.Add(DayOfWeek.Monday);
            daysNeededOff.Add(DayOfWeek.Wednesday);
            daysNeededOff.Add(DayOfWeek.Thursday);
            daysNeededOff.Add(DayOfWeek.Saturday);
            MongoConnector.Insert(new Employee()
            {

                EmployeeID = 11,
                DaysNeededOff = daysNeededOff,
                EmployeeType = EmployeeType.RED,
                FirstName = "Test8",
                LastName = "Test8",
                IsActive = true,
                MaxNumberOfDaysToWork = 3

            });

        }

    }
}

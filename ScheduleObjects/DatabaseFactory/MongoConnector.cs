using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ScheduleObjects.DatabaseFactory
{
    public class MongoConnector
    {
        
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        const string connectionString = "mongodb://localhost:27017";


        public static void Insert(Employee employee)
        {
            try
            {
                _client = new MongoClient(connectionString);
                _database = _client.GetDatabase("ScheduleETC");

                var collection = _database.GetCollection<Employee>("Employee");

                collection.InsertOne(employee);
            }
            catch(Exception ex)
            {
                ErrorLogger.LogError(ex, "MongoConnector", "Insert");
            }
        }
        
        public static Employee GetEmployee(int employeeID)
        {

            Employee employee = new Employee();
            try
            {
                _client = new MongoClient(connectionString);
                _database = _client.GetDatabase("ScheduleETC");
                var filter = Builders<Employee>.Filter.Eq(x => x.EmployeeID, employeeID);
                var collection = _database.GetCollection<Employee>("Employee");
                employee = collection.Find(filter).ToListAsync().Result[0];

            }
            catch(Exception ex)
            {
                ErrorLogger.LogError(ex, "MongoConnector", "GetEmployee");
            }


            return employee;
        }

        public static List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>();
            try
            {
                _client = new MongoClient(connectionString);
                _database = _client.GetDatabase("ScheduleETC");
                var filter = Builders<Employee>.Filter.Eq(x => x.IsActive, true);
                var collection = _database.GetCollection<Employee>("Employee");
                employees = collection.Find(filter).ToListAsync().Result;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex, "MongoConnector", "GetEmployees");
            }


            return employees;
        }


        public static List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();
            try
            {
                _client = new MongoClient(connectionString);
                _database = _client.GetDatabase("ScheduleETC");
                
                var collection = _database.GetCollection<Location>("Location");
                locations = collection.Find(new BsonDocument() { }).ToListAsync().Result;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex, "MongoConnector", "GetLocations");
            }


            return locations;
        }

        public static void Insert(ScheduleError error)
        {
            try
            {
                _client = new MongoClient(connectionString);
                _database = _client.GetDatabase("ScheduleETC");

                var collection = _database.GetCollection<ScheduleError>("Errors");

                collection.InsertOne(error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex, "MongoConnector", "Insert");
            }
        }
    }
}

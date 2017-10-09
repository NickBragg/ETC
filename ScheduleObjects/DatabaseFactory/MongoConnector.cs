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


        public static async void InsertEmployee(Employee employee)
        {
            try
            {
                _client = new MongoClient(connectionString);
                _database = _client.GetDatabase("ScheduleETC");

                var collection = _database.GetCollection<Employee>("Employee");

                await collection.InsertOneAsync(employee);
            }
            catch(Exception ex)
            {
                ErrorLogger.LogError(ex, "MongoConnector", "InsertEmployee");
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


    }
}

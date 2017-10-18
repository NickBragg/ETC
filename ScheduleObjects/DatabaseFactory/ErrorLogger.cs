using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleObjects.DatabaseFactory
{
    public static class ErrorLogger
    {

        public static void LogError(Exception ex, string className, string method )
        {
            ScheduleError scheduleError = new ScheduleError()
            {
                ClassName = className,
                Method = method,
                Exception = ex
            };

            MongoConnector.Insert(scheduleError);
        }
    }

    public class ScheduleError
    {
        public Exception Exception { get; set; }
        public string ClassName { get; set; }
        public string Method { get; set; }
    }
}

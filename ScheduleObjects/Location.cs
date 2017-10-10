using ScheduleObjects.DatabaseFactory;
using ScheduleObjects.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleObjects
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public List<DayOfWeek> DaysOpen { get; set; }
        public List<Shift> Shifts { get; set; }



        public List<Location> GetLocations()
        {
            List<Location> locations = MongoConnector.GetLocations();
            return locations;
        }


    }
}

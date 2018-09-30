using System.Collections.Generic;
using TimeTracker.Models;

namespace TimeTracker.Data
{

    /// Mockdata
    public static class Data
    {
        /// The collection of activities.
        public static List<Activity> Activities { get; set; }

        /// The collection of entries.
        public static List<Entry> Entries { get; set; }

        /// Static constructor used to initialize the data.
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            // Create the collection of activities first
            // so we can reference them when creating the entries collection.
            var activities = new List<Activity>()
            {
                new Activity(Activity.ActivityType.Biking),
                new Activity(Activity.ActivityType.Hiking),
                new Activity(Activity.ActivityType.Kayaking),
                new Activity(Activity.ActivityType.Running),
                new Activity(Activity.ActivityType.Skiing),
                new Activity(Activity.ActivityType.Swimming),
                new Activity(Activity.ActivityType.Walking),
                new Activity(Activity.ActivityType.HeavyLifting, "Heavy Lifting")
            };

            var entries = new List<Entry>()
            {
                new Entry(1, 2018, 7, 8, Activity.ActivityType.Swimming, 10.0),
                new Entry(2, 2018, 7, 9, Activity.ActivityType.Walking, 12.2),
                new Entry(3, 2018, 7, 10, Activity.ActivityType.Running, 123.0),
                new Entry(4, 2018, 7, 12, Activity.ActivityType.Running, 10.0),
                new Entry(5, 2018, 7, 13, Activity.ActivityType.Running, 32.2),
                new Entry(6, 2018, 7, 13, Activity.ActivityType.Running, 13.3),
                new Entry(7, 2018, 7, 14, Activity.ActivityType.Walking, 10.0),
                new Entry(8, 2018, 7, 15, Activity.ActivityType.Walking, 28.6),
                new Entry(9, 2018, 7, 16, Activity.ActivityType.Biking, 12.7)
            };

            Activities = activities;
            Entries = entries;
        }
    }
}
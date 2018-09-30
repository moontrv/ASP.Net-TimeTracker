using System.Collections.Generic;
using System.Linq;
using TimeTracker.Models;

namespace TimeTracker.Data
{
    /// Repository for activities.

    public class ActivitiesRepository
    {
        /// Returns a collection of activities.
        /// <returns>A list of activities.</returns>
        public List<Activity> GetActivities()
        {
            return Data.Activities
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}
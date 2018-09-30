namespace TimeTracker.Models
{
    /// <summary>
    /// Represents a physical activity.
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// The list of activity types.
        /// </summary>
        public enum ActivityType
        {
            Biking = 1,
            Hiking = 2,
            Kayaking = 3,
            Running = 4,
            Skiing = 5,
            Swimming = 6,
            Walking = 7,
            HeavyLifting = 8
        }

        /// <summary>
        /// Constructors an activity for the provided activity type and name.
        /// </summary>
        /// <param name="activityType">The activity type for the activity.</param>
        /// <param name="name">The name for the activity.</param>
        public Activity(ActivityType activityType, string name = null)
        {
            Id = (int)activityType;

            // If we don't have a name argument, 
            // then use the string representation of the activity type for the name.
            Name = name ?? activityType.ToString();
        }

        /// <summary>
        /// The ID of the activity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string Name { get; set; }
    }
}
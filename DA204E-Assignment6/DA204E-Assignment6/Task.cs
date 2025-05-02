// Sixten Peterson (AQ9300) 2025-04-30
namespace DA204E_Assignment6
{
    // The task class basically is a model of a task, each task contain a date time, priority and description.
    public class Task
    {
        private DateTime dateTime; // The date time of the task
        private PriorityType priority; // The priority of the task
        private string description; // The description of the task

        /// <summary>
        /// Property for the dateTime instance variable
        /// </summary>
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        /// <summary>
        /// Property for the priority instance variable
        /// </summary>
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        /// <summary>
        /// Property of the description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { 
                if (!string.IsNullOrEmpty(value)) // Validating that the description isn't null or empty
                {
                    description = value;
                }
            }
        }

        /// <summary>
        /// Property for getting the time of the task based on the dateTime
        /// </summary>
        public string Time
        {
            get { return dateTime.ToString("HH:mm"); }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Task()
        {
            this.dateTime = DateTime.Now;
            this.priority = PriorityType.Normal;
            this.description = "";
        }

        /// <summary>
        /// Copy constrcutor.
        /// </summary>
        /// <param name="task">The task to make a copy of.</param>
        public Task(Task task)
        {
            this.dateTime = task.DateTime;
            this.priority = task.Priority;
            this.description = task.Description;
        }

        /// <summary>
        /// Three parameter constructor, creating a complete task
        /// </summary>
        /// <param name="dateTime">The date time of the task</param>
        /// <param name="priority">The priority of the task</param>
        /// <param name="description">The description of the task</param>
        public Task(DateTime dateTime, PriorityType priority, string description)
        {
            this.dateTime = dateTime;
            this.priority = priority;
            this.description = description;
        }

        /// <summary>
        /// Returns a nicley formatted string representing the task
        /// </summary>
        /// <returns>Nicley formatted string</returns>
        public override string ToString()
        {
            return string.Format("{0, -24} {1, -7} {2, -16} {3, -20}", this.dateTime.ToLongDateString(), this.Time, this.priority, this.description);
        }

    }
}

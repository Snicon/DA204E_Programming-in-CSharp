// Sixten Peterson (AQ9300) 2025-04-01
namespace DA204E_Assignment6
{
    /// <summary>
    /// The task manager class is responsible for keeping (and encapsulating) a list of tasks.
    /// </summary>
    public class TaskManager
    {
        List<Task> tasks = new List<Task>(); // List of tasks

        public List<Task> Tasks
        {
            get { return tasks; }
        }

        /// <summary>
        /// Adds the provided task into the task list.
        /// </summary>
        /// <param name="task">The task to add into the list.</param>
        /// <returns>True if successful, flase if the task was invalid (description was null or empty)</returns>
        public bool AddTask(Task task)
        {
            if (!String.IsNullOrEmpty(task.Description)) // Making sure the description isnt null or empty before adding the task
            {
                this.tasks.Add(task);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Removes a task from the task list based on the specified task index.
        /// </summary>
        /// <param name="taskIndex">The index in the list where the task is stored.</param>
        /// <returns>True if successfully removed, false if invalid index was provided.</returns>
        public bool RemoveTask(int taskIndex)
        {
            if (taskIndex > -1 && taskIndex < this.tasks.Count)
            { // Making sure the index is valid
                this.tasks.RemoveAt(taskIndex); // Removing the task at the provided index
                return true; // Success
            }
            return false; // Failed due to invalid index
        }

        /// <summary>
        /// Returns a copy of the task object in the task list matching the provided task index.
        /// </summary>
        /// <param name="taskIndex"></param>
        /// <returns></returns>
        public Task getTask(int taskIndex)
        {
            return new Task(this.tasks[taskIndex]);
        }

        /// <summary>
        /// Replaces the task object in the task list with the matching task index with a new task object.
        /// </summary>
        /// <param name="taskIndex">The index of the task to replacein the task list.</param>
        /// <param name="task">The new task object to replace the old one with.</param>
        /// <returns>True if sucessfully replaced the task, flase if it failed to replace the task due to an invalid taskIndex.</returns>
        public bool updateTask(int taskIndex, Task task)
        {
            if (taskIndex > -1 && taskIndex < this.tasks.Count) // Making sure the taskIndex is valid
            {
                this.tasks[taskIndex] = task; // Setting to the new task object with the new data
                return true; // Success, task data updated
            }

            return false; // Failed due to invalid index
        }

        /// <summary>
        /// Clears the list of tasks.
        /// </summary>
        public void Clear()
        {
            this.tasks.Clear();
        }
    }
}

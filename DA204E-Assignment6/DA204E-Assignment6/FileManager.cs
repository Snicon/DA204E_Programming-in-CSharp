// Sixten Peterson (AQ9300) 2025-05-01
namespace DA204E_Assignment6
{
    /// <summary>
    /// This class is responsible for saving/exporting task data as well as importing/loading task data from a file.
    /// </summary>
    public class FileManager
    {
        private const string FileToken = "TodoApp_SixtenPeterson"; // Stample marking that this file was saved/created from this application
        private const double FileVersion = 1.0; // Version number, won't be used for much in this assignment but could improve backwards compatability if the program is extended in the future

        /// <summary>
        /// Saves all the tasks form the list in the task manager to a file.
        /// </summary>
        /// <param name="tasks">The list of tasks to save into the file</param>
        /// <param name="fileName">The full file path (file name) of the file where the data will be stored</param>
        /// <returns>True if successful, false if something went wrong (could be due to file contents or file token/version missmatch)</returns>
        public bool SaveTasksToFile(List<Task> tasks, string fileName)
        {
            int taskCount = tasks.Count; // The amount of tasks in the task list

            bool isSuceessful = true; // Defaulting to true, will be changed to false if an exception occured
            StreamWriter fileWriter = null;

            try // Trying to store all the data in a file
            {
                fileWriter = new StreamWriter(fileName); // Creating an instance of StreamWriter, the argument is the path
                // Just writing lines to the file below
                fileWriter.WriteLine(FileToken);
                fileWriter.WriteLine(FileVersion);
                fileWriter.WriteLine(taskCount);

                for (int i = 0; i < taskCount; i++) // Foor loop, for each task write down the following infromation on a new line
                {
                    fileWriter.WriteLine(tasks[i].Description);
                    fileWriter.WriteLine(tasks[i].Priority);
                    fileWriter.WriteLine(tasks[i].DateTime.Year);
                    fileWriter.WriteLine(tasks[i].DateTime.Month);
                    fileWriter.WriteLine(tasks[i].DateTime.Day);
                    fileWriter.WriteLine(tasks[i].DateTime.Hour);
                    fileWriter.WriteLine(tasks[i].DateTime.Minute);
                    fileWriter.WriteLine(tasks[i].DateTime.Second);
                }
            }
            catch (Exception exception) // An exception (problem) occured while trying to store the data
            {
                isSuceessful = false; // Obviously something went wrong
            }
            finally // always run after the try block is done even if an exception occured
            {
                if (fileWriter != null) // If the StreamWriter object isn't closed we close it.
                {
                    fileWriter.Close();
                }
            }

            return isSuceessful; // Return if we failed or succeeded
        }

        /// <summary>
        /// Loads tasks from a compatible file
        /// </summary>
        /// <param name="tasks">The list of tasks that will be populated with the dta from the file</param>
        /// <param name="fileName">The full file path (file name) of the file where the data will be read from</param>
        /// <returns>True if successful or False if the file was not compatible or something else went wrong.</returns>
        public bool LoadTasksFromFile(List<Task> tasks, string fileName)
        {
            bool isSuccessful = true; // Default to true
            StreamReader fileReader = null;

            try
            {
                if (tasks != null) // Meaning there is data in the list
                {
                    tasks.Clear(); // Removing said data
                } else
                {
                    tasks = new List<Task>(); // Making a new list and setting it to the tasks variable
                }

                fileReader = new StreamReader(fileName); // Making a new instance/object of StreamReader which will be used to read the file contents

                string fileToken = fileReader.ReadLine(); // Getting what we hope is the file token
                double fileVersion = double.Parse(fileReader.ReadLine());

                if (fileToken.Equals(FileToken) && fileVersion.Equals(FileVersion)) { // Making sure the file token and version matches, otherwise we can't read the file as the structure might be incorrect for this version
                    int taskAmount = int.Parse(fileReader.ReadLine());

                    for (int i = 0; i < taskAmount; i++) // Reading, parsing and adding each task to the list of tasks
                    {
                        string description = fileReader.ReadLine(); // Reading the description
                        PriorityType priority = (PriorityType)Enum.Parse(typeof(PriorityType), fileReader.ReadLine()); // Reading the priority

                        // Below we are creating a new DateTime object based on the DateTime data stored in the file
                        int year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0; // Initializing variables that will store the parsed ints

                        year = int.Parse(fileReader.ReadLine());
                        month = int.Parse(fileReader.ReadLine());
                        day = int.Parse(fileReader.ReadLine());
                        hour = int.Parse(fileReader.ReadLine());
                        minute = int.Parse(fileReader.ReadLine());
                        second = int.Parse(fileReader.ReadLine());

                        DateTime dateTime = new DateTime(year, month, day, hour, minute, second);

                        // Creating a new task object based on the data that has been read and parsed from the file
                        Task task = new Task(dateTime, priority, description);

                        tasks.Add(task); // Adding the task to the task list
                    }
                }
                else
                {
                    isSuccessful = false; // The file token and/or version did not match
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception: " + exception.Message + " MORE: " + exception.StackTrace);
                isSuccessful = false; // An exception occured and something went wrong, we obviously did not succeed
            }
            finally
            {
                if (fileReader != null) // If the StreamReader object isnt already closed we are closing it
                {
                    fileReader.Close();
                }
            }

            return isSuccessful;
        }
    }
}

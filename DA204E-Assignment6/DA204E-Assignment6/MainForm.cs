// Sixten Peterson (AQ9300) 2025-04-30
using DA204E_Assignment6.Properties;

namespace DA204E_Assignment6
{
    /// <summary>
    /// The main form of the application, houses almost everything graphical that the user interacts with.
    /// </summary>
    public partial class MainForm : Form
    {
        TaskManager taskManager; // The task manager instance that will be holding the list of the tasks etc. Will be created in the InitGUI method
        FileManager fileManager = new FileManager(); // The file manager instance, will be used to read from and write to files.
        Task currentTask = new Task(); // The current task object, this object is then used when adding or updating tasks before getting cleared

        int selectedTaskIndex = -1; // The currently selected task index, defaults to -1 because it is equivelent to no selection

        private const string ToolTipCaption = "Click to open calendar for date, write in the time here.";

        /// <summary>
        /// The no param constructor, initializes components/controls from design phase and from the code
        /// </summary>
        public MainForm()
        {
            InitializeComponent(); // Design phase initilization
            this.InitGUI(); // Initializes the GUI in code, for more details see the method
        }

        /// <summary>
        /// Initialization method, creates a new TaskManager, populates the priority combo box, syncs the components/controls as well as the listbox.
        /// It also deactives/activates the buttons, adds a tooltip and starts the clock.
        /// </summary>
        private void InitGUI()
        {
            this.Icon = Properties.Resources.icon;
            this.taskManager = new TaskManager();
            this.PopulatePriority();
            this.SyncTaskComponents();
            this.SyncLstTodo();
            this.ToggleButtons();
            this.ToolTip();
            this.InitClock();
        }

        /// <summary>
        /// Populates the priority combo box with all enum names
        /// </summary>
        private void PopulatePriority()
        {
            this.cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType))); // Adds the enum names to the items array of the combo box
        }

        /// <summary>
        /// Syncs the task components/controls. In other words sets the date time picker, priority combo box and the description text field to the matching values of the currentTask objects instancevariables.
        /// </summary>
        private void SyncTaskComponents()
        {
            this.dtpDateTime.Value = currentTask.DateTime; // Setting date time picker
            this.cmbPriority.SelectedIndex = (int)currentTask.Priority; // Setting the priority type
            this.txtDescription.Text = currentTask.Description; // Setting the description
        }

        /// <summary>
        /// Sets a tool tip to the date time picker.
        /// </summary>
        private void ToolTip()
        {
            this.ttDateTime.SetToolTip(this.dtpDateTime, ToolTipCaption); // Setting the tool tip to the date time picker control
        }

        /// <summary>
        /// First sets the time of the clock label to the current time, then starts the timer that will set the clock to the current time every second.
        /// </summary>
        private void InitClock()
        {
            this.lblClock.Text = DateTime.Now.ToString("HH:mm:ss"); // Setting the clock label to the current time
            this.timer.Start(); // Starting the timer, this timer will perform an action every second
        }

        /// <summary>
        /// Reads the date time from the date time picker control and sets it to the currentTask
        /// </summary>
        private void ReadDateTime()
        {
            DateTime dateTime = this.dtpDateTime.Value; // Getting the value of the date time picker
            this.currentTask.DateTime = dateTime; // Setting the value to the current task DateTime instnace variable through the property
        }

        /// <summary>
        /// Reads the priority from the priority combo box and thens sets it to the current task object
        /// </summary>
        private void ReadPriority()
        {
            PriorityType priority = (PriorityType)this.cmbPriority.SelectedIndex; // Getting the selected priority type from the combo box
            this.currentTask.Priority = priority; // Sets the priority type in the current task object
        }

        /// <summary>
        /// Reads the description and sets the description for the current task if valid (not empty or null)
        /// </summary>
        /// <returns>True if valid, false if invalid</returns>
        private bool ReadDescription()
        {
            String description = this.txtDescription.Text.Trim(); // Reads and trims the description form the text field

            if (String.IsNullOrEmpty(description)) // Checking if the string is null or empty
            {
                MessageBox.Show("Please input a task description, otherwise you might forget what the task entails!", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Informing the user they forgot to input a description
                return false; // Failed
            }
            else
            {
                this.currentTask.Description = description; // Setting the description value in the current task
                return true; // Success
            }
        }

        /// <summary>
        /// Calls all the methods that reads input, which updates all the data for the current task.
        /// </summary>
        /// <returns>True if the description was valid, False if the description was invalid.</returns>
        private bool ReadInput()
        {
            this.ReadDateTime();
            this.ReadPriority();
            bool description = this.ReadDescription();

            return description;
        }

        /// <summary>
        /// "Clears" the form inputs by setting the values of the newly created currentTask.
        /// </summary>
        private void ClearCurrentTask()
        {
            this.currentTask = new Task(); // Setting the current task to a new task object essentially clearing the state.
            this.SyncTaskComponents(); // Syncing the GUI controls with the new task object data (clearing the inputs).
            this.ToggleButtons(); // Disabling the buttons because no task will be selected anymore.
        }

        /// <summary>
        /// Adding a task to the task manager task list as well as the GUI.
        /// </summary>
        private void AddTask()
        {
            if (this.ReadInput()) // Reads all input and checks if they are valid
            {
                bool added = this.taskManager.AddTask(this.currentTask); // Tries to add the current task to the task manager task list

                if (added) // If the task was successfully added we add it to the GUI
                {
                    this.lstTodo.Items.Add(this.currentTask.ToString()); // Adds the task to the GUI
                    this.ClearCurrentTask(); // Clears the current task to the default state
                    this.ToggleButtons(); // Toggles the buttons to the correct state
                }
            }
        }

        /// <summary>
        /// Asks the user if it is sure that it wants to exit the application and does so if the user presses ok and cancels if the user presses cancel.
        /// </summary>
        private void ExitApplication()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Think twice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); // Asking the user if it is sure?

            if (result == DialogResult.OK)
            {
                Application.Exit(); // Exits the application because the user pressed OK
            }
        }

        private void SaveTaskFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // Open Save File Dialog for picking where to save the file and what to save it as
            saveFileDialog.Filter = "Text files (*.txt)|*.txt"; // Apply a filter that specifices the allowed file formats
            saveFileDialog.DefaultExt = "txt"; // Defaulting to the txt file extension

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = saveFileDialog.FileName;
                this.fileManager.SaveTasksToFile(this.taskManager.Tasks, filePath);
                MessageBox.Show("The file was saved.", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Syncs the lstTodo listbox with the taskmanagers list of tasks
        /// </summary>
        private void SyncLstTodo()
        {
            this.lstTodo.Items.Clear(); // Clear the lstTodo listbox

            if (this.taskManager.Tasks != null) // If there are any tasks
            {
                foreach (Task task in this.taskManager.Tasks) // For each task add the task string to the listbox
                {
                    this.lstTodo.Items.Add(task.ToString());
                };
            }
            this.ToggleButtons(); // Make sure the buttons are in the correct state (enabled/disabled)
        }

        /// <summary>
        /// Disables/enables the buttons depending on wether or not a there is a task selected
        /// </summary>
        private void ToggleButtons()
        {
            if (this.selectedTaskIndex == -1) // No task is selected, disable all buttons
            {
                this.btnChange.Enabled = false;
                this.btnDelete.Enabled = false;
            }
            else // A task is selected, enable all the buttons
            {
                this.btnChange.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// Loads tasks from a user specified file by opening a OpenFileDialog where the user decides which fileto load from and then tries to load the tasks in the
        /// file if the file is correctly formatted. if the file fails to load the user is notfied by a message box, the user is aslso notfied upon a successful file
        /// load.
        /// </summary>
        private void LoadTaskFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Open Open File Dialog for picking what file to load tasks from
            openFileDialog.Filter = "Text files (*.txt)|*.txt"; // Apply a filter that specifices the allowed file formats
            openFileDialog.DefaultExt = "txt"; // Defaulting to the txt file extension

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName; // Getting full file path, its apparently called file name in C#, had no idea about this prior to writing this assignment
                this.taskManager.Clear(); // Clearing the task list in the task manager
                bool loaded = this.fileManager.LoadTasksFromFile(this.taskManager.Tasks, filePath); // actually loading the tasks in the file from the full file path and then adding the tasks to the task list

                if (loaded) // Success
                {
                    this.SyncLstTodo(); // Prompting the list box to update to include all the newly added tasks
                    MessageBox.Show($"The file ({filePath}) was successfully loaded.", "File loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Failure
                {
                    MessageBox.Show($"The file ({filePath}) failed to load. It might not be compatible or the file structure is incorrect.", "File failed to load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Deletes the selected task form the list box and task list in the task manager
        /// </summary>
        private void DeleteTask()
        {
            if (this.selectedTaskIndex != -1) // Making sure a task is selected
            {
                // Asking the user if it is sure it want to delete the task
                DialogResult = MessageBox.Show("Are you sure you want to delete the task?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK) // If the user pressed OK
                {
                    bool isRemoved = this.taskManager.RemoveTask(this.selectedTaskIndex); // Trying to remove the task from the task manager task list

                    if (isRemoved) // Success
                    {
                        this.lstTodo.Items.RemoveAt(this.selectedTaskIndex); // Removing the task from the list box as well
                        this.ToggleButtons(); // Making sure the buttons are in the right state
                    }
                }
            }
        }

        /// <summary>
        /// Deselects the task in the todo list box and sets the input fíelds back to the default values
        /// </summary>
        private void HandleClear()
        {
            lstTodo.SelectedIndex = -1; // Deselecting the task in the listbox
            this.ClearCurrentTask(); // Defaulting the input fields
        }

        /// <summary>
        /// Updates the selected task with new data
        /// </summary>
        private void ChangeTask()
        {
            if (this.selectedTaskIndex > -1) // Making sure a task is selected
            {
                this.ReadInput(); // Reading input and updating the currentTask object data
                bool isUpdated = taskManager.updateTask(this.selectedTaskIndex, this.currentTask); // Updating the task

                if (isUpdated) // If a successful update was made we need to update hte listbox, which is done below
                {
                    this.lstTodo.Items[this.selectedTaskIndex] = this.currentTask.ToString();
                }
            }
            else
            {
                // Giving user feedback for not having picked a task. Should not be possible ot get to this point though as the button should be disabled.
                MessageBox.Show("Please select a task to change.", "No task selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Event handler for activating the exit menu item, exits the application if the user presse OK in the message box asking the user if it is sure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExitApplication();
        }

        /// <summary>
        /// Handling change of task selection by setting the selected task index field variable and filling currentObject and form if a task is selected for easier task editing
        /// </summary>
        private void HandleSelectionChange()
        {
            this.selectedTaskIndex = this.lstTodo.SelectedIndex; // Setting the selectedTaskIndex instance variable

            if (this.selectedTaskIndex > -1) // If a task is selected
            {
                this.currentTask = this.taskManager.getTask(this.selectedTaskIndex); // Setting the currentTask object data to the same data as the currently selected task which is helpful when editing a task
                this.SyncTaskComponents(); // Syncing the GUI with the data from the currentTask obejct
                this.ToggleButtons(); // Making sure the buttons are in the right state
            }
        }

        /// <summary>
        /// Reads the user input, validates it and then adds a new task to the list in the TaskManager if valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddTask();
        }

        /// <summary>
        /// Event handler for when the save as menu item is clicked, calls SaveTaskFileAs to export data from the program to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveTaskFileAs();
        }

        /// <summary>
        /// Event handler for when the open data file menu item is clicked, calls LoadTaskFile to import data to the program from a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadTaskFile();
        }

        /// <summary>
        /// Event handler for when the new menu item is clicked, calls the GUI initilization to clear the state of the entire program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.InitGUI();
        }

        /// <summary>
        /// Event handler for when the timer ticks, sets the clock label to the current time in a nice time format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Event handler for when a task selection changes, calls the HandleSelectionChange method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandleSelectionChange();
        }

        /// <summary>
        /// Event handler for when a the delete button is pressed, calls the DeleteTask method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteTask();
        }

        /// <summary>
        /// Event handler for when the clear button is pressed, calls the HandleClear method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.HandleClear();
        }

        /// <summary>
        /// Event handler for when the change button is pressed, calls the ChangeTask method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            this.ChangeTask();
        }

        /// <summary>
        /// Event handler for when the about menu item is clicked, opens the about box form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}

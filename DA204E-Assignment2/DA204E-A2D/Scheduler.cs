// Sixten Peterson (AQ9300) 2025-02-24
namespace DA204E.A2D
{
    /// <summary>
    /// The Scheduler class houses the application as a whole. Use the Start() method to start the program.
    /// </summary>
    internal class Scheduler
    {
        // Avoiding magic numbers for cleaner code.
        private const int MIN_OPTION = 0;
        private const int MAX_OPTION = 2;

        // Same here but for all the work schedule stuff
        private const int TOTAL_WEEKS = 52;
        private const int WEEKENDS_STARTING_WEEK = 1;
        private const int WEEKENDS_INTERVAL = 2;
        private const int NIGHT_STARTING_WEEK = 2;
        private const int NIGHT_INTERVAL = 4;

        // Calling this from multiple methods, only makes sense to move it up here
        private const String DIVIDER = "---------------------------------------------------------";

        /// <summary>
        /// The public method used for running the Scheduler program, starts off by printing a "welcome" text. Also contains a loop for running the program multiple times.
        /// This method also houses the logic of what should be done depending on the valid input.
        /// </summary>
        public void Start()
        {
            this.WriteWelcome();

            bool stop = false; // For keeping track on when the program should end

            do
            {
                this.WriteMenuOptions();
                int chosenOption = this.ReadOption();

                switch (chosenOption)
                {
                    case 0:
                        stop = true; // Option 0 exits the program, therefor we break out of the loop
                        break;
                    case 1:
                        this.WriteWorkSchedule(WEEKENDS_STARTING_WEEK, WEEKENDS_INTERVAL);
                        break;
                    case 2:
                        this.WriteWorkSchedule(NIGHT_STARTING_WEEK, NIGHT_INTERVAL);
                        break;
                    default:
                        break;
                }
            } while (!stop);
        }

        /// <summary>
        /// Prints a "header" for the program showcasing its name.
        /// </summary>
        private void WriteWelcome()
        {
            Console.WriteLine("++++++++++++++++ The Scheduler! ++++++++++++++++");
            Console.WriteLine(DIVIDER);
            Console.WriteLine("\t\tYOUR WORK SCHEDULE");
            Console.WriteLine(DIVIDER);
            Console.WriteLine(); // White space
        }

        /// <summary>
        /// Prints the different options to choose between in the main menu.
        /// </summary>
        private void WriteMenuOptions()
        {
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit");
            Console.WriteLine(); // White space
        }

        /// <summary>
        /// Handles input for the main menu, accepting: 0, 1, 2. All while disallowing any other input, upon invalid input a message is printed fpr the user to see.
        /// </summary>
        /// <returns>An int representing the chosen option.</returns>
        private int ReadOption()
        {
            int option = 0;
            bool parsed = false;

            Console.Write("\nYour choice: ");

            do
            {
                string input = Console.ReadLine() + "";
                parsed = int.TryParse(input, out option);

                if (!parsed || option > MAX_OPTION || option < MIN_OPTION) // Validation, making sure the input is either 0, 1 or 2.
                {
                    parsed = false; // Failed validation, lets try parsing again with the help of the do while loop
                    Console.WriteLine($"Invalid input, please try again. You can only input the following numbers: 0, 1, 2.");
                }
            } while (!parsed);

            return option; // Finally we are happy with the input and we return it since it was validated
        }

        /// <summary>
        /// Writes the work schedule based on starting week and interval. Designed to allow for additional schedules with other start weeks and intervals.
        /// </summary>
        /// <param name="startWeek">The starting week for the schedule, in other words the very same week of the first work pass.</param>
        /// <param name="interval">The interval of the schedule, in other words how often to work in weeks. 1 for every week, 2 for every other week and so on.</param>
        private void WriteWorkSchedule(int startWeek, int interval)
        {
            int columnCount = 4;    // Number of columns per row: in other words, we want four weeks per row/line
            int count = 0;          // The current "index" of column: in other words, for each week up the count

            // For loop for printing the weeks in a nice format based on interval, starting week and totalt weeks
            for (int week = startWeek; week <= TOTAL_WEEKS; week += interval)
            {
                Console.Write($"Week {week,-5}"); // Left-aligned with padding for nice format

                count++; // Up the count

                if (count % columnCount == 0)
                {
                    Console.WriteLine(); // New line after every 4 weeks
                }
            }

            Console.WriteLine("\n" + DIVIDER); // Mimicking the screenshots with this divider
        }
    }
}

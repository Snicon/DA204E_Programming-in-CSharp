// Sixten Peterson (AQ9300) 2025-02-20
namespace DA204E.A2C
{
    /// <summary>
    /// This class handles the string functions part of the program. The starting point of the program is the Start().
    /// </summary>
    internal class StringFunctions
    {
        // Avoiding magic numbers for better code quality and readability
        private const int FIRST_DAY = 1;
        private const int LAST_DAY = 7;

        /// <summary>
        /// The start point of the String functions program, calling the private methods implementing functions according to the assignment description.
        /// Reruns with the help of a do while loop until the user decides to exit.
        /// </summary>
        public void Start()
        {
            bool stop = false;

            do
            {
                Console.WriteLine("\n\n++++++++ String Functions! ++++++++\n\n");
                this.StringLength();
                this.PredictMyDay();
                stop = !this.RunAgain();
            } while (!stop);
        }

        /// <summary>
        /// The implementation of the StringLength function. Prompts the user to input a text and then prints the length of the string as well as the
        /// string in uppercase.
        /// </summary>
        private void StringLength()
        {
            Console.WriteLine("Write a text with any number of characters and press Enter. \nYou can even copy text from a file and paste it here!\n");
            string input = Console.ReadLine() + "";
            int length = input.Length;

            Console.WriteLine("\n---- STRING LENGTH ----\n");
            Console.WriteLine(input.ToUpper());
            Console.WriteLine($"Number of chars = {length}\n\n");
        }

        /// <summary>
        /// Implementation of the predict my day function. Uses a switch statement to print out different fortunes based on the specified day.
        /// Uses ReadDay method for validation and input of the day.
        /// </summary>
        private void PredictMyDay()
        {
            Console.WriteLine("********** The Fortune Teller **********");
            int day = this.ReadDay();
            string message = "";

            switch (day)
            {
                case 1:
                    message = "Keep calm on Mondays! You can fall apart!";
                    break;
                case 2:
                case 3:
                    message = "Tuesdays and Wednesdays break your heart!";
                    break;
                case 4:
                    message = "Thursday is your lucky day, don't wait for Friday!";
                    break;
                case 5:
                    message = "Friday, you are in love!";
                    break;
                case 6:
                    message = "Saturday, do nothing and do plenty of it!";
                    break;
                case 7:
                    message = "And Sunday always comes too soon!";
                    break;
                default: // Now I'm impressed if someone ever gets here based on the validation done in the ReadDay() method.
                    Console.WriteLine("No day? A good day but it doesn't exist!");
                    break;
            }

            Console.WriteLine(message);

        }

        /// <summary>
        /// Handles input of the day by parsing the input as an int and determining if it is a valid int representing a day. Invalid input prints a message
        /// to the user and immediately re try until there is a valid input.
        /// </summary>
        /// <returns>An int representing a day where 1 represents Monday, and 7 represents Sunday.</returns>
        private int ReadDay()
        {
            int day = 0;
            bool parsed = false;

            Console.WriteLine("Let me predict your day! Select a number between 1 and 7: ");

            do
            {
                string input = Console.ReadLine() + "";
                parsed = int.TryParse(input, out day);

                if (!parsed || day < FIRST_DAY || day > LAST_DAY) // Validating the input
                {
                    parsed = false; // Input was invalid, make parsed false in order to prompt a retry via the do while loop.
                    Console.WriteLine($"Invalid input, please try again. You can only input 1 to 7 (inclusive), where 1 is Monday and 7 is Sunday.");
                }
            } while (!parsed);

            return day; // Returning the valid int representing a day between Monday and Sunday.
        }

        /// <summary>
        /// Determines if the user wants to run the program again using a switch statement rather than using loops it uses recursion.
        /// I wanted to do something different for once, these assignments tend to get quite repetetive. It's really handy to do it
        /// this way as default handle any other string than the ones provided as valid.
        /// </summary>
        /// <returns></returns>
        private bool RunAgain()
        {
            Console.WriteLine("\nContinue with another round? (y/n): ");
            string input = Console.ReadLine() + "";

            switch (input)
            {
                case "y":
                case "Y":
                    return true;
                case "n":
                case "N":
                    return false;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    return RunAgain();
            }
        }
    }
}

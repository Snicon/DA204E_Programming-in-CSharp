// Sixten Peterson (AQ9300) 2025-02-19
namespace DA204E.A2C
{
    /// <summary>
    /// The TemperatureConverter handles the temperature conversion part of the program. To run the program I refer you to the Start() method.
    /// </summary>
    internal class TemperatureConverter
    {
        // Avoiding magic numbers for code readability, a habit since my Java course at LTU
        private const int MIN_OPTION = 0;
        private const int MAX_OPTION = 2;

        /// <summary>
        /// The starting point of the program, using a do while loop and a switch statement for the selection logic with the help of the ReadOption() method.
        /// </summary>
        public void Start()
        {
            bool stop = false;

            do
            {
                this.WriteMenu();
                int chosenOption = this.ReadOption();

                switch (chosenOption)
                {
                    case 0:
                        stop = true;
                        break;
                    case 1:
                        WriteFahrenheitToCelsius();
                        break;
                    case 2:
                        WriteCelsiusToFahrenheit();
                        break;
                    default:
                        break;
                }

            } while (!stop);
        }

        /// <summary>
        /// Prints out the main menu of the program in a nice format. Nothing special really, just like myself.
        /// </summary>
        private void WriteMenu()
        {
            string divider = "*****************************************";

            Console.WriteLine(divider);
            Console.WriteLine("\t\tMAIN MENU");
            Console.WriteLine(divider);
            Console.WriteLine("\tConvert Fahrenheit to Celcius : 1");
            Console.WriteLine("\tConvert Celcius to Fahrenheit : 2");
            Console.WriteLine("\tExit the Converter            : 0");
            Console.WriteLine(divider);

        }

        /// <summary>
        /// Handles and validated the input for choosing an option in the main menu. By using the do while loop the user is repeatedley asked until there is a
        /// valid input provided, which will then be returned by the method.
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
                parsed = int.TryParse(input, out option); // Trying to parse the input as an int, upon failed parsing another iteration will be ran.

                if (!parsed || option > MAX_OPTION || option < MIN_OPTION) // Validating the input
                {
                    parsed = false; // Validation failed, we are therefor marking it as unparsed to force another iteration of the loop.
                    Console.WriteLine($"Invalid input, please try again. You can only input the following numbers: 0, 1, 2.");
                }
            } while (!parsed);

            return option;
        }

        /// <summary>
        /// Prints out the converted celsius values into fahrenheit in a nicely formatted way, using multiple columns. Going from 0 to 100 degrees celsius
        /// </summary>
        private void WriteCelsiusToFahrenheit()
        {
            Console.WriteLine(); // White space
            for (int row = 0; row < 7; row++) // We want 7 rows => looping from 0 and stopping after 6.
            {
                for (int column = 0; column < 3; column++) // We want 3 columns => looping from 0 and stopping after 2.
                {
                    /* I think this is easier shown with an example rather than explaining, see the following two rows and the calculations done. These calculations are done for row 0 through 6. Please refer to the line of code below the comment to get the whole picture.
                    /  ROW0: COL0) (0x3+0) * 5 = 0     COL1) (0x3+1) * 5 = 5      COL2) (0x3+2) * 5 = 10
                    /  ROW1: COL0) (1x3+0) * 5 = 15    COL1) (1x3+1) * 5 = 20     COL2) (1x3+2) * 5 = 25
                    */
                    int celsius = (row * 3 + column) * 5;
                    double fahrenheit = CelsiusToFahrenheit(celsius); // Just converting by running the method we have created for conversion.
                    Console.Write($"{celsius,6:F2} C = {fahrenheit,6:F2} F\t"); // Nice string formatting to match the expected output.
                }
                Console.WriteLine(); // White space
            }
            Console.WriteLine(); // White space
        }

        /// <summary>
        /// Prints out the converted fahrenheit values into celsius in a nicely formatted way, using multiple columns. Going from 0 to 212 degrees fahrenheit.
        /// </summary>
        private void WriteFahrenheitToCelsius()
        {
            Console.WriteLine(); // White space
            for (int row = 0; row < 18; row++) // We want 18 rows => looping from 0 and stopping after 17.
            {
                for (int column = 0; column < 3; column++) // We want 3 columns => looping from 0 and stopping after 2.
                {
                    // For a better understanding please have a look at the comments in the mehtod above.
                    int fahrenheit = (row * 3 + column) * 4 + 0;
                    double celsius = FahrenheitToCelsius(fahrenheit); // Just converting by running the method we have created for conversion.
                    Console.Write($"{fahrenheit,6:F2} F = {celsius,6:F2} C\t"); // Nice string formatting to match the expected output.
                }
                Console.WriteLine(); // White space
            }
            Console.WriteLine(); // White space
        }

        /// <summary>
        /// Converts a double representing celsius into fahrenheit.
        /// </summary>
        /// <param name="celsius">The degrees of celsius you want to convert into fahrenheit.</param>
        /// <returns>A double representing the degrees of fahrenheit</returns>
        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32; // Calculation based on the information provided in the assignment description
        }

        /// <summary>
        /// Converts a double representing fahrenheit into celsius.
        /// </summary>
        /// <param name="fahrenheit">The degrees of fahrenheit you want to conver into celsius.</param>
        /// <returns>A double representing the degrees of celsius.</returns>
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9; // Calculation based on the information provided in the assignment description
        }
    }
}

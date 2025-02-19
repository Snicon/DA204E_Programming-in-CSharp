using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA204E.A2C
{
    internal class TemperatureConverter
    {
        private const int MIN_OPTION = 0;
        private const int MAX_OPTION = 2;


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

        private int ReadOption()
        {
            int option = 0;
            bool parsed = false;

            Console.Write("\nYour choice: ");

            do
            {
                string input = Console.ReadLine() + "";
                parsed = int.TryParse(input, out option);

                if (!parsed || option > MAX_OPTION || option < MIN_OPTION)
                {
                    parsed = false;
                    Console.WriteLine($"Invalid input, please try again. You can only input the following numbers: 0, 1, 2.");
                }
            } while (!parsed);

            return option;
        }

        private void WriteFahrenheitToCelsius()
        {
            Console.WriteLine(); // White space
            for (int row = 0; row < 18; row++) // We want 18 rows => looping from 0 and stopping after 17.
            {
                for (int column = 0; column < 3; column++) // We want 3 columns => looping from 0 and stopping after 2.
                {
                    int fahrenheit = (row * 3 + column) * 4 + 0;
                    double celsius = FahrenheitToCelsius(fahrenheit);
                    Console.Write($"{fahrenheit,6:F2} F = {celsius,6:F2} C\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

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
                    double fahrenheit = CelsiusToFahrenheit(celsius); // Just converting based on the code below
                    Console.Write($"{celsius,6:F2} C = {fahrenheit,6:F2} F\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

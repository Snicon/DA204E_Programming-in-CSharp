using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA204E.A2C
{
    internal class StringFunctions
    {
        private const int FIRST_DAY = 1;
        private const int LAST_DAY = 7;

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

        private void StringLength()
        {
            Console.WriteLine("Write a text with any number of characters and press Enter. \nYou can even copy text from a file and paste it here!\n");
            string input = Console.ReadLine() + "";
            int length = input.Length;

            Console.WriteLine("\n---- STRING LENGTH ----\n");
            Console.WriteLine(input.ToUpper());
            Console.WriteLine($"Number of chars = {length}\n\n");
        }

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

        private int ReadDay()
        {
            int day = 0;
            bool parsed = false;

            Console.WriteLine("Let me predict your day! Select a number between 1 and 7: ");

            do
            {
                string input = Console.ReadLine() + "";
                parsed = int.TryParse(input, out day);

                if (!parsed || day < FIRST_DAY || day > LAST_DAY)
                {
                    parsed = false;
                    Console.WriteLine($"Invalid input, please try again. You can only input 1 to 7 (inclusive), where 1 is Monday and 7 is Sunday.");
                }
            } while (!parsed);

            return day;
        }

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

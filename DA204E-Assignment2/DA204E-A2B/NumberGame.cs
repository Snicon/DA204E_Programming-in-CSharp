using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAE204E.A2B
{
    // TODO: Handle levels/difficulties


    /// <summary>
    /// 
    /// </summary>
    internal class NumberGame
    {
        private Random random = new Random();   // Random object will be used for generating numbers.
        private int minimumNumber = 0;          // The minimum valid number to guess.
        private int maximumNumber = 99;         // The maximum valid number to guess.
        private int attempts = 0;
        private int maxAttempts = -1;
        private const int SMALLEST_LEVEL = 0;
        private const int BIGGEST_LEVEL = 3;

        public void Start()
        {
            bool isPlaying = true;              // Keeps the state of the game, defaults to true as in: yes, the game is playing.

            this.WriteRules();                  // Prints the rules of the game

            while (isPlaying)
            {
                this.SetDifficultyLevel();          // Asks the user for the desired difficulty level and sets it.
                this.Play();
                isPlaying = this.ReMatch();
            }
        }

        private void WriteRules()
        {
            Console.WriteLine("---------------------- GUESS THE NUMBER ----------------------");
            Console.WriteLine("\tThe computer selects a random value between 0 and 99.");
            Console.WriteLine("\tYou have to guess the number. The game will let you");
            Console.WriteLine("\tknow wheter your guess is correct, greater than or");
            Console.WriteLine("\tless than the random number.");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Addition: ".ToUpper() + "You can now choose a difficulty level to make the game harder.");
        }

        private void Play()
        {
            bool isGameOver = false;
            this.attempts = 0; // Reset attempts for every new game
            int number = this.random.Next(minimumNumber, (maximumNumber + 1)); // Generates a random number based on the maximum and minimum numbers for generation (see the private fields). +1 is there due to Next() being exclusive to the upper bound, by adding one we can "include the upper bound"

            while (!isGameOver)
            {

                if (attempts == maxAttempts) // Attempts can't get to -1 based on the logic of our program so everything should be good.
                {
                    isGameOver = true;
                    Console.WriteLine("\n----- Better luck next time! -----");
                    Console.WriteLine("You lost.");
                    Console.WriteLine($"Attempts: {this.attempts}/{this.maxAttempts} ");
                } 
                else
                {
                    Console.Write($"\nGuess a number between {minimumNumber} and {maximumNumber}: ");
                    int guess = ReadGuess();
                    this.attempts++; // Attempt made, lets reflect this.

                    if (guess == number)
                    {
                        isGameOver = true;
                        Console.WriteLine("\n+++++ Congratulations! +++++");
                        Console.WriteLine($"Attempts: {this.attempts} / {(this.maxAttempts == -1 ? "Unlimited" : this.maxAttempts)}");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine($"Guess {this.attempts}/{(this.maxAttempts == -1 ? "Unlimited" : this.maxAttempts)}: Too high!");    // Using ternary operator as it comes in handy here, see the following article on Microsoft Learn as a reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
                    }
                    else
                    {
                        Console.WriteLine($"Guess {this.attempts}/{(this.maxAttempts == -1 ? "Unlimited" : this.maxAttempts)}: Too low!");     // See comment above
                    }
                }
            }
        }

        private bool ReMatch()
        {
            Console.Write("\nPlay again (y/n)? ");
            string input = Console.ReadLine() + "";

            if (string.Equals(input.ToUpper(), "Y"))
            {
                return true;
            } else if (string.Equals(input.ToUpper(), "N"))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return this.ReMatch();
            }
        }

        private int ReadGuess()
        {
            int number = 0;
            bool parsed = false;

            do
            {
                string input = Console.ReadLine() + ""; // + "" avoids null values
                parsed = int.TryParse(input, out number);

                if (!parsed || number > maximumNumber || number < minimumNumber)
                {
                    parsed = false; // A parsed number that is too high or too low is invalid, by setting parsed to false even though it has successfulyy parsed we are taking this into account.
                    Console.WriteLine($"Invalid input, please try again. You can only input whole numbers between {minimumNumber} and {maximumNumber}.");
                }
            } while (!parsed);

            return number;
        }

        private void SetDifficultyLevel()
        {
            int selection = 0;
            bool parsed = false;

            Console.WriteLine("\nWhat difficulty level would you like to play?");
            Console.WriteLine("0) Unlimited guesses, 1) 10 guesses, 2) 8 guesses or 3) 5 guesses (includes bragging rights;)");

            do
            {
                string input = Console.ReadLine() + ""; // + "" avoids null values
                parsed = int.TryParse(input, out selection);

                if (!parsed || selection > BIGGEST_LEVEL || selection < SMALLEST_LEVEL)
                {
                    parsed = false; // A parsed number that is too high or too low is invalid, by setting parsed to false even though it has successfulyy parsed we are taking this into account.
                    Console.WriteLine($"\nInvalid input, please try again. You can only choose the following levels of difficulty: 0, 1, 2 and 3.");
                }
            } while (!parsed);

            switch (selection) // Handles the max attempts allowed based on the difficulty chosen by the player.
            {
                case 0:
                    this.maxAttempts = -1;
                    break;
                case 1:
                    this.maxAttempts = 10;
                    break;
                case 2:
                    this.maxAttempts = 8;
                    break;
                case 3:
                    this.maxAttempts = 5;
                    break;
                default: // Fallback case, shouldn't be possible to get here... but hey I've written broken software before, at least this will be easier to debug
                    Console.WriteLine("Error: Unable to determine difficulty level, level set to 0 (unlimited guesses).");
                    this.maxAttempts = -1;
                    break;
            }
        }
    }
}

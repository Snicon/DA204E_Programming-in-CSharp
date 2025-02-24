// Sixten Peterson (AQ9300) 2025-02-17
namespace DAE204E.A2B
{
    /// <summary>
    /// The NumberGame class contians the game logic of the number game. Start the game by running the Start() method.
    /// </summary>
    internal class NumberGame
    {
        private Random random = new Random();   // Random object will be used for generating numbers.

        // The minimum and maximum number to guess in the game
        private int minimumNumber = 0;          // The minimum valid number to guess.
        private int maximumNumber = 99;         // The maximum valid number to guess.

        // Keeping state of the attempts made and the maximum number of attempts.
        private int attempts = 0;
        private int maxAttempts = -1;

        // Avoding magic numbers for better code readability.
        private const int SMALLEST_LEVEL = 0;
        private const int BIGGEST_LEVEL = 3;

        /// <summary>
        /// This method is used for printing out the game rules as well as starting the game loop.
        /// </summary>
        public void Start()
        {
            bool isPlaying = true;              // Keeps the state of the game, defaults to true as in: yes, the game is playing.

            this.WriteRules();                  // Prints the rules of the game

            while (isPlaying)
            {
                this.SetDifficultyLevel();      // Asks the user for the desired difficulty level and sets it.
                this.Play();                    // Start a game
                isPlaying = this.ReMatch();     // Asks the user if it wants to play again and either exits the game or iterates on the loop again.
            }
        }

        /// <summary>
        /// Prints out the rules of the game.
        /// </summary>
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

        /// <summary>
        /// This method is used to play the game by generating a random number to guess and then looping until the user is out of guesses (if there is a limited
        /// amount of guesses.). It then prints out a game summary.
        /// </summary>
        private void Play()
        {
            bool isGameOver = false;
            this.attempts = 0; // Reset attempts for every new game
            int number = this.random.Next(minimumNumber, (maximumNumber + 1)); // Generates a random number based on the maximum and minimum numbers for generation (see the private fields). +1 is there due to Next() being exclusive to the upper bound, by adding one we can "include the upper bound"

            while (!isGameOver)
            {

                if (attempts == maxAttempts) // Max attempts reached. Attempts can't get to -1 based on the logic of our program so everything should be good in that regard.
                {
                    isGameOver = true;
                    Console.WriteLine("\n----- Better luck next time! -----");
                    Console.WriteLine("You lost.");
                    Console.WriteLine($"Attempts: {this.attempts}/{this.maxAttempts} ");
                } 
                else
                {
                    Console.Write($"\nGuess a number between {minimumNumber} and {maximumNumber}: ");
                    int guess = ReadGuess(); // taking valid input
                    this.attempts++; // Attempt made, lets reflect this.

                    if (guess == number) // The player got the number right and won:)
                    {
                        isGameOver = true;
                        Console.WriteLine("\n+++++ Congratulations! +++++");
                        Console.WriteLine($"Attempts: {this.attempts} / {(this.maxAttempts == -1 ? "Unlimited" : this.maxAttempts)}");
                    }
                    else if (guess > number) // To high of a guess
                    {
                        Console.WriteLine($"Guess {this.attempts}/{(this.maxAttempts == -1 ? "Unlimited" : this.maxAttempts)}: Too high!");    // Using ternary operator as it comes in handy here, see the following article on Microsoft Learn as a reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
                    }
                    else // Too low of a guess
                    {
                        Console.WriteLine($"Guess {this.attempts}/{(this.maxAttempts == -1 ? "Unlimited" : this.maxAttempts)}: Too low!");     // See comment above
                    }
                }
            }
        }

        /// <summary>
        /// Asks the player if it wants to play again and validates the response before returning it if valid or asking again if invalid.
        /// </summary>
        /// <returns></returns>
        private bool ReMatch()
        {
            Console.Write("\nPlay again (y/n)? ");
            string input = Console.ReadLine() + "";

            if (string.Equals(input.ToUpper(), "Y")) // Player wants to play agin
            {
                return true;
            } else if (string.Equals(input.ToUpper(), "N")) // Player does not want to play again
            {
                return false;
            }
            else // Input was invalid, using recursion we can call the same method again and ask again.
            {
                Console.WriteLine("Invalid input.");
                return this.ReMatch();
            }
        }

        /// <summary>
        /// Handles and validates guesses based on some very simple validation rules (the input must be a whole number between maximumNumber and miniumNumber)
        /// </summary>
        /// <returns></returns>
        private int ReadGuess()
        {
            int number = 0;
            bool parsed = false;

            do
            {
                string input = Console.ReadLine() + ""; // + "" avoids null values
                parsed = int.TryParse(input, out number);

                if (!parsed || number > maximumNumber || number < minimumNumber) // Validating the guess
                {
                    parsed = false; // A parsed number that is too high or too low is invalid, by setting parsed to false even though it has successfulyy parsed we are taking this into account.
                    Console.WriteLine($"Invalid input, please try again. You can only input whole numbers between {minimumNumber} and {maximumNumber}.");
                }
            } while (!parsed);

            return number;
        }

        /// <summary>
        /// Sets the difficulty level of the game according to the assignment description.
        /// </summary>
        /// <remarks>
        /// The validation rules allows only the following ints as valid difficulties (see also description of what the difficulty entails):
        /// <list type="bullet">
        ///     <item><description>0: Unlimited guesses</description></item>
        ///     <item><description>1: 10 guesses</description></item>
        ///     <item><description>2: 8 guesses</description></item>
        ///     <item><description>3: 5 guesses</description></item>
        /// </list>
        /// </remarks>
        private void SetDifficultyLevel()
        {
            int selection = 0; // The selection of difficulty, to be updated by the user input
            bool parsed = false; // If the input has been parsed, to be updated by try parse

            Console.WriteLine("\nWhat difficulty level would you like to play?");
            Console.WriteLine("0) Unlimited guesses, 1) 10 guesses, 2) 8 guesses or 3) 5 guesses (includes bragging rights;)");

            do
            {
                string input = Console.ReadLine() + ""; // + "" avoids null values and stops the ide from complaining
                parsed = int.TryParse(input, out selection); // Trying to parse the input

                if (!parsed || selection > BIGGEST_LEVEL || selection < SMALLEST_LEVEL) // Validating the input
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
                default: // Fallback case, shouldn't be possible to get here... but hey I've written broken software before, at least this will be easier to debug and handles the error gracefully.
                    Console.WriteLine("Error: Unable to determine difficulty level, level set to 0 (unlimited guesses).");
                    this.maxAttempts = -1;
                    break;
            }
        }
    }
}

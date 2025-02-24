// Sixten Peterson (AQ9300) 2025-02-16
namespace DA204E.A2A
{
    /// <summary>
    /// The CostCalculator class handles the logic of the program. To run the program I refer you to the Start() method.
    /// </summary>
    internal class CostCalculator
    {
        // Fields
        private double price;
        private int number;
        private double discount;

        /// <summary>
        /// The start method consits of a do while loop that keeps the program running until the user decides it wants to exit.
        /// </summary>
        public void Start()
        {
            bool stop = false;

            do
            {
                // Running the different private methods accountable for their own part of the program logic.
                this.ReadPriceInput();
                this.ReadUnitNumInput();
                this.CalculateDiscount();
                this.WritePricing();

                // Using the ContinueCalculations method to decide if the user wants to stop or continue the program.
                stop = ContinueCalculation();
            } while (!stop); // Keep on iterating until stop is true
        }

        /// <summary>
        /// Asks the user if it wants to continue the program or not. 
        /// </summary>
        /// <returns>true if the user wants to exit or flase if the wants to exit. This looks quite unintuitive looking back at it.
        /// I've opted for a different approach on the following parts of the assignment.</returns>
        private static bool ContinueCalculation()
        {
            Console.WriteLine("Continue? (yes/no or y/n):");
            String choice = Console.ReadLine(); // Getting input from user
            Console.WriteLine(); // For white space

            if (!string.IsNullOrEmpty(choice)) // Checks i the input was not null or empty.
            {
                choice = choice.ToLower(); // Make the choice lowercase to make it easier to compare string values

                if (choice.Equals("yes") || choice.Equals("y")) // User wants to continue
                {
                    return false;
                }
                else if (choice.Equals("no") || choice.Equals("n")) // User wants to exit
                {
                    return true;
                }
                else // Input was invalid
                {
                    Console.WriteLine("Invalid input, please try again.");
                    return ContinueCalculation(); // Ask again using recursion
                }
            }
            else // The input was null or empty
            {
                Console.WriteLine("Invalid input, please try again.");
                return ContinueCalculation(); // Ask again using recursion
            }
        }

        /// <summary>
        /// Reads the input of the price adn validates it
        /// </summary>
        private void ReadPriceInput()
        {
            bool isValidPrice = false;
            int parsedPrice = 0;

            do
            {
                Console.Write("Enter the original price per unit: ");
                String priceInput = Console.ReadLine();

                isValidPrice = int.TryParse(priceInput, out parsedPrice);

                // Checking if the price is parsed at this point
                if (isValidPrice)
                {
                    // Checking if the price is invalid at this point
                    if (parsedPrice <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                        isValidPrice = false; // The price, while parsed, was not valid so we need to change the boolean to cause a "re-prompt"
                    }
                    // The price wasn't invalid meaning we can assign it to the price field
                    else
                    {
                        this.price = parsedPrice;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            } while (!isValidPrice);
        }

        /// <summary>
        /// Reads the input of the quantity of product.
        /// </summary>
        private void ReadUnitNumInput()
        {
            bool isValidUnitNum = false;
            int parsedUnitNum = 0;

            do
            {
                Console.Write("Enter the quantity of the product: ");
                String unitNumInput = Console.ReadLine();

                isValidUnitNum = int.TryParse(unitNumInput, out parsedUnitNum);

                // Checking if the unit number is parsed at this point
                if (isValidUnitNum)
                {
                    // Checking if the unit number is invalid at this point
                    if (parsedUnitNum <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                        isValidUnitNum = false; // The unit number, while parsed, was not valid so we need to change the boolean to cause a "re-prompt"
                    }
                    // The price wasn't invalid meaning we can assign it to the number field
                    else
                    {
                        this.number = parsedUnitNum;
                    }
                } 
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            } while (!isValidUnitNum);
        }

        /// <summary>
        /// Calculates the discount based on the unit number
        /// </summary>
        private void CalculateDiscount()
        {
            if (this.number >= 10 && this.number <= 19)
            {
                this.discount = 20;
            }
            else if (this.number >= 20 && this.number <= 49)
            {
                this.discount = 30;
            }
            else if (this.number >= 50 && this.number <= 99)
            {
                this.discount = 40;
            }
            else if (this.number >= 100)
            {
                this.discount = 50;
            }
            else
            {
                this.discount = 0;
            }
        }

        /// <summary>
        /// Prints the pricing details based on the previous input that has been done in the program.
        /// </summary>
        private void WritePricing()
        {
            Console.WriteLine(); // For white space

            double totalCost = this.price * this.number;
            String formattedOriginalTotalCost = String.Format("Original Total Cost: {0:C}", totalCost);
            Console.WriteLine(formattedOriginalTotalCost);

            String formattedDiscountApplied = String.Format("Discount Applied: {0:f2} %", this.discount);
            Console.WriteLine(formattedDiscountApplied);

            double finalTotalCost = 0; // Keeping track of the final discount, will be updated below

            // If the discount is zero we dont want to multiply by zero, instead just assign the finalTotalCost without a discount.
            if (discount == 0)
            {
                finalTotalCost = (this.price * this.number);
            }
            else
            {
                double discountChangeFactor = discount / 100.0; // Example: 40.0 / divided by 100.0 => 0.4 which can be used to calculate the discounted price
                finalTotalCost = (this.price * discountChangeFactor) * this.number; // Simple calculations
            }

            String formattedFinalTotalCost = String.Format("Final Total Cost: {0:C}", finalTotalCost);
            Console.WriteLine(formattedFinalTotalCost);

            Console.WriteLine(); // For white space
        }

 
    }
}

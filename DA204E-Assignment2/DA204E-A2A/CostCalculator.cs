namespace DA204E.A2A
{
    internal class CostCalculator
    {
        private double price;
        private int number;
        private double discount;

        public void Start()
        {
            bool stop = false;

            do
            {
                this.ReadPriceInput();
                this.ReadUnitNumInput();
                this.CalculateDiscount();
                this.WritePricing();

                stop = ContinueCalculation();
            } while (!stop);
        }


        private static bool ContinueCalculation()
        {
            Console.WriteLine("Continue? (yes/no or y/n):");
            String choice = Console.ReadLine();
            Console.WriteLine(); // For white space

            if (!string.IsNullOrEmpty(choice))
            {
                choice = choice.ToLower();

                if (choice.Equals("yes") || choice.Equals("y"))
                {
                    return false;
                }
                else if (choice.Equals("no") || choice.Equals("n"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                    return ContinueCalculation();
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                return ContinueCalculation();
            }
        }

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

        private void WritePricing()
        {
            Console.WriteLine(); // For white space

            double totalCost = this.price * this.number;
            String formattedOriginalTotalCost = String.Format("Original Total Cost: {0:C}", totalCost);
            Console.WriteLine(formattedOriginalTotalCost);

            String formattedDiscountApplied = String.Format("Discount Applied: {0:f2} %", this.discount);
            Console.WriteLine(formattedDiscountApplied);

            // TODO: Handle case where product is below 10 and thefor has 0% discount
            double finalTotalCost = 0;

            // If the discount is zero we dont want to multiply by zero, instead just assign the finalTotalCost without a discount.
            if (discount == 0)
            {
                finalTotalCost = (this.price * this.number);
            }
            else
            {
                double discountChangeFactor = discount / 100.0; // Example: 40.0 / divided by 100.0 => 0.4 which can be used to calculate the discounted price
                finalTotalCost = (this.price * discountChangeFactor) * this.number;
            }

            String formattedFinalTotalCost = String.Format("Final Total Cost: {0:C}", finalTotalCost);
            Console.WriteLine(formattedFinalTotalCost);

            Console.WriteLine(); // For white space
        }

 
    }
}

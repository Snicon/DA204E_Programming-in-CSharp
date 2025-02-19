// Sixten Peterson (AQ9300) 2025-01-25
namespace DA204E_Assignment1_Part1
{
    /// <summary>
    /// The requirements leave quite a bit of assumptions to be made. I'm assuing children cost 50% of the ticket price and that the base price per ticket can be changed by the user if neccesary. Lastly I print a receipt. For more details read the other comments
    /// </summary>
    internal class TicketSeller
    {
        private string name;            // Name of the seller
        private double price = 99;      // Default ticket price
        private int numOfAdults;        // The amount of adults
        private int numOfChildren;      // The amount of children (their tickets will be calculated as 50% of the price in the ticket price calculator)

        private double amountToPay;     // The cost for the customer to pay. Calculated and stored by calling AmountToPay()

        /// <summary>
        /// The start point of the program that calls all the relevant private methods.
        /// </summary>
        public void Start()
        {
            this.ReadInput();
            this.calculateAmountToPay();
            this.PrintReceipt();
        }

        /// <summary>
        /// Calls the methods asking questions and accepting input
        /// </summary>
        private void ReadInput()
        {
            this.ReadName();
            this.ReadPrice();
            this.ReadNumOfAdults();
            this.ReadNumOfChildren();
        }

        /// <summary>
        /// Asks the user about the name of the ticket seller and then stores it in the name field.
        /// </summary>
        private void ReadName()
        {
            Console.WriteLine("\nWhat is the name of the ticket seller?");
            this.name = Console.ReadLine();
        }

        /// <summary>
        /// Asks the user about the price of the ticket. If the price is 99 (the default price) nothing is changed in the fields. If not, the user is prompted to write actual price of the ticket, this is then stored it in the price field.
        /// </summary>
        private void ReadPrice()
        {
            Console.WriteLine($"\nIs the price per ticket {this.price} (y/n)?");
            string correctPrice = Console.ReadLine().ToUpper();

            if (correctPrice == "Y")
            {
                Console.WriteLine("\nThanks for confirming!");
            }
            else
            {
                Console.WriteLine("\nNo? Then what is it?");
                double price = Convert.ToDouble(correctPrice);
                this.price = price;
                Console.WriteLine($"\nThe price per ticket was set to {this.price}, thanks for letting me know.");
            }
        }

        /// <summary>
        /// Asks the user about the amount of adults attending and then stores it in the numOfAdults field.
        /// </summary>
        private void ReadNumOfAdults()
        {
            Console.WriteLine("\nHow many adults are attending?");
            this.numOfAdults = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Asks the user about the amount of children attending and then stores it in the numOfChildren field.
        /// </summary>
        private void ReadNumOfChildren()
        {
            Console.WriteLine("\nHow many children are attending (50% per ticket)?");
            this.numOfChildren = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Calculates the price to pay based on the following conditions:
        /// The price per ticket (price field)
        /// The amount of adults (full price)
        /// The amount of children (50% ticket discount)
        /// </summary>
        private void calculateAmountToPay()
        {
            this.amountToPay = (price * numOfAdults) + (price * 0.5 * numOfChildren);
        }

        /// <summary>
        /// Prints the receipt containg the relevant data, nicley formatted.
        /// </summary>
        private void PrintReceipt()
        {
            string headerAndFooter = "++++++++++++ Ticket Receipt ++++++++++++";
            string separator = "----------------------------------------";

            Console.WriteLine("\n" + headerAndFooter);
            Console.WriteLine($"Seller: {this.name}");
            Console.WriteLine(separator);
            Console.WriteLine($"Adult ticket(s) x {numOfAdults} - {this.price} each");
            Console.WriteLine($"Children ticket(s) (50% off) x {numOfChildren} - {this.price / 2} each");
            Console.WriteLine($"Total amount paid: {this.amountToPay}");
            Console.WriteLine(separator);
            Console.WriteLine(headerAndFooter);
        }
    }
}

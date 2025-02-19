// Sixten Peterson (AQ9300) 2025-01-26
namespace DA204E_Assignment1_Part2
{
    internal class Book
    {
        // Had a hard time coming up with a constant that made sense for this kind of objet, this way I at the very least show that I know how to make one. Let's just say ratings are not implemented yet and therefor cannot be changed.
        private const int rating = 0; // A rating for the book... cannot be changed.

        // My non-constant fields
        private string name;        // The name of the book
        private int pages;          // The amount of pages in the book
        private string author;      // The author of the book
        private string category;    // The category of the book
        private DateTime boughtAt;    // Indicating the date of purchase, not yet bought when empty.

        /// <summary>
        /// Calls all the methods for gathering and displaying data for the object.
        /// </summary>
        public void Start()
        {
            ReadName();
            ReadPages();
            ReadAuthor();
            ReadCategory();
            PrintBookDetails();
            BuyBook();
            PrintBookDetails();
        }

        /// <summary>
        /// Asks the user for input on the name of the book and stores the input in the book field for the object.
        /// </summary>
        private void ReadName()
        {
            Console.WriteLine("What is the name of the book?");
            string name = Console.ReadLine();
            this.name = name;
        }

        /// <summary>
        /// Asks the user for input on the amount of pages in the book and stores the input in the pages field for the object.
        /// </summary>
        private void ReadPages()
        {
            Console.WriteLine($"\nHow many pages does {this.name} have?");
            int pages = int.Parse(Console.ReadLine());
            this.pages = pages;
        }

        /// <summary>
        /// Asks the user for input on the name of the author who wrote the book and stores the input in the author field for the object.
        /// </summary>
        private void ReadAuthor()
        {
            Console.WriteLine($"\nWho wrote {this.name}?");
            string author = Console.ReadLine();
            this.author = author;
        }

        /// <summary>
        /// Asks the user for input on the category of the book and stores the input in the category field for the object.
        /// </summary>
        private void ReadCategory()
        {
            Console.WriteLine($"\nWhat category is {this.name} in?");
            string category = Console.ReadLine();
            this.category = category;
        }

        /// <summary>
        /// Asks the user if it wants to buy the book. If it does the date of pruchase will be stored in the object, if not the it simply prints out "Maybe another time" after a new line.
        /// </summary>
        private void BuyBook()
        {
            Console.WriteLine($"\nWould you like to buy {this.name} by {this.author} (Y/N)?");
            string buyBookAnswer = Console.ReadLine().ToUpper();

            if (buyBookAnswer == "Y")
            {
                this.boughtAt = DateTime.Now;
                Console.WriteLine($"\nYou bought {this.name} by {this.author} at {this.boughtAt}. Enjoy your reading! :)");
            } else
            {
                Console.WriteLine("\nMaybe another time.");
            }
        }

        /// <summary>
        /// This method handles printing of the boughtAt field. If the boughtAt TimeDate is equal to the minimum value of the TimeDate class the method simply informs the user that the book has not yet been bought. If not the date and time of pruchase is printed.
        /// </summary>
        private void PrintFormattedBoughtAt()
        {
            if (this.boughtAt == DateTime.MinValue) // Compare the boughtAt TimeDate to the minimum TimeDate. The minimum TimeDate value indicates that no TimeDate has been set for the object.
            {
                Console.WriteLine("This book has not been bought yet...");
            } else
            {
                Console.WriteLine($"Book bought at: {this.boughtAt}");
            }
        }

        /// <summary>
        /// This methods prints the details of the book in a nicley formatted manner to give the user an overview of the object.
        /// </summary>
        private void PrintBookDetails()
        {
            string separator = "++++++++++++++++++++++++++++++++++++++++++++";

            Console.WriteLine("\n" + separator);
            Console.WriteLine($"Book name: {this.name}");
            Console.WriteLine($"Book pages: {this.pages}");
            Console.WriteLine($"Book author: {this.author}");
            Console.WriteLine($"Book category: {this.category}");
            Console.WriteLine($"Book rating: {rating}");
            Console.WriteLine(); // Intentional white space
            PrintFormattedBoughtAt();
            Console.WriteLine(separator);
        }
    }
}

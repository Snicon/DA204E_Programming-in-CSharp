// Sixten Peterson (AQ9300) 2025-01-24
namespace DA204E_Assignment1_Part1
{
    internal class Pet
    {
        private string name;    // The name of the pet
        private int age;        // The age of the pet
        private bool isFemale;  // The gender of the pet stored as a bool, either true for female or false for male

        /// <summary>
        /// Runs the private methods, reading the user input and printing the object field data in a nicley formatted manner.
        /// </summary>
        public void Start()
        {
            this.ReadInput();
            this.PrintData();
        }

        /// <summary>
        /// Accepts input from the user to gather data about object name, age and gender.
        /// </summary>
        private void ReadInput()
        {
            this.ReadName();
            this.ReadAge();
            this.ReadGender();
        }

        /// <summary>
        /// Asks the user for input on the name of their pet and stores the input in the name field for the object.
        /// </summary>
        private void ReadName()
        {
            Console.Write("What is the name of your pet? ");
            string name = Console.ReadLine();
            this.name = name;
        }

        /// <summary>
        /// Asks the user for input on the age of their pet and stores the input in the age field for the object.
        /// </summary>
        private void ReadAge()
        {
            Console.Write($"What is {this.name}'s age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            this.age = age;
        }

        /// <summary>
        /// Asks the user for input on the gender of their pet and stores the input in the isFemale field for the object.
        /// </summary>
        private void ReadGender()
        {
            Console.Write("Is your pet a female (y/n)? ");
            string isFemale = Console.ReadLine().ToUpper();

            if (isFemale == "Y")
            {
                this.isFemale = true;
            }
            else if (isFemale == "N")
            {
                this.isFemale = false;
            }
        }

        /// <summary>
        /// Prints a summary about the pet based on the data in the fields of the instance.
        /// </summary>
        private void PrintData()
        {
            string divider = "++++++++++++++++++++++++++++++";
            string genderlessGoodPet = this.name + " is a good ";

            Console.WriteLine("\n" + divider);
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Age: {this.age}");

            if (this.isFemale)
            {
                Console.WriteLine(genderlessGoodPet + "girl!");
            }
            else if (!this.isFemale)
            {
                Console.WriteLine(genderlessGoodPet + "boy!");
            }

            Console.WriteLine(divider);
        }
    }
}

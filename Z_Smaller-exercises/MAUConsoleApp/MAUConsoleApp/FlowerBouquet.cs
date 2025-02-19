using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUConsoleApp
{
    internal class FlowerBouquet
    {
        private string name;
        private int numOfStems;
        private double pricePerStem;

        public void ReadInput()
        {
            Console.WriteLine("What is the name of the bouquet?");
            this.name = Console.ReadLine();

            Console.WriteLine("How many stems are there in the bouquet?");
            this.numOfStems = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the price per stem?");
            this.pricePerStem = Double.Parse(Console.ReadLine());
        }

        public double CalculateTotalPrice()
        {
            return this.pricePerStem * Convert.ToDouble(this.numOfStems);
        }

        public void ShowReceipt(double price)
        {
            Console.WriteLine($"*** Receipt for the {this.name.ToUpper()} Bouquet***");
            Console.WriteLine($" Number of stems: {this.numOfStems}");
            Console.WriteLine(" The flower is organic!");
            Console.WriteLine($" The total price is {price}");
        }
    }
}

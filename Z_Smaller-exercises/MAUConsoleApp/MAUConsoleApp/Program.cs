namespace MAUConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlowerBouquet flowerBouquet = new FlowerBouquet();
            flowerBouquet.ReadInput();
            flowerBouquet.ShowReceipt(flowerBouquet.CalculateTotalPrice());
        }
    }
}

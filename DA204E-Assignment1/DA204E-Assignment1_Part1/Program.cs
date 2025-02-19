// Sixten Peterson (AQ9300) 2025-01-26
namespace DA204E_Assignment1_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPress Enter to start the first part (Pet)!");
            Console.ReadLine();

            // Creates an instance of pet and "starts" it. For further details on the implementation head over to Pet.cs.
            Pet pet = new Pet();
            pet.Start();

            // Inform user of the need to press enter to move forward
            Console.WriteLine("\nPress Enter to start the next part (Album)!");
            Console.ReadLine();

            // Creates an instance of album and "starts" it. For further details on the implementation head over to Album.cs.
            Album album = new Album();
            album.Start();

            // Inform user of the need to press enter to move forward
            Console.WriteLine("\nPress Enter to start the next part (TicketSeller)!");

            // Creates an instance of the TickerSeller class and runs the Start() method of the object. For further details on the implementation head over to TicketSeller.cs.
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start();
        }
    }
}

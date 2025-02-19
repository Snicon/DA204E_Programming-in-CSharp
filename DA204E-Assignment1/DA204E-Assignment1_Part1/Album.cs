// Sixten Peterson (AQ9300) 2025-01-24
namespace DA204E_Assignment1_Part1
{
    internal class Album
    {
        private string albumName;   // Name of the album
        private string artistName;  // Name of the artist or band
        private int numOfTracks;    // Amount of tracks

        /// <summary>
        /// Runs the different private methods.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Starting the Album Program!\n");
            this.ReadInput();
            this.PrintData();
        }

        /// <summary>
        /// Reads the input of the user by asking questions and accepting input.
        /// </summary>
        private void ReadInput()
        {
            this.ReadName();
            this.ReadArtistName();
            this.ReadNumOfTracks();
        }

        /// <summary>
        /// Asks for the name of the users favorite musc album and then stores it inside the albumName field for further use.
        /// </summary>
        private void ReadName()
        {
            Console.WriteLine("What is the name of your favourite music album?");
            this.albumName = Console.ReadLine();
        }

        /// <summary>
        /// Asks for the name of artist/band of the users favorite music album and then stores it inside the artistName field for further use.
        /// </summary>
        private void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band for {this.albumName}");
            this.artistName = Console.ReadLine();
        }

        /// <summary>
        /// Asks for the amount of tracks in the users favorite music album and then stores it inside the numOfTracks field for further use.
        /// </summary>
        private void ReadNumOfTracks()
        {
            Console.WriteLine($"How many tracks does {this.albumName} have?");
            this.numOfTracks = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Prints the data stored in the fields of the object and wishes the user a good listening.
        /// </summary>
        private void PrintData()
        {
            Console.WriteLine(); // Intentional white space
            Console.WriteLine($"Album Name: {this.albumName}");
            Console.WriteLine($"Artist/Band: {this.artistName}");
            Console.WriteLine($"Number of Tracks: {this.numOfTracks}");
            Console.WriteLine("Enjoy listening!");
        }
    }
}

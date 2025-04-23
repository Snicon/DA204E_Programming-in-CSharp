// Sixten Peterson (AQ9300) 2025-04-21

namespace DA204E_Assignment5.ContactFiles
{
    /// <summary>
    /// Stores the state of an address, includes: street, city, zip code and country.
    /// </summary>
    public class Address
    {
        // Below are the diffrent address details
        private string street;
        private string city;
        private string zipCode;
        private Countries country;
        
        /// <summary>
        /// Copy constructor, returns a deep copy of the provided object
        /// </summary>
        /// <param name="originalAddress">The original address object to copy</param>
        public Address(Address originalAddress)
        {
            this.street = originalAddress.street;
            this.city = originalAddress.city;
            this.zipCode = originalAddress.zipCode;
            this.country = originalAddress.country;
        }

        /// <summary>
        /// Minimal constructor, chains to the next (three parameter) constructor.
        /// </summary>
        /// <param name="city">The city of the address</param>
        /// <param name="country">The country of the address</param>
        public Address(string city, Countries country) : this(city, country, string.Empty)
        { }

        /// <summary>
        /// Three argument constructor, chains to the final (four parameter) constructor.
        /// </summary>
        /// <param name="city">The city of the address</param>
        /// <param name="country">The country of the address</param>
        /// <param name="street">The street of the address</param>
        public Address(string city, Countries country, string street) : this(city, country, street, string.Empty)
        { }

        /// <summary>
        /// The final constructor, accepting four parameters
        /// </summary>
        /// <param name="city">The city of the address</param>
        /// <param name="country">The country of the address</param>
        /// <param name="street">The street of the address</param>
        /// <param name="zipCode">The zip code of the address</param>
        public Address(string city, Countries country, string street, string zipCode)
        {
            this.city = city;
            this.country = country;
            this.zipCode = zipCode;
            this.street = street;
        }

        /// <summary>
        /// Property for the address street
        /// </summary>
        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }


        /// <summary>
        /// Property for the address city
        /// </summary>
        public string City
        {
            get { return this.city; }
            set
            { 
                if (!String.IsNullOrEmpty(value))
                {
                    this.city = value;
                }
            }
        }

        /// <summary>
        /// Property for the address country
        /// </summary>
        public Countries Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        /// <summary>
        /// Property for the address zip code
        /// </summary>
        public string ZipCode
        {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }

        /// <summary>
        /// Returns a nicley formatted string containing the address information.
        /// </summary>
        /// <returns>the formatted string containing address info</returns>
        public override string ToString()
        {
            string strOut = "\n" + this.street;

            strOut += string.Format("\n{0} {1}", this.zipCode, this.city);
            strOut += string.Format("\n{0}", this.Country);

            return strOut;
        }
    }
}

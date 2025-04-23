// Sixten Peterson (AQ9300) 2025-04-21

namespace DA204E_Assignment5.ContactFiles
{
    /// <summary>
    /// Represents a contact, responsible for storing all contact details.
    /// </summary>
    public class Contact
    {
        private Address address; // The object containing all address details of the contact
        private Email email;     // The object containing all the email details of the contact
        private string firstName;// The first name of the contact
        private string lastName; // The last name of the contact
        private Phone phone;     // The object containing all the phone numbers of the contact

        /// <summary>
        /// Property related to the address field
        /// </summary>
        public Address Address {
            get => this.address; set => this.address = value;
        }

        /// <summary>
        /// Property related to the email field
        /// </summary>
        public Email Email
        {
            get => email; set => email = value;
        }

        /// <summary>
        /// Property related to the firstName field
        /// </summary>
        public string FirstName {
            get => this.firstName;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
            }
        }

        /// <summary>
        /// Property related to the lastName field
        /// </summary>
        public string LastName
        {
            get => this.lastName;
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
            }
        }

        /// <summary>
        /// Property rleated to the phone field
        /// </summary>
        public Phone Phone {
            get => this.phone; set => this.phone = value;
        }

        // Default constructor, does nothing. Results in an empty contact object
        public Contact()
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="contact">The contact to copy</param>
        public Contact(Contact contact)
        {
            this.firstName = contact.FirstName;
            this.lastName = contact.LastName;
            this.phone = new Phone(contact.Phone);
            this.email = new Email(contact.Email);
            this.address = new Address(contact.Address);
        }

        /// <summary>
        /// String representation of the contact, used in listbox. Details a selection of the contact details.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string name = $"{this.lastName.ToUpper()}, {this.firstName}";

            return String.Format("{0,-25} {1,-20} {2,-36}", name, this.phone.Work, this.email.Work);
        }
    }
}

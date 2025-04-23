// Sixten Peterson (AQ9300) 2025-04-21
using DA204E_Assignment5.ContactFiles;

namespace DA204E_Assignment5
{
    /// <summary>
    /// The responsibility of Customer class is to store an instance of contact detailing the contact details of the customer.
    /// </summary>
    public class Customer
    {
        private Contact contact; // The contact instance field, stores all contact details of the customer

        /// <summary>
        /// Contact property, used to get and set the Contact field
        /// </summary>
        public Contact Contact
        {
            get { return this.contact; }
            set { this.contact = value; }
        }

        /// <summary>
        /// Constructor, assigns the provided contact object to the new customer instance.
        /// </summary>
        /// <param name="contact">The contact object to copy</param>
        public Customer(Contact contact)
        {
            this.contact = contact;
        }

        /// <summary>
        /// Returns a string representation of the customer which details some of the contact information. Used in the lissbox in MainForm.
        /// </summary>
        /// <returns>A string consisting of nicley formatted contact details.</returns>
        public override string ToString()
        {
            return contact.ToString();
        }

        /// <summary>
        /// Gets a nicley formatted string of all contact details.
        /// </summary>
        /// <returns>The nicley formatted string</returns>
        public string GetFormattedContactDetails()
        {
            return string.Format("{0} {1} {2}{3}{4}", contact.FirstName, contact.LastName, contact.Address.ToString(), contact.Email.ToString(), contact.Phone.ToString());
        }
    }
}

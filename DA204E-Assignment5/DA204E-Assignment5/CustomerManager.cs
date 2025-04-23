// Sixten Peterson (AQ9300) 2025-04-21
using DA204E_Assignment5.ContactFiles;

namespace DA204E_Assignment5
{
    /// <summary>
    /// Responsible for managing all the customers stored in the application, basically a glorified list of customers with different methods for data setting and fetching.
    /// </summary>
    public class CustomerManager
    {
        private List<Customer> customers = new List<Customer>(); // List of all stored customers
        private int id; // Last assigned id, there is no offset in this application but if there were this would be used more often

        public int LastID
        {
            get { return id; }
        }

        /// <summary>
        /// Adds a customer to the customer manager (in other words, adds a customer to the list) and sets the id to the id matching the newly created customer.
        /// </summary>
        /// <param name="contact">The contact details of the customer</param>
        public void AddCustomer(Contact contact)
        {
            Customer customer = new Customer(contact); // Creating new Customer

            if (customer != null) // Gracefully handling eventual null case, ideally we would never get here to begin with. See this as a fail-safe if the implementation in MainForm is incorrect leading to a null customer.
            {
                customers.Add(customer);                   // Adding the new customer to the List
                this.id = customers.IndexOf(customer);     // Sets the index to match the latest added customer
            }
        }

        /// <summary>
        /// Finds a customer based on id and returns it if found.
        /// </summary>
        /// <param name="id">The id of the customer to find</param>
        /// <returns>The customer if found, null if none found or id was invalid.</returns>
        private Customer FindCustomer(int id)
        {
            Customer customer = null;

            if (id >= 0 && id < customers.Count) // Id is valid
            {
                customer = customers[id];
            }

            return customer;
        }

        /// <summary>
        /// Gets a copy of the contact object from the selected customer
        /// </summary>
        /// <param name="id">The id of the customer</param>
        /// <returns>The contact object copy</returns>
        public Contact GetContact(int id)
        {
            Customer customer = FindCustomer(id);
            Contact contact = null;

            if (customer != null)
            {
                contact = new Contact(customer.Contact); // Making a copy to avoid editing via reference
            }

            return contact;
        }

        /// <summary>
        /// Deletes the customer matching the id if found.
        /// </summary>
        /// <param name="id">The id of the customer</param>
        /// <returns>True if successful, false if unsuccessful.</returns>
        public bool DeleteCustomer(int id)
        {
            Customer customer = FindCustomer(id); // Finding the customer

            if (customer != null) // If customer was found
            {
                customers.Remove(customer); // Removing customer from the list
                return true; // Customer deleted
            }

            return false; // Customer was not deleted since the customer could not be found.
        }

        /// <summary>
        /// Edits the customer contact details
        /// </summary>
        /// <param name="id">The id of the customer to edit</param>
        /// <param name="contact">The new contact details to replace the old one with</param>
        /// <returns></returns>
        public bool EditCustomer(int id, Contact contact)
        {
            Customer customer = FindCustomer(id);

            if (customer != null && contact != null)
            {
                customers[id].Contact = contact; // Updating the contact object
                return true; // Successful
            }

            return false; // Unsuccessful
        }

        /// <summary>
        /// Returns a string containing the required details displaying the customer information in the listbox in MainForm.
        /// </summary>
        /// <param name="id">The id of the customer</param>
        /// <returns>The string</returns>
        public string GetCustomerListFormattedString(int id)
        {
            Customer customer = FindCustomer(id); // Finding the customer

            if (customer != null) // If customer was found
            {
                return string.Format("{0,-3} {1}", id, customer.ToString()); // Return formatted string
            }

            return "Error finding customer..."; // Didn't find a customer, returns a suitible string to indicate the error.
        }

        /// <summary>
        /// Gets the the contact details of a customer as a nicley formatted string if there is one selected.
        /// </summary>
        /// <param name="id">The id of the customer</param>
        /// <returns>A string containing the contact details, or a descriptive message about no customer being selected if none was selected.</returns>
        public string GetCustomerContactDetailsString(int id)
        {
            // TODO: Adapt to match the rquriements in page 1 of assignment requirements

            Customer customer = FindCustomer(id); // Finding the customer

            if (customer != null) // Customer was found
            {
                return customer.GetFormattedContactDetails(); // Returning formatted string
            }

            return "No customer selected, please select one in the menu to the left."; // No customer selected
        }
    }
}

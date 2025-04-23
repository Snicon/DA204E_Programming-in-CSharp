// Sixten Peterson (AQ9300) 2025-04-21
using DA204E_Assignment5.ContactFiles;

namespace DA204E_Assignment5
{
    /// <summary>
    /// The main form/window of the appplication. Used for managing customers which then opens ContactForm, deltes a customer or display another customer.
    /// </summary>
    public partial class MainForm : Form
    {

        private CustomerManager customerManager = new CustomerManager(); // Field containing an instance of customerManager.

        /// <summary>
        /// Default constructor, initializes all the componenets.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the creation of new customers by opening the contact form and saving the new customer if confirmed by the user upon pressing OK in the ContactForm.
        /// </summary>
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm(); // New instance of contact form.
            contactForm.Text = "Create a new customer";  // Sets a descriptive title for the form/window.

            if (contactForm.ShowDialog() == DialogResult.OK) // If the form was not cancelled
            {
                if (contactForm.Contact != null) // Makes sure the contact isn't null, just in case.
                {
                    customerManager.AddCustomer(contactForm.Contact); // Adding the new customer.

                    lstCustomerRegistry.Items.Add(customerManager.GetCustomerListFormattedString(customerManager.LastID)); // Adding the customer to the listbox.
                    lstCustomerRegistry.SelectedIndex = customerManager.LastID; // Selecting the new customer which makes all the contact details appear instantly open the ContactForm being closed.
                }
            }
        }

        /// <summary>
        /// Small helper method for determining the currently selected index of the listbox.
        /// </summary>
        /// <returns>Either -1 upon failing to find a valid customer selection or the id of the customer if successfully found.</returns>
        private int GetSelectedCustomer()
        {
            int selectedIndex = lstCustomerRegistry.SelectedIndex;

            if (selectedIndex >= 0) // A valid index has been selected
            {
                return selectedIndex; // Return valid selected index
            }

            return -1; // Indicating error
        }

        /// <summary>
        /// Deletes the currently seleceted customer.
        /// </summary>
        private void DeleteContact()
        {
            int selectedIndex = GetSelectedCustomer();

            if (customerManager.DeleteCustomer(selectedIndex)) // If deletion succeeds
            {
                lstCustomerRegistry.Items.RemoveAt(selectedIndex); // Remove from listbox
            }
            else
            {
                ValidationUtility.WarnUser("Failed to delete customer, are you sure you have selected a customer?"); // Pops up when a user was not selected or an id that does not exist in the List in customer manager
            }
        }

        /// <summary>
        /// Edits the selected customer by opening the ContactForm while providing the existing data for prefill. Then stores the edited version if accepted by the user.
        /// </summary>
        private void EditContact()
        {
            int customerIndex = GetSelectedCustomer(); // Determining the index of the customer

            if (customerIndex != -1)
            {
                Contact contact = customerManager.GetContact(customerIndex); // Gets the contact object form the customer for easier edit

                ContactForm contactForm = new ContactForm(contact); // Opening a prefilled ContactForm with all already existing data.
                contactForm.Text = "Editing " + contact.FirstName + " " + contact.LastName;

                if (contactForm.ShowDialog() == DialogResult.OK) // Form was not cancelled
                {
                    if (contactForm.Contact != null) // Makes sure contact isn't null, just in case
                    {
                        customerManager.EditCustomer(customerIndex, contactForm.Contact); // Updates the customer.

                        lstCustomerRegistry.Items[customerIndex] = customerManager.GetCustomerListFormattedString(customerIndex); // Updating the text in the listbox
                        lstCustomerRegistry.SelectedIndex = customerIndex; // Making sure the edited customer is the selected customer
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for when the user presses the add button, calls the AddContact method to add a new customer
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddContact();
        }

        /// <summary>
        /// Event handler for when the user presses the delete button, calls the DeleteContact method to delete the selected customer
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteContact();
        }

        /// <summary>
        /// Event handler for when the user presses the add button, calls the EditContact method to edit the selected customer
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.EditContact();
        }

        /// <summary>
        /// Event handler for when the slection changes in the customer registry listbox
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void lstCustomerRegistry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedCustomer();

            rtxtContactDetails.Text = customerManager.GetCustomerContactDetailsString(selectedIndex);
        }
    }
}

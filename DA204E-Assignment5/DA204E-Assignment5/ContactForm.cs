// Sixten Peterson (AQ9300) 2025-04-22
using DA204E_Assignment5.ContactFiles;

namespace DA204E_Assignment5
{
    /// <summary>
    /// The ContactForm, used for adding and editing customers. Opens the form prefilled with data if a contact is provided to the constructor, empty if none was provided.
    /// </summary>
    public partial class ContactForm : Form
    {
        private Contact contact; // The contact object that is being added/edited

        /// <summary>
        /// Contact property, allows for setting and getting the contact object
        /// </summary>
        public Contact Contact
        {
            get { return this.contact; }
            set { this.contact = value; }
        }

        /// <summary>
        /// Default constructor, initializes the GUI
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            InitGUI();
        }

        /// <summary>
        /// One argument constructor, chained to the default one. In short this constructor is used for prefilling the form when editing.
        /// </summary>
        /// <param name="contact">The contact oject storing contact details to prefill the form with.</param>
        public ContactForm(Contact contact) : this()
        {
            this.contact = contact;
            this.PreFillForm();
        }

        /// <summary>
        /// Custom init helper method, creates a new contact and pupulates the country combo box.
        /// </summary>
        private void InitGUI()
        {
            contact = new Contact();
            this.PopulateCountry();
        }

        /// <summary>
        /// Prefills the form with all the stored contact infromation, used to improve UX when editing.
        /// </summary>
        private void PreFillForm()
        {
            txtFirstName.Text = this.contact.FirstName;
            txtLastName.Text = this.contact.LastName;
            txtHomePhone.Text = this.contact.Phone.Personal;
            txtCellPhone.Text = this.contact.Phone.Work;
            txtEmailBusiness.Text = this.contact.Email.Work;
            txtEmailPrivate.Text = this.contact.Email.Personal;
            txtStreet.Text = this.contact.Address.Street;
            txtCity.Text = this.contact.Address.City;
            txtZipCode.Text = this.contact.Address.ZipCode;
            cmbCountry.SelectedIndex = (int) this.contact.Address.Country;
        }

        /// <summary>
        /// Helper method responsible for populating the combobox with countries.
        /// </summary>
        private void PopulateCountry()
        {
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries))); // Adding all the countries to the cmb box
            cmbCountry.SelectedIndex = (int) Countries.Sverige;          // Setting default value to Sverige
        }

        /// <summary>
        /// Reads and validates the first name
        /// </summary>
        /// <returns>True if valid, false if invalid</returns>
        private bool ReadFirstName()
        {
            string name = txtFirstName.Text.Trim();
            
            if (String.IsNullOrEmpty(name))
            {
                ValidationUtility.WarnUser("You must input a first name.");
                return false;
            }

            this.contact.FirstName = name;
            return true;
        }

        /// <summary>
        /// Reads and validates the last name
        /// </summary>
        /// <returns>True if valid, false if invalid</returns>
        private bool ReadLastName()
        {
            string name = txtLastName.Text.Trim();

            if (String.IsNullOrEmpty(name))
            {
                ValidationUtility.WarnUser("You must input a last name.");
                return false;
            }

            this.contact.LastName = name;
            return true;
        }

        /// <summary>
        /// Calls the methods for reading first and last name
        /// </summary>
        /// <returns>True if both names are valid, false if they are invalid</returns>
        private bool ReadNames()
        {
            bool hasFirstName = this.ReadFirstName();
            bool hasLastName = this.ReadLastName();

            return hasFirstName && hasLastName;
        }

        /// <summary>
        /// Reads the phone numbers from the textboxes, then creates and assigns a phone object to the contact instance field.
        /// </summary>
        private void ReadPhone()
        {
            string homePrivatePhone = txtHomePhone.Text.Trim();
            string cellOfficePhone = txtCellPhone.Text.Trim();

            Phone phone = new Phone(cellOfficePhone, homePrivatePhone);
            this.contact.Phone = phone;
        }

        /// <summary>
        /// Reads the email addresses from the textboxes, then creates and assigns an email object to the contact instance field
        /// </summary>
        private void ReadEmail()
        {
            // Getting the textbox text below
            string emailPrivate = txtEmailPrivate.Text.Trim();
            string emailBusiness = txtEmailBusiness.Text.Trim();

            // variables storing a boolean representing if the email is null or not
            bool hasEmailPrivate = !string.IsNullOrEmpty(emailPrivate);
            bool hasEmailBusiness = !string.IsNullOrEmpty(emailBusiness);

            Email email = new Email();

            if (hasEmailBusiness && !hasEmailPrivate)
            {
                email = new Email(emailBusiness);
            } else if (hasEmailBusiness && hasEmailPrivate)
            {
                email = new Email(emailBusiness, emailPrivate);
            }

            this.contact.Email = email;
        }

        /// <summary>
        /// Reads and validates the address details, then stores them in the contact object if valid.
        /// </summary>
        /// <returns>True if successful, flase if unsuccessful.</returns>
        private bool ReadAddressDetails()
        {
            // Getting all values from the win forms components below
            string street = txtStreet.Text.Trim();
            string city = txtCity.Text.Trim();
            string zipCode = txtZipCode.Text.Trim();
            Countries country = (Countries) cmbCountry.SelectedIndex;

            bool hasStreet = !string.IsNullOrEmpty(street);
            bool hasCity = !string.IsNullOrEmpty(city);
            bool hasZipCode = !string.IsNullOrEmpty(zipCode);

            Address address = null;

            if (hasCity && !hasStreet && !hasZipCode)
            {
                address = new Address(city, country);
            } else if (hasCity && hasStreet && !hasZipCode)
            {
                address = new Address(city, country, street);
            } else if (hasCity && (hasStreet || !hasStreet) && (hasZipCode || !hasZipCode)) // Neither street nor zip code is strictly required, doing it this way utilizes all constructors that are forced upon me by the assignment requirements while still allowing for as much user freedom as possible.
            {
                address = new Address(city, country, street, zipCode);
            }

            if (address == null) // No address provided (or not enough address information was inputted)
            {
                ValidationUtility.WarnUser("The address provided was incomplete. Unfortunately a city and country is required to add a customer.");
                return false;
            } else
            {
                this.contact.Address = address;
                return true;
            }
        }

        /// <summary>
        /// Handles all logic for when the OK button is pressed, which includes reading all textboxes. If the textboxes passes validation the DialogResult is closed.
        /// </summary>
        private void HandleOK()
        {
            bool names = this.ReadNames();
            this.ReadPhone();
            this.ReadEmail();
            bool address = this.ReadAddressDetails();

            if (names && address)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Event handler for when the user presses the OK button in the form.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.HandleOK();
        }

        /// <summary>
        /// Event handler for when the user presses the cancel button in the form. Confirms if the user really want to cancel or not.
        /// </summary>
        /// <param name="sender">The source of the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = ValidationUtility.AskUser("Confirm cancellation", "Are you sure you want to cancel? All data will be lost.");

            if (result == DialogResult.No) // The user decided not to cancel
            {
                this.DialogResult = DialogResult.None; // Stop the cancellation by setting DialogResult to DialogResult.None
            }

        }
    }
}

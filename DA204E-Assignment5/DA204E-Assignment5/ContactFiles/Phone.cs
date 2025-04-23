// Sixten Peterson (AQ9300) 2025-04-21, heavily inspired by the Email.cs code file form Canvas written by Farid Naisan.
namespace DA204E_Assignment5.ContactFiles
{
    /// <summary>
    /// The phone class represents the phone number contact details that is a part of the contact class.
    /// </summary>
    public class Phone
    {
        private string personalPhone;
        private string officePhone;

        /// <summary>
        /// Two parameter constructor, accepting work and personal phone numbers
        /// </summary>
        /// <param name="workPhone">The work phone number</param>
        /// <param name="personalPhone">The personal phone number</param>
        public Phone(string workPhone, string personalPhone)
        {
            this.personalPhone = personalPhone;
            this.officePhone = workPhone;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="phone">The phone object to copy</param>
        public Phone(Phone phone)
        {
            this.personalPhone = phone.personalPhone;
            this.officePhone = phone.officePhone;
        }

        /// <summary>
        /// Property for the personal phone number
        /// </summary>
        public string Personal
        {
            get { return this.personalPhone; }
            set { this.personalPhone = value; }
        }

        /// <summary>
        /// Property for the business phone number
        /// </summary>
        public string Work
        {
            get { return this.officePhone; }
            set { this.officePhone = value; }
        }

        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  Make sure that a font like "Courier New" is used in
        /// the control displaying this information.
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        public override string ToString()
        {
            string strOut = "\n" + "Phone numbers" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", personalPhone);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", officePhone);

            return strOut;
        }
    }
}

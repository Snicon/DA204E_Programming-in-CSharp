// Sixten Peterson (AQ9300) 2025-04-21, copied from Email.cs code file from Canvas written by Farid Naisan. Some minor changes and deletions have been made.
namespace DA204E_Assignment5.ContactFiles
{
    /// <summary>
    /// This class handles the state of eamil addresses. Storing a private and business e-mail address. Typically related to an instance of Contact. (Copied from Canvas)
    /// </summary>
    public class Email
    {
        //private email
        private string personalMail;
        //officeMail mail
        private string officeMail;

        //Constructors are overloaded and called in a chain

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        /// <remarks></remarks>
        public Email()
        {
        }

        // Copy constructor
        public Email(Email email)
        {
            this.personalMail = email.personalMail;
            this.officeMail = email.officeMail;
        }


        /// <summary>
        /// Constructor with one parameter - calls the constructor with 
        /// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="workMail">input coming from the client object</param>
        public Email(string workMail) : this(workMail, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="workMail">Input - office mail</param>
        /// <param name="personalMail">Input - private mail</param>
        public Email(string workMail, string personalMail)
        {
            officeMail = workMail;
            this.personalMail = personalMail;
        }

        /// <summary>
        /// Property related to the field m_Personal
        /// Both read and write access
        /// </summary>
        public string Personal
        {
            //private mail
            get { return personalMail; }

            set { personalMail = value; }
        }


        /// <summary>
        /// Property related to officeMail field
        /// Both read and write access
        /// </summary>
        public string Work
        {
            get { return officeMail; }

            set { officeMail = value; }
        }

        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  Make sure that a font like "Courier New" is used in
        /// the control displaying this information.
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        public override string ToString()
        {
            string strOut = "\n" + "Emails" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", personalMail);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", officeMail);

            return strOut;
        }
    }
}

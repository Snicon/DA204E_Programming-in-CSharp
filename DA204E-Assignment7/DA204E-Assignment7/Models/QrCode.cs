// Sixten Peterson (AQ9300) 2025-05-26
namespace DA204E_Assignment7.Models
{
    /// <summary>
    /// Model representing a QrCode, it holds name, content, dateTime and filePath
    /// </summary>
    public class QrCode
    {
        // Fields below
        private string name; // Name of the qr code
        private string content; // The content of the qr code (usually a url)
        private DateTime dateTime; // The dateTime of creation
        private string filePath; // The filepath of the qr code image that was generated

        /// <summary>
        /// Simple constructor that accepts and sets all the fields upon creation of the object
        /// </summary>
        /// <param name="name">Name of the qr code (used in file path)</param>
        /// <param name="content">The content of the qr code</param>
        /// <param name="dateTime">The date time of creation</param>
        /// <param name="filePath">The file path of the generated qr code</param>
        public QrCode(string name, string content, DateTime dateTime, string filePath)
        {
            this.name = name;
            this.content = content;
            this.dateTime = dateTime;
            this.filePath = filePath;
        }

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Content property
        /// </summary>
        public string Content
        {
            get { return content; }
        }

        /// <summary>
        /// Datetime roperty
        /// </summary>
        public DateTime DateTime
        {
            get { return dateTime; }
        }

        /// <summary>
        /// File path property
        /// </summary>
        public string FilePath
        {
            get { return filePath; }
        }
    }
}

// Sixten Peterson (AQ9300) 2025-05-26
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows;
using DA204E_Assignment7.Commands;
using DA204E_Assignment7.Models;
using QRCoder;

namespace DA204E_Assignment7.ViewModels
{
    /// <summary>
    /// ViewModel for the QrCode view, implements Notifier for easier notification of required UI updates. The class houses logic for qr code generation and opening the folder containing all the qr codes
    /// </summary>
    public class QrCodeViewModel : Notifier
    {
        // fields below
        private ICustomCommand generateQrCodeCommand;
        private ICustomCommand openQrCodeFolderCommand;

        private string name; // Used for the name input in the form
        private string content; // Used for the content input in the form
        private ObservableCollection<QrCode> qrCodes; // Basically a kind of list that notifies on change, used to store all qr codes

        private const int QRCodeGraphicSize = 20;

        /// <summary>
        /// Simple constructor, makes a new ObservableCollection and sets it to the qrCodes field. Also "Registers" all commands for use in the class.
        /// </summary>
        public QrCodeViewModel()
        {
            QrCodes = new ObservableCollection<QrCode>();

            // "Registering" commands below
            generateQrCodeCommand = new GenerateQrCodeCommand(this);
            openQrCodeFolderCommand = new OpenQrCodeFolderCommand(this);

            // Subscribe to the CollectionChanged event to update if the command can be executed
            QrCodes.CollectionChanged += (s, e) => OpenQrCodeFolderCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Property for generateQrCodeCommand field
        /// </summary>
        public ICustomCommand GenerateQrCodeCommand
        {
            get { return generateQrCodeCommand; }
        }

        /// <summary>
        /// Property for openQrCodeCommand field
        /// </summary>
        public ICustomCommand OpenQrCodeFolderCommand
        {
            get { return  openQrCodeFolderCommand; }
        }

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value; // Setting the name
                OnPropertyChanged("Name"); // Notifying UI of change
                GenerateQrCodeCommand.RaiseCanExecuteChanged(); // Checking if the command can be executed or not
            }
        }

        /// <summary>
        /// Content property
        /// </summary>
        public string Content
        {
            get { return content; }
            set
            {
                content = value; // Setting the content
                OnPropertyChanged("Content"); // Notiying UI of change
                GenerateQrCodeCommand.RaiseCanExecuteChanged(); // Checking if the command can be executed or not
            }
        }

        /// <summary>
        /// QrCodes property
        /// </summary>
        public ObservableCollection<QrCode> QrCodes
        {
            get { return qrCodes; }
            set
            {
                qrCodes = value; // Setting qrCodes field
                OnPropertyChanged("QrCodes"); // Notifying UI of change
            }
        }

        /// <summary>
        /// Generates a qr code if valid input has been provided by the user. Also stores a QrCode object in the qrCodes field
        /// </summary>
        public void GenerateQrCode()
        {
            // Can't generate a QR code without giving it a name and a content.
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Content))
            {
                return; // No point in running the rest of the code
            }

            DateTime dateTime = DateTime.Now; // Getting the current dateTime
            QrCode qrCode = new QrCode(name, content, dateTime, GenerateQrCodeImage(dateTime)); // Making a QrCode (from Model) object consisting of name, content, dateTime and the file path

            qrCodes.Add(qrCode); // Adding the qr code to the collection
            Name = string.Empty; // Clearing the name
            Content = string.Empty; // Clearing the content
        }

        /// <summary>
        /// Generates the qr code image using the QRCoder NuGet package
        /// </summary>
        /// <param name="dateTime">Datetime used to give a unique-"ish" name if a user inputs the same name twice</param>
        /// <returns>The file path to the qr code image</returns>
        private string GenerateQrCodeImage(DateTime dateTime)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator(); // Making a new instance of the QrCodeGenerator
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Content, QRCodeGenerator.ECCLevel.Q); // Making a new instance of qrCodeData using the content and the level of qr code

            QRCode qrCode = new QRCode(qrCodeData); // Making a new QRCode object (from the package) using the qrCodeData created on the previous line.
            Bitmap bitmap = qrCode.GetGraphic(QRCodeGraphicSize); // Making a bitmap of the qrCode that was created earlier

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "qr_codes"); // The path ot the folder where qr code images will be stored.

            if(!Directory.Exists(folderPath)) // If the directory/folder doesn't exist we want to create it.
            {
                Directory.CreateDirectory(folderPath); // Creating the folder if it doesnt already exist
            }

            string filePath = Path.Combine(folderPath, $"{Name}_{dateTime:yyyy-MM-dd_HH-mm}.png"); // The path to the file we want to store the bitmap as
            bitmap.Save(filePath); // Saving the bitmap as a png based on the filepath form the line above.

            return filePath; // Returning the filepath to the generated qr code
        }

        /// <summary>
        /// Opens the folder containing all the qr codes
        /// </summary>
        public void OpenQrCodeFolder()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "qr_codes"); // The folder path to the folder containing all the qr codes

            try
            {
                System.Diagnostics.Process.Start("explorer.exe", folderPath); // Starts the file explorer and opens the specified folder. Shoutout to my search motor for pulling through on this.
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An error occurred while trying to open the folder: {exception.Message}"); // Catching any exception that may occur
            }
        }
    }
}

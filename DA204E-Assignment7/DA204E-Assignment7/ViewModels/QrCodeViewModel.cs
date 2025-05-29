using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Input;
using DA204E_Assignment7.Commands;
using DA204E_Assignment7.Models;
using QRCoder;

namespace DA204E_Assignment7.ViewModels
{
    public class QrCodeViewModel : Notifier
    {
        private string name;
        private string content;
        private ObservableCollection<QrCode> qrCodes { get; set; } // TODO: make private with properties?
        // 

        public QrCodeViewModel()
        {
            QrCodes = new ObservableCollection<QrCode>();
            GenerateQrCodeCommand = new GenerateQrCodeCommand(this);
            OpenQrCodeFolderCommand = new OpenQrCodeFolderCommand(this);

            // Subscribe to the CollectionChanged event to update command state
            QrCodes.CollectionChanged += (s, e) => OpenQrCodeFolderCommand.RaiseCanExecuteChanged();
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
                GenerateQrCodeCommand.RaiseCanExecuteChanged();
            }
        }

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("Content");
                GenerateQrCodeCommand.RaiseCanExecuteChanged();
            }
        }

        public ObservableCollection<QrCode> QrCodes
        {
            get { return qrCodes; }
            set
            {
                qrCodes = value;
                OnPropertyChanged("QrCodes");
            }
        }

        public GenerateQrCodeCommand GenerateQrCodeCommand { get; }
        public OpenQrCodeFolderCommand OpenQrCodeFolderCommand { get; }

        public void GenerateQrCode()
        {
            // Can't generate a QR code without giving it a name and a content.
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Content))
            {
                return;
            }

            DateTime dateTime = DateTime.Now;
            QrCode qrCode = new QrCode(name, content, dateTime, GenerateQrCodeImage(dateTime));

            qrCodes.Add(qrCode);
            Name = string.Empty;
            Content = string.Empty;
        }

        private string GenerateQrCodeImage(DateTime dateTime)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Content, QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap bitmap = qrCode.GetGraphic(20);

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "qr_codes"); // TODO: Move to constant

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); // Creating the folder if it doesnt already exist
            }

            string filePath = Path.Combine(folderPath, $"{Name}_{dateTime:yyyy-MM-dd_HH-mm}.png"); // TODO: Move to constant
            bitmap.Save(filePath);

            return filePath;
        }

        public void OpenQrCodeFolder()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "qr_codes"); // TODO: Move to constant
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to open the folder: {ex.Message}");
            }
        }
    }
}

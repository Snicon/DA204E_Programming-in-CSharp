// Sixten Peterson (AQ9300) 2025-05-26
using System.Windows.Input;
using DA204E_Assignment7.Commands;
using DA204E_Assignment7.Commands.Navigation;

namespace DA204E_Assignment7.ViewModels
{
    /// <summary>
    /// Main Window ViewModel, implements Notifier like all other viewmodels. The main logic handled in here is navigation between different pages (views).
    /// </summary>
    class MainWindowViewModel : Notifier
    {
        private Uri source; // The source that will be used for the Frame inside the xaml of the MainWindow

        private ICommand navigateScaleCommand;
        private ICommand navigateQrCodeCommand;

        /// <summary>
        /// Simple constructor, sets a default source of ScaleView, also "registers" commands
        /// </summary>
        public MainWindowViewModel()
        {
            source = new Uri("ScaleView.xaml", UriKind.Relative); // Setting default source

            // "Registering" commands below
            navigateScaleCommand = new NavigateScaleCommand(this);
            navigateQrCodeCommand = new NavigateQrCodeCommand(this);
        }

        // Command properties below, these are used in the view
        public ICommand NavigateScaleCommand { get { return navigateScaleCommand; } }
        public ICommand NavigateQrCodeCommand { get { return navigateQrCodeCommand; } }

        // Property for the source field
        public Uri Source
        {
            get { return source; }
            set
            {
                this.source = value; // Setting the field
                OnPropertyChanged("Source"); // Notifying the UI of the change
            }
        }

        /// <summary>
        /// Changes the source to the ScaleView
        /// </summary>
        public void NavigateScale()
        {
            Source = new Uri("ScaleView.xaml", UriKind.Relative);
        }

        /// <summary>
        /// Changes the source to the QrCodeView
        /// </summary>
        public void NavigateQrCode()
        {
            Source = new Uri("QrCodeView.xaml", UriKind.Relative);
        }
    }
}

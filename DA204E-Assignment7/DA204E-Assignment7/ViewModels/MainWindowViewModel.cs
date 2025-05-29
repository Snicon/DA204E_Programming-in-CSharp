using System.Windows;
using System.Windows.Input;
using DA204E_Assignment7.Commands;
using DA204E_Assignment7.Commands.Navigation;

namespace DA204E_Assignment7.ViewModels
{
    class MainWindowViewModel : Notifier
    {
        private Uri source;

        public MainWindowViewModel()
        {
            source = new Uri("ScaleView.xaml", UriKind.Relative);

            NavigateScaleCommand = new NavigateScaleCommand(this);
            NavigateQrCodeCommand = new NavigateQrCodeCommand(this);
        }

        public ICommand NavigateScaleCommand { get; }
        public ICommand NavigateQrCodeCommand { get; }

        public Uri Source
        {
            get { return source; }
            set
            {
                this.source = value;
                OnPropertyChanged("Source");
            }
        }

        public void NavigateScale()
        {
            Source = new Uri("ScaleView.xaml", UriKind.Relative);
        }

        public void NavigateQrCode()
        {
            Source = new Uri("QrCodeView.xaml", UriKind.Relative);
        }
    }
}

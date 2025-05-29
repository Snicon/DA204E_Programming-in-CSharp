using System.Windows.Controls;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Views
{
    /// <summary>
    /// Interaction logic for QrCodeView.xaml
    /// </summary>
    public partial class QrCodeView : Page
    {
        public QrCodeView()
        {
            InitializeComponent();
            this.DataContext = new QrCodeViewModel(); // Making new instance of the ViewModel per instructions on page 139
        }
    }
}

// Sixten Peterson (AQ9300) 2025-05-26
using System.Windows.Controls;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Views
{
    /// <summary>
    /// Interaction logic for QrCodeView.xaml, nothing much. Just setting the DataContext to let the ViewModel do its thing
    /// </summary>
    public partial class QrCodeView : Page
    {
        /// <summary>
        /// Simple constructor
        /// </summary>
        public QrCodeView()
        {
            InitializeComponent(); // Default behaviour, init components
            this.DataContext = new QrCodeViewModel(); // Making new instance of the ViewModel per instructions on page 139 in my book
        }
    }
}

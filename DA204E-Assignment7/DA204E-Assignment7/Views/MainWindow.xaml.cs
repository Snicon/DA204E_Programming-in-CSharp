// Sixten Peterson (AQ9300) 2025-05-26
using System.Windows;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml, nothing special. Just setting the DataContext to let the ViewModel do its thing.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Simple constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent(); // Default behaviour, init components
            this.DataContext = new MainWindowViewModel(); // Setting the DataContext of the view to a new instance of the MainWindow ViewModel
        }
    }
}
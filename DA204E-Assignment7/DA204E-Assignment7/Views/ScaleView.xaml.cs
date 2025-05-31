// Sixten Peterson (AQ9300) 2025-05-26
using System.Windows.Controls;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Views
{
    /// <summary>
    /// Interaction logic for ScaleView.xaml, in this case not used for much except for setting the DataContext to a new instance of ScaleViewModel where all the intereseting stuff happens.
    /// </summary>
    public partial class ScaleView : Page
    {
        /// <summary>
        /// Simple constructor
        /// </summary>
        public ScaleView()
        {
            InitializeComponent(); // Default behaviour, just initializing all the components in the view
            this.DataContext = new ScaleViewModel(); // Setting the DataContext to a new instance of ScleViewModel where all the "magic" happens.
        }
    }
}

using System.Windows.Controls;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Views
{
    /// <summary>
    /// Interaction logic for ScaleView.xaml
    /// </summary>
    public partial class ScaleView : Page
    {
        public ScaleView()
        {
            InitializeComponent();
            this.DataContext = new ScaleViewModel();
        }
    }
}

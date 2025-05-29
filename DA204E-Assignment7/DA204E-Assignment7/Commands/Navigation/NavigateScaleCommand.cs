using System.Windows.Input;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Commands
{
    class NavigateScaleCommand : ICommand
    {
        private readonly MainWindowViewModel viewModel;

        public NavigateScaleCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            viewModel.NavigateScale();
        }
    }
}

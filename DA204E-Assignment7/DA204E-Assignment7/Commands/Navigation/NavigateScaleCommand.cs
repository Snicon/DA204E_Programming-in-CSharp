// Sixten Peterson (AQ9300) 2025-05-26
using System.Windows.Input;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Commands
{
    /// <summary>
    /// Comand for navigating to the scale page
    /// </summary>
    class NavigateScaleCommand : ICommand
    {
        private MainWindowViewModel viewModel; // The view model used by the command

        /// <summary>
        /// Simple constructor used for setting the viewmodel
        /// </summary>
        /// <param name="viewModel">The viewmodel used by the command</param>
        public NavigateScaleCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Checks if the command can be executed (it can always be exectuded, hence the return true)
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>True, always.</returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the NavigateScale method in the viewmodel
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            viewModel.NavigateScale();
        }
    }
}

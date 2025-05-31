// Sixten Peterson (AQ9300) 2025-05-26
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Commands
{
    /// <summary>
    /// Command for generating a qr code
    /// </summary>
    public class GenerateQrCodeCommand : ICustomCommand // Implements the custom command interface
    {
        private QrCodeViewModel viewModel;

        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="viewModel">The viewmodel for the command</param>
        public GenerateQrCodeCommand(QrCodeViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Checks if the command can be executed based on the following conditions: 1) Name is not null or white space 2) Content is not null or white space
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>True if allowed to execute, false if not.</returns>
        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrWhiteSpace(viewModel.Name) && !string.IsNullOrWhiteSpace(viewModel.Content);
        }

        /// <summary>
        /// Calls the GenerateQrCode method in the viewmodel when executed
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            viewModel.GenerateQrCode();
        }

        /// <summary>
        /// Causes a new check of if the command can be executed
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

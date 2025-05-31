// Sixten Peterson (AQ9300) 2025-05-26
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Commands
{
    /// <summary>
    /// Command for opening the qr code folder, can only be executed if the 
    /// </summary>
    public class OpenQrCodeFolderCommand : ICustomCommand // Implementing the CustomCommand interface that ensures that there is a RaiseCanExecuteChanged method
    {
        private QrCodeViewModel viewModel; // Field consisting of the viewmodel

        /// <summary>
        /// Simple constructor, just sets the viewmodel
        /// </summary>
        /// <param name="viewModel">The viewmodel used for the command</param>
        public OpenQrCodeFolderCommand(QrCodeViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Checks if the command can be executed based on the following condition: There are at least 1 qr codes in the list of qr codes in the viewmodel
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>True if allowed to execute, false if not.</returns>
        public bool CanExecute(object parameter)
        {
            return viewModel.QrCodes.Count > 0; // No need to open the folder if there are no qr codes
        }

        /// <summary>
        /// Calls the OpenQrCodeFolder method in the viewmodel when executed
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            viewModel.OpenQrCodeFolder();
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

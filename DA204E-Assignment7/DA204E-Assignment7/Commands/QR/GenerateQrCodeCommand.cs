using System.Windows.Input;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Commands
{
    public class GenerateQrCodeCommand : ICommand
    {
        private readonly QrCodeViewModel viewModel;

        public GenerateQrCodeCommand(QrCodeViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrWhiteSpace(viewModel.Name) && !string.IsNullOrWhiteSpace(viewModel.Content);
        }

        public void Execute(object parameter)
        {
            viewModel.GenerateQrCode();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DA204E_Assignment7.ViewModels;

namespace DA204E_Assignment7.Commands
{
    public class OpenQrCodeFolderCommand : ICommand
    {
        private readonly QrCodeViewModel viewModel;

        public OpenQrCodeFolderCommand(QrCodeViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return viewModel.QrCodes.Count > 0; // No need to open the folder if there are no qr codes
        }

        public void Execute(object parameter)
        {
            viewModel.OpenQrCodeFolder();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

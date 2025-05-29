using System.Windows.Input;

namespace DA204E_Assignment7.Commands
{
    interface ICustomCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}

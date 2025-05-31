// Sixten Peterson (AQ9300) 2025-05-26
using System.Windows.Input;

namespace DA204E_Assignment7.Commands
{
    /// <summary>
    /// Very simple interface, builds upon the ICommand interface but adds the RaiseCanExecuteExchanged command
    /// </summary>
    public interface ICustomCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}

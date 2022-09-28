using System.Windows.Input;

namespace RelayCommandInDataTemplate.Interfaces
{
    public interface ISimpleCommand
    {
        ICommand Command { get; }
    }
}
using System.Windows.Input;
using RelayCommandInDataTemplate.Interfaces;

namespace RelayCommandInDataTemplate.ViewModels
{
  public abstract class SimpleCommandViewModelBase : ISimpleCommand
    {
        public ICommand Command { get; init; }

        public string Name => GetType().Name;
    }
}

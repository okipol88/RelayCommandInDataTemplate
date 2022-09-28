using RelayCommandInDataTemplate.Helpers;

namespace RelayCommandInDataTemplate.ViewModels
{

  public class CustomSimpleCommandViewModelBase: SimpleCommandViewModelBase
  {
    public CustomSimpleCommandViewModelBase()
    {
      Command = new SimpleRelayCommand<bool>(Execute, CanExecute);
    }

    private void Execute(bool obj)
    {
    }

    private bool CanExecute(bool arg)
    {
      return true;
    }
  }
}

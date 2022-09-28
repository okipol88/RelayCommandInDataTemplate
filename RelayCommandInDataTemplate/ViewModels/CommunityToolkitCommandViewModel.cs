namespace RelayCommandInDataTemplate.ViewModels
{
    public class CommunityToolkitCommandViewModel : SimpleCommandViewModelBase
    {
        public CommunityToolkitCommandViewModel()
        {
            Command = new CommunityToolkit.Mvvm.Input.RelayCommand<bool>(ExecuteCommand, CanExecuteCommand);
        }

        private void ExecuteCommand(bool obj)
        {
        }

        private bool CanExecuteCommand(bool arg)
        {
            return true;
        }
    }
}

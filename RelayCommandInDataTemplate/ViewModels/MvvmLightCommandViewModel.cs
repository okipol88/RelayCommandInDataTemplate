namespace RelayCommandInDataTemplate.ViewModels
{
    public class MvvmLightCommandViewModel : SimpleCommandViewModelBase
    {
        public MvvmLightCommandViewModel()
        {
            Command = new GalaSoft.MvvmLight.Command.RelayCommand<bool>(ExecuteCommand, CanExecuteCommand);
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

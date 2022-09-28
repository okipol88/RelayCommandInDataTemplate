using CommunityToolkit.Mvvm.ComponentModel;

namespace RelayCommandInDataTemplate.ViewModels
{

  public class MainViewModel : ObservableObject
  {
    public SimpleCommandViewModelBase MvvmViewModel { get; } = new MvvmLightCommandViewModel();
    public SimpleCommandViewModelBase CommunityViewModel { get; } = new CommunityToolkitCommandViewModel();
    public SimpleCommandViewModelBase CustomSimpleCommandViewModel { get; } = new CustomSimpleCommandViewModelBase();

  }
}

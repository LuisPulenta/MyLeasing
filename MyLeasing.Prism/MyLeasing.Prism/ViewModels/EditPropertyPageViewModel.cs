using Prism.Navigation;

namespace MyLeasing.Prism.ViewModels
{
    public class EditPropertyPageViewModel : ViewModelBase
    {
        public EditPropertyPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "New Property";
        }
    }
}
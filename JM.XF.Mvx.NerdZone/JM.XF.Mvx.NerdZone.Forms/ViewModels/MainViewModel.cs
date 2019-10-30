using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace JM.XF.Mvx.NerdZone.Forms.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }
    }
}

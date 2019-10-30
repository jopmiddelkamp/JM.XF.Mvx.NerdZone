using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace JM.XF.Mvx.NerdZone.Forms.ViewModels
{
    public class SplashViewModel : ViewModelBase
    {
        public SplashViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }
    }
}

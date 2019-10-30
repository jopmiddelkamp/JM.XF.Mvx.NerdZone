using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace JM.XF.Mvx.NerdZone.Forms.ViewModels
{
    public class ViewModelBase : MvxNavigationViewModel
    {
        public ViewModelBase(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
        }
    }
}

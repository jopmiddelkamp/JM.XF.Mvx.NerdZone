using System.Threading.Tasks;
using JM.XF.Mvx.NerdZone.Forms.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace JM.XF.Mvx.NerdZone.Forms
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override async Task NavigateToFirstViewModel(object hint = null)
        {
            await NavigationService.Navigate<MainViewModel>();
        }
    }
}

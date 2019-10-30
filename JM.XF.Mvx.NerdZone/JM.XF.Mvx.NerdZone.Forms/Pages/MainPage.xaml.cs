using JM.XF.Mvx.NerdZone.Forms.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;

namespace JM.XF.Mvx.NerdZone.Forms.Pages
{
    [MvxContentPagePresentation(WrapInNavigationPage = false, HostViewModelType = typeof(FormsViewModel))]
    public partial class MainPage : MvxContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}

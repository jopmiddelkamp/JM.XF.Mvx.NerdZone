using MvvmCross.ViewModels;

namespace JM.XF.Mvx.NerdZone.Forms
{
    public class App : MvxApplication
    {
        public static bool FormsViewsEnabled = true;

        public override void Initialize()
        {
            RegisterCustomAppStart<AppStart>();
        }
    }
}

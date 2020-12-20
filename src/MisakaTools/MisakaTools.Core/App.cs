using MisakaTools.Core.ViewModel;
using MvvmCross.ViewModels;

namespace MisakaTools.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ToolsChooseViewModel>();
            base.Initialize();
        }
    }
}

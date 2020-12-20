using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace MisakaTools.Host
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }
    }

    public abstract class MisakaToolsApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {
    }
}

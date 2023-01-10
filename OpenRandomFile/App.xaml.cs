using OpenRandomFile.Views;
using Prism.Ioc;
using System.Windows;

namespace OpenRandomFile
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<DAndDView>();
            containerRegistry.RegisterForNavigation<ChoosingView>();
        }
    }
}

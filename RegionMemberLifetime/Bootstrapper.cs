using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using RegionMemberLifetime.Views;
using FirstModuleProject;
using System.Windows;

namespace RegionMemberLifetime
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(FirstModule));
        }
    }
}

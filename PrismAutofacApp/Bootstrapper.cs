using Autofac;
using Prism.Autofac;
using Prism.Modularity;
using PrismAutofacApp.Views;
using PrismModule_Main; //outer moduke
using System.Windows;

namespace PrismAutofacApp
{
    class Bootstrapper : AutofacBootstrapper
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
            catalog.AddModule(typeof(PrismModule_MainModule));
        }
    }
}

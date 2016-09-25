using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;
using BooksUI;
using BooksUI.ModuleDefinition;

namespace Shell
{
    public class BootStrapper : UnityBootstrapper
    {
       
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<AppShell>();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
            Application.Current.MainWindow = (AppShell)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(BookUIModule));
          
        }
    }
}

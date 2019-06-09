using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Infragistics.Themes;
using Lightningfall.App.ViewModel;
using Lightningfall.Infrastructure;
using Lightningfall.UseCase;
using SimpleInjector;

namespace Lightningfall.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var container = new Container();

            container.Register<IManageProject, ManageProject>();
            container.Register<IProjectRepository, ProjectRepository>();

            container.Verify();
            ViewModelLocator.ViewModelResolver = new ViewModelResolver(container);


            //ThemeManager.ApplicationTheme = new RoyalDarkTheme();
        }

        private class ViewModelResolver : ViewModelLocator.IViewModelResolver
        {
            private readonly Container _container;

            public ViewModelResolver(Container container)
            {
                _container = container;
            }

            public T Resolve<T>() where T:class
            {
                return _container.GetInstance<T>();
            }
        }
    }
}

/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:BetterBuses.View.WinPhone.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using BetterBuses.ViewModel.Common;
using GalaSoft.MvvmLight;
using BetterBuses.Model.Common;
using BetterBuses.Service.Common;
using BetterBuses.Service.ExampleDataService;
using Microsoft.Practices.Unity;

namespace BetterBuses.View.WinPhone.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            _container = new UnityContainer();

            if (ViewModelBase.IsInDesignModeStatic)
            {
                _container.RegisterType<IExampleDataService, DesignExampleDataService>();
            }
            else
            {
                _container.RegisterType<IExampleDataService, ExampleDataService>();
            }

            _container.RegisterType<MainViewModel>();
        }   

        /// <summary>
        /// View Model for the main page.
        /// </summary>
        public MainViewModel Main
        {
            get { return _container.Resolve<MainViewModel>(); }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }

        private static UnityContainer _container;
    }
}
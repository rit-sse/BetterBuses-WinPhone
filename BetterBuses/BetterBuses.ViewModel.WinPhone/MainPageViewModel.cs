using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterBuses.Model.Common;
using BetterBuses.ViewModel.Common;

namespace BetterBuses.ViewModel.WinPhone
{
    /// <summary>
    /// Controller for the MainPage.
    /// </summary>
    public class MainPageViewModel : ViewModelBase, IMainPageViewModel
    {
        #region Properties

        /// <summary>
        /// ViewModels for the route controls.
        /// </summary>
        public ObservableCollection<RouteListItemViewModel> Routes
        {
            get { return _routes; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainPageViewModel()
        {
            _routes = new ObservableCollection<RouteListItemViewModel>();

            //if (DesignerProperties.IsInDesignTool)
            //{
                for (int i = 0; i < 3; i++)
                {
                    // Fake a route.
                    Route route = new Route
                    {
                        Name = "Night Shuttle",
                        IconPath = new Uri(@"http://www.placekitten.com/40/40")
                    };

                    // Create view models.
                    RouteListItemViewModel viewModel = new RouteListItemViewModel(route);
                    _routes.Add(viewModel);
                }
            //}
        }

        #endregion

        #region Internal State

        private readonly ObservableCollection<RouteListItemViewModel> _routes;

        #endregion
    }
}

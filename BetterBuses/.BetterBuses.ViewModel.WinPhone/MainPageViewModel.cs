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
        /// Uri for the image which appears in the background.
        /// </summary>
        public Uri BackgroundImagePath
        {
            get { return _backgroundImagePath; }
            set
            {
                _backgroundImagePath = value;
                OnPropertyChanged("BackgroundImagePath");
            }
        }

        /// <summary>
        /// ViewModels for the route controls.
        /// </summary>
        public ObservableCollection<RouteListItemViewModel> Routes
        {
            get { return _routes; }
        }

        public ObservableCollection<DestinationListItemViewModel> Destinations
        {
            get { return _destinations; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainPageViewModel()
        {
            _routes = new ObservableCollection<RouteListItemViewModel>();
            _destinations = new ObservableCollection<DestinationListItemViewModel>();
        }

        #endregion

        #region Internal State

        private Uri _backgroundImagePath;
        private readonly ObservableCollection<RouteListItemViewModel> _routes;
        private readonly ObservableCollection<DestinationListItemViewModel> _destinations;

        #endregion

    }
}

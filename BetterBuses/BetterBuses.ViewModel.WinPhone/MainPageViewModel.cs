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
        public String BackgroundImagePath
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

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainPageViewModel()
        {
            _routes = new ObservableCollection<RouteListItemViewModel>();
        }

        #endregion

        #region Internal State

        private String _backgroundImagePath;
        private readonly ObservableCollection<RouteListItemViewModel> _routes;

        #endregion
    
    }
}

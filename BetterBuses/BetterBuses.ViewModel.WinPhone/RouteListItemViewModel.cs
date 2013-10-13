using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterBuses.Model.Common;
using BetterBuses.ViewModel.Common;

namespace BetterBuses.ViewModel.WinPhone
{
    /// <summary>
    /// Controller for ListItem route views.
    /// </summary>
    public class RouteListItemViewModel : ViewModelBase
    {

        #region Properties

        /// <summary>
        /// The name of the route.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged( "Name" );
            }
        }

        /// <summary>
        /// Path to the route's preview icon.
        /// </summary>
        public Uri IconPath
        {
            get { return _iconPath; }
            set
            {
                _iconPath = value;
                OnPropertyChanged( "IconPath" );
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public RouteListItemViewModel()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="route">The route that this view model will present.</param>
        public RouteListItemViewModel(Route route)
        {
            _route = route;
            _name = _route.Name;
            _iconPath = _route.IconPath;
        }

        #endregion

        #region Internal State

        private readonly Route _route;
        private String _name;
        private Uri _iconPath;

        #endregion
    }
}

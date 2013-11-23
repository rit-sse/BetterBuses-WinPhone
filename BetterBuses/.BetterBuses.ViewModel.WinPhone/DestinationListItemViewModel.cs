using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterBuses.Model.Common;
using BetterBuses.ViewModel.Common;

namespace BetterBuses.ViewModel.WinPhone
{
    /// <summary>
    /// ViewModel for a destination list item.
    /// </summary>
    public class DestinationListItemViewModel : ViewModelBase, IDestinationListItemViewModel
    {
        #region Properties

        /// <summary>
        /// The name of the destination.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Path an icon containing a picture of the destination.
        /// </summary>
        public Uri IconPath
        {
            get { return _iconPath; }
            set
            {
                _iconPath = value;
                OnPropertyChanged("IconPath");
            }
        }

        /// <summary>
        /// The bus stop that will get the user to their destination the quickest.
        /// </summary>
        public Stop Stop
        {
            get { return _stop; }
            set
            {
                _stop = value;
                OnPropertyChanged("Stop");
            }
        }

        #endregion

        #region Internal State

        private String _name;
        private Uri _iconPath;
        private Stop _stop;

        #endregion
    }
}

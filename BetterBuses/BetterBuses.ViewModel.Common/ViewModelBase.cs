using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BetterBuses.ViewModel.Common.Annotations;

namespace BetterBuses.ViewModel.Common
{
    /// <summary>
    /// Base ViewModel class which handles property change events.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Event which is fired when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method which fires a property changed event for a particular property.
        /// </summary>
        /// <param name="propertyName">The name of the property which changed.</param>
        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged( String propertyName )//[CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

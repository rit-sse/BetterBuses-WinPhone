using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterBuses.Model.Common;

namespace BetterBuses.ViewModel.Common
{
    public interface IDestinationListItemViewModel
    {
        /// <summary>
        /// The name of the destination.
        /// </summary>
        String Name { get; set; }

        /// <summary>
        /// Path to the icon representing the Destination.
        /// </summary>
        Uri IconPath { get; set; }

        /// <summary>
        /// The closest bus stop that will take the user to the destination.
        /// </summary>
        Stop Stop { get; set; }
    }
}

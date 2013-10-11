using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBuses.Model.Common
{
    /// <summary>
    /// A bus stop location along a route.
    /// </summary>
    public class Destination
    {
        /// <summary>
        /// URI to an image of the stop.
        /// </summary>
        public Uri ImageSource { get; set; }

        /// <summary>
        /// The name of the stop.
        /// </summary>
        public String Name { get; set; }

        // Todo: GPS coordinates?
    }
}

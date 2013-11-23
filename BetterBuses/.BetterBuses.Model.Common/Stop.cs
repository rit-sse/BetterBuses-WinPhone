using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBuses.Model.Common
{
    /// <summary>
    /// A stop along the path that the bus takes. 
    /// </summary>
    public class Stop
    {
        /// <summary>
        /// The location that this stop corresponds to.
        /// </summary>
        public Destination Destination { get; set; }

        /// <summary>
        /// The time when this stop occurs.
        /// </summary>
        public DateTime Time { get; set; }
    }
}

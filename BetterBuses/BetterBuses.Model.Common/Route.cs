using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBuses.Model.Common
{
    /// <summary>
    /// The route that a bus takes. 
    /// </summary>
    public class Route
    {
        #region Properties

        /// <summary>
        /// The name of the route (ie. 'Night Shuttle').
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Path to the route's icon.
        /// </summary>
        public Uri IconPath { get; set; }

        /// <summary>
        /// The stops that a bus going along this route makes.
        /// </summary>
        public IList<Stop> Stops
        {
            get { return _stops; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public Route()
        {
            _stops = new List<Stop>();
        }

        #endregion

        #region Internal State

        private readonly IList<Stop> _stops;

        #endregion
    }
}

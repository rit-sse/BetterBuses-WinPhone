using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;

namespace BetterBuses.Model.WinPhone.Entity
{
    /// <summary>
    /// A sequence of bus routes consisting of stops.
    /// </summary>
    [Table]
    [JsonObject]
    public class Route : ObservableObject
    {
        #region Properties

        /// <summary>
        /// The name of the route.
        /// </summary>
        [Column(Name="route_name")]
        [JsonProperty]
        public String Name
        {
            get { return _name; }
            set
            {
                RaisePropertyChanging("Name");
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        /// <summary>
        /// Collection consisting of all of the stops that are a part of
        /// the route.
        /// TODO: Make this work with the DB.
        /// </summary>
        [JsonProperty]
        public ObservableCollection<Stop> Stops
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
            _stops = new ObservableCollection<Stop>();
        }

        #endregion

        #region Internal State

        /// <summary>
        /// Improves performance when performing database migrations.
        /// </summary>
        [Column(IsVersion = true)]
        private Binary _version;

        private String _name;
        private readonly ObservableCollection<Stop> _stops;

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace BetterBuses.Model.WinPhone.Entity
{
    /// <summary>
    /// Model class for a stop along a bus route.
    /// </summary>
    [Table]
    public class Stop : ObservableObject
    {
        #region Properties

        #region Database Columns

        /// <summary>
        /// Primary key value.
        /// </summary>
        [Column(Name="stop_id",
                IsPrimaryKey = true,
                IsDbGenerated = true,
                CanBeNull = false,
                AutoSync = AutoSync.OnInsert,
                DbType = "INT NOT NULL Identity")]
        public int StopId
        {
            get { return _stopId; }
            set
            {
                if (_stopId != value)
                {
                    RaisePropertyChanging("StopId");
                    _stopId = value;
                    RaisePropertyChanged("StopId");
                }
            }
        }

        /// <summary>
        /// The time that the stop occurs.
        /// </summary>
        [Column(Name="time")]
        public DateTime Time
        {
            get { return _time; }
            set
            {
                if (_time != value)
                {
                    RaisePropertyChanging("Time");
                    _time = value;
                    RaisePropertyChanged("Time");
                }
            }
        }

        #endregion

        #region Database Associations

        /// <summary>
        /// The destination that is associated with the stop.
        /// </summary>
        [Association(IsForeignKey = true,
                     ThisKey = "StopId",
                     OtherKey = "DestinationId",
                     DeleteOnNull = false)]
        public Destination Destination
        {
            get { return _destination; }
            set
            {
                if (_destination != value)
                {
                    RaisePropertyChanging("Destination");
                    _destination = value;
                    RaisePropertyChanged("Destination");
                }
            }
        }

        #endregion

        #endregion

        #region Internal State

        /// <summary>
        /// Improves performance when performing database migrations.
        /// </summary>
        [Column(IsVersion = true)]
        private Binary _version;

        [Column(Name = "destination_id")]
        private int _destinationId; 

        private int _stopId;
        private Destination _destination;
        private DateTime _time;

        #endregion
    }
}

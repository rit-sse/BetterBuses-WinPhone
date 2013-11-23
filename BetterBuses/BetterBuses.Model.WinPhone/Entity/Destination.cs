using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using GalaSoft.MvvmLight;
using Microsoft.Phone.Data.Linq;
using Microsoft.Phone.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BetterBuses.Model.WinPhone.Entity
{
    [Table]
    [JsonObject]
    public class Destination : ObservableObject
    {
        #region Properties

        /// <summary>
        /// Primary key value.
        /// </summary>
        [Column(IsPrimaryKey = true,
                IsDbGenerated = true,
                CanBeNull = false,
                AutoSync = AutoSync.OnInsert,
                DbType = "INT NOT NULL Identity")]
        [JsonProperty]
        public int DestinationId
        {
            get { return _destinationId; }
            set
            {
                if (_destinationId != value)
                {
                    RaisePropertyChanging("DestinationId");
                    _destinationId = value;
                    RaisePropertyChanged("DestinationId");
                }
            }
        }

        /// <summary>
        /// Path to a small icon which represents the destination.
        /// </summary>
        [Column]
        [JsonProperty]
        public String IconPath
        {
            get { return _iconPath; }
            set
            {
                if (_iconPath != value)
                {
                    RaisePropertyChanging("IconPath");
                    _iconPath = value;
                    RaisePropertyChanged("IconPath");
                }
            }
        }

        /// <summary>
        /// The name of the destination.
        /// </summary>
        [Column]
        [JsonProperty]
        public String Name
        {
            get { return _name; }
            set
            {
                // Don't bother to change anything if the value is the same.
                if (_name != value)
                {
                    RaisePropertyChanging("Name");
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// URI to the Icon which represents the destination. This property
        /// is exposed for Databinding purposes.
        /// </summary>
        public Uri IconUri
        {
            get { return new Uri(_iconPath, UriKind.RelativeOrAbsolute); }
        }

        #endregion

        #region Internal State

        /// <summary>
        /// Improves performance when performing database migrations.
        /// </summary>
        [Column(IsVersion = true)]
        private Binary _version;

        private int _destinationId;
        private String _name;
        private String _iconPath;

        #endregion
    }
}

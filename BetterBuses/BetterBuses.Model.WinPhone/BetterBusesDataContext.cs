using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterBuses.Model.WinPhone.Entity;

namespace BetterBuses.Model.WinPhone
{   
    public class BetterBusesDataContext : DataContext
    {
        /// <summary>
        /// Database Connection String.
        /// </summary>
        public static readonly String DbConnectionString = "isostore:/BetterBuses.sdf";

        /// <summary>
        /// Constructor.
        /// This constructor is implemented the way it is so that it can
        /// pass the connection string to the superclass.
        /// </summary>
        /// <param name="connectionString">A connection string for the database.</param>
        public BetterBusesDataContext( String connectionString ) : base(connectionString) {}

        /// <summary>
        /// Table containing destinations.
        /// </summary>
        public Table<Destination> Destinations;

        /// <summary>
        /// Table containing bus stops.
        /// </summary>
        public Table<Stop> Stops;

    }
}


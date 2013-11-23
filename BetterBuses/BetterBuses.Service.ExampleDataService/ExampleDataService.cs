using System;
using BetterBuses.Model.Common;
using BetterBuses.Service.Common;

namespace BetterBuses.Service.ExampleDataService
{
    public class ExampleDataService : IExampleDataService
    {
        public void GetData(Action<ExampleDataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new ExampleDataItem("Welcome to MVVM Light");
            callback(item, null);
        }
    }
}
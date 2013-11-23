using System;
using BetterBuses.Model.Common;
using BetterBuses.Service.Common;

namespace BetterBuses.Service.ExampleDataService
{
    public class DesignExampleDataService : IExampleDataService
    {
        public void GetData(Action<ExampleDataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new ExampleDataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }
    }
}
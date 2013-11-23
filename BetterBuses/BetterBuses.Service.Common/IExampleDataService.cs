using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BetterBuses.Model.Common;

namespace BetterBuses.Service.Common
{
    public interface IExampleDataService
    {
        void GetData(Action<ExampleDataItem, Exception> callback);
    }
}

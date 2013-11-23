using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetterBuses.Model.Common
{
    public class ExampleDataItem
    {
        public ExampleDataItem(string title)
        {
            Title = title;
        }

        public string Title
        {
            get;
            private set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShipIt
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}

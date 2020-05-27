using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIt
{
    class Crackers : IShippable
    {
        public decimal ShipCost
        {
            get { return 0.57M; }
        }

        public string Product
        {
            get { return "Cracker"; }
        }

        override public string ToString()
        {
            return Product;
        }
    }
}

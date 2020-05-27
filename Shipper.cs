using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShipIt
{
    class Shipper
    {
        public List<IShippable> ShoppingList { get; set; }

        public Shipper()
        {
            ShoppingList = new List<IShippable>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (IShippable f in ShoppingList)
            {
                totalCost = totalCost + f.ShipCost;
            }

            ShoppingList.Clear();

            return totalCost;
        }
    }
}

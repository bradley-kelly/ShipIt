namespace ShipIt
{
    class Bicycles : IShippable
    {
        public decimal ShipCost
        {
            get { return 20.50M; }
        }

        public string Product
        {
            get { return "Bicycle"; }
        }
    }
}

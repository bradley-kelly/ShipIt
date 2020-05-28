namespace ShipIt
{
    class BaseballGloves : IShippable
    {
        public decimal ShipCost
        {
            get { return 3.23M; }
        }

        public string Product
        {
            get { return "Baseball Glove"; }
        }
    }
}

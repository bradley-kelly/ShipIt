namespace ShipIt
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}

namespace Oblikovati.API;

/// <summary>
/// The Wires collection object provides access to a set of Wire objects.
/// </summary>
public interface Wires : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    Wire Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

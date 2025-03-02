namespace Oblikovati.API;

/// <summary>
/// The EdgeUses object is a collection of objects. See the article in the overviews section.
/// </summary>
public interface EdgeUses : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    EdgeUse Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

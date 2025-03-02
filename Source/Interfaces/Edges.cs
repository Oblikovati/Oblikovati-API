namespace Oblikovati.API;

/// <summary>
/// The Edges object is a collection of objects. See the article in the overviews section.
/// </summary>
public interface Edges : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    Edge this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

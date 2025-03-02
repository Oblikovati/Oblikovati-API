namespace Oblikovati.API;

/// <summary>
/// The AttributeSetsEnumerator object provides access to a list of objects. See the article in the overviews section.
/// </summary>
public interface AttributeSetsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    AttributeSet this[int Index] { get; }
}

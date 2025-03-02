namespace Oblikovati.API;

/// <summary>
/// The AttributesEnumerator object provides access to a list of Attribute objects. See the article in the overviews section.
/// </summary>
public interface AttributesEnumerator : IEnumerable
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
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    Attribute this[int Index] { get; }
}

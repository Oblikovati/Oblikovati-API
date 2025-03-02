namespace Oblikovati.API;

/// <summary>
/// Generic enumerator for a group of objects. This enumerator will also support the IEnumxxx-style interface (IEnumUnknown, unless otherwise specified).
/// </summary>
public interface ObjectsEnumeratorByVariant : IEnumerable
{
    /// <summary>
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    object Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

namespace Oblikovati.API;

/// <summary>
/// Generic enumerator for a group of objects. This enumerator will also support the IEnumxxx-style interface (IEnumUnknown, unless otherwise specified).
/// </summary>
public interface ObjectsEnumerator : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    object this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

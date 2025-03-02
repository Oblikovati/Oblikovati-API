namespace Oblikovati.API;

/// <summary>
/// Provides access to a list of objects.
/// </summary>
public interface DocumentsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the specified object from the collection. This is the default property of the DocumentsEnumerator object.
    /// </summary>
    _Document this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

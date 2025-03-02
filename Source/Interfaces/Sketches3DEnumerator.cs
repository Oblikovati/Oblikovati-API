namespace Oblikovati.API;

/// <summary>
/// The Sketches3DEnumerator allows iteration of available Sketch3D objects.
/// </summary>
public interface Sketches3DEnumerator : IEnumerable
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
    /// Property that returns an item from the collection.  The index of the first item in the collection is 1.
    /// </summary>
    Sketch3D this[int Index] { get; }
}

namespace Oblikovati.API;

/// <summary>
/// The SketchEntities3DEnumerator object provides access to a set of 3D sketch entities. See the article in the overviews section.
/// </summary>
public interface SketchEntities3DEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchEntity3D object from the collection.
    /// </summary>
    SketchEntity3D this[int Index] { get; }
}

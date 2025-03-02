namespace Oblikovati.API;

/// <summary>
/// The SketchEntitiesEnumerator object provides access to all of the geometric entities on the sketch regardless of their type. See the article in the overviews section.
/// </summary>
public interface SketchEntitiesEnumerator : IEnumerable
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
    /// Returns the specified SketchEntity object from the collection.
    /// </summary>
    SketchEntity Item { get; }
}

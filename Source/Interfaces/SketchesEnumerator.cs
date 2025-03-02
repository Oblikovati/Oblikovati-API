namespace Oblikovati.API;

/// <summary>
/// The SketchesEnumerator object. See the article in the overviews section.
/// </summary>
public interface SketchesEnumerator : IEnumerable
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
    /// Returns the specified Sketch object from the collection.
    /// </summary>
    Sketch Item { get; }
}

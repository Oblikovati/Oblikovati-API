namespace Oblikovati.API;

/// <summary>
/// The SketchBlocksEnumerator allows iteration of available SketchBlock objects.
/// </summary>
public interface SketchBlocksEnumerator : IEnumerable
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
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    SketchBlock Item { get; }
}

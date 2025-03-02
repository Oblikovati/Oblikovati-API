namespace Oblikovati.API;

/// <summary>
/// Allows iteration of available OrdinateDimension objects.
/// </summary>
public interface OrdinateDimensionsEnumerator : IEnumerable
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
    OrdinateDimension Item { get; }
}

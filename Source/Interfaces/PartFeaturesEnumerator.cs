namespace Oblikovati.API;

/// <summary>
/// The PartFeaturesEnumerator object. Presents a snapshot of the set of objects.
/// </summary>
public interface PartFeaturesEnumerator : IEnumerable
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
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    PartFeature Item { get; }
}

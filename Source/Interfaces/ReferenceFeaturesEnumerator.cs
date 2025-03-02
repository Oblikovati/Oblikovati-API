namespace Oblikovati.API;

/// <summary>
/// The ReferenceFeaturesEnumerator object enumerates through the objects.
/// </summary>
public interface ReferenceFeaturesEnumerator : IEnumerable
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
    /// Returns the specified ReferenceFeature object from the collection.
    /// </summary>
    ReferenceFeature this[int Index] { get; }
}

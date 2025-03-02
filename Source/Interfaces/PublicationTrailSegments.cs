namespace Oblikovati.API;

/// <summary>
/// PublicationTrail Object.
/// </summary>
public interface PublicationTrailSegments : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PublicationTrailSegment Item { get; }
}

namespace Oblikovati.API;

/// <summary>
/// PresentationTrailSegmentsEnumerator Object.
/// </summary>
public interface PresentationTrailSegmentsEnumerator : IEnumerable
{
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PresentationTrailSegment Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}

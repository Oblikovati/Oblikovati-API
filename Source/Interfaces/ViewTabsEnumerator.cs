namespace Oblikovati.API;

/// <summary>
/// ViewTabsEnumerator object.
/// </summary>
public interface ViewTabsEnumerator : IEnumerable
{
    /// <summary>
    /// Read-only property that returns the root Application object.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ViewTab Item { get; }
    /// <summary>
    /// Read-only property that returns the number of view tabs in this view tab group.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}

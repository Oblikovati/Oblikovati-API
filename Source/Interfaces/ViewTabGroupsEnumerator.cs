namespace Oblikovati.API;

/// <summary>
/// ViewTabGroupsEnumerator object.
/// </summary>
public interface ViewTabGroupsEnumerator : IEnumerable
{
    /// <summary>
    /// Read-only property that returns the root Application object.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ViewTabGroup this[int Index] { get; }
    /// <summary>
    /// Read-only property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}

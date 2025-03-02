namespace Oblikovati.API;

/// <summary>
/// ViewFrames enumerator object.
/// </summary>
public interface ViewFramesEnumerator : IEnumerable
{
    /// <summary>
    /// Read-only property returning kViewFramesEnumeratorObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the root Application object.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Read-only property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ViewFrame Item { get; }
}

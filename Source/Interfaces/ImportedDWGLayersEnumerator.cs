namespace Oblikovati.API;

/// <summary>
/// The ImportedDWGLayersEnumerator collection object.
/// </summary>
public interface ImportedDWGLayersEnumerator : IEnumerable
{
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ImportedDWGLayer Item { get; }
}

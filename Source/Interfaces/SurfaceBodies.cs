namespace Oblikovati.API;

/// <summary>
/// The SurfaceBodies object represents a collection of SurfaceBody objects. See the article in the overviews section.
/// </summary>
public interface SurfaceBodies : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    SurfaceBody Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}

namespace Oblikovati.API;

/// <summary>
/// MidSurface Thickness Collection Object.
/// </summary>
public interface MidSurfaceThicknesses : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    MidSurfaceThickness Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
}

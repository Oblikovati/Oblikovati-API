namespace Oblikovati.API;

/// <summary>
/// Part MidSurface Features Collection Object.
/// </summary>
public interface MidSurfaceFeatures : IEnumerable
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MidSurfaceFeature _Item { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="simulationId">simulationId</param>
    /// <param name="Bodies">Bodies</param>
    [PreserveSig]
    MidSurfaceFeature _Add([In] uint simulationId, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Bodies);
}

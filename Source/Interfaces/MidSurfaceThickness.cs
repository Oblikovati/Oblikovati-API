namespace Oblikovati.API;

/// <summary>
/// MidSurface Thickness Object.
/// </summary>
public interface MidSurfaceThickness
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the Parameter object that controls the maximum thickness value.
    /// </summary>
    double Maximum { get; }
    /// <summary>
    /// Read-only property that returns the Parameter object that controls the minimum thickness value.
    /// </summary>
    double Minimum { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the corresponding face on the mid-surface body which being assigned with the maximum and minimum thickness here.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Face GetSourceFace();
}

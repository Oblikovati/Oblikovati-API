namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work point defined to be at the center of a sphere.
/// </summary>
public interface SphereCenterPointWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Read-only property that returns kSphereCenterPointWorkPointDefObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the face object whose geometry is a Sphere surface, the center point of which defines the position of the work point.
    /// </summary>
    Face Face { get; }
}

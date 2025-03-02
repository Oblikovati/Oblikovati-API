namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane defined to be at the mid-plane of a torus.
/// </summary>
public interface TorusMidPlaneWorkPlaneDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent WorkPlane object.
    /// </summary>
    WorkPlane Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that indicates the Face object whose geometry is a torus surface, the mid-plane of which defines the position of the work plane.
    /// </summary>
    Face Face { get; }
}

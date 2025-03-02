namespace Oblikovati.API;

/// <summary>
/// The PlanarMoveDefinition object defines all of the inputs that are unique to a move face feature defined using two planar points.
/// </summary>
public interface PlanarMoveDefinition
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent MoveFaceDefinition object.
    /// </summary>
    MoveFaceDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the plane for the planar move.
    /// </summary>
    object Plane { get; set; }
    /// <summary>
    /// Gets and sets the first point for the planar move.
    /// </summary>
    object PointOne { get; set; }
    /// <summary>
    /// Gets and sets the second point for the planar move.
    /// </summary>
    object PointTwo { get; set; }
}

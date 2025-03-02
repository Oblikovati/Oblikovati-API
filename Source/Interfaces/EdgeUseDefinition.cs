namespace Oblikovati.API;

/// <summary>
/// The FaceDefinition represents a transient definition of a Face object.
/// </summary>
public interface EdgeUseDefinition
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
    /// Gets and set the associated EdgeDefinition object.
    /// </summary>
    EdgeDefinition EdgeDefinition { get; set; }
    /// <summary>
    /// Gets and sets if the orientation of this EdgeUse is in the same direction or not relative to the associated EdgeDefinition object.
    /// </summary>
    bool IsOpposedToEdge { get; set; }
}

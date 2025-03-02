namespace Oblikovati.API;

/// <summary>
/// The FreeMoveDefinition object defines all of the inputs that are unique to a move face feature defined using a transform.
/// </summary>
public interface FreeMoveDefinition
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
    /// Gets and sets the Matrix defining the free move transform of the faces.
    /// </summary>
    Matrix Transformation { get; set; }
}

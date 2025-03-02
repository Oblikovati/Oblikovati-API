namespace Oblikovati.API;

/// <summary>
/// The Bend object represents a bend in a sheet metal part.
/// </summary>
public interface Bend
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
    /// Property that returns the parent SheetMetalComponentDefinition of this Bend object.
    /// </summary>
    SheetMetalComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the collection of front faces in the model that represent this bend.
    /// </summary>
    Faces BackFaces { get; }
    /// <summary>
    /// Property that returns the collection of faces in the model that represent this bend.
    /// </summary>
    Faces FrontFaces { get; }
    /// <summary>
    /// Property that indicates if the bend is in a folded or flat state
    /// </summary>
    bool IsFlat { get; }
}

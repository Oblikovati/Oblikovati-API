namespace Oblikovati.API;

/// <summary>
/// The BoundaryPatchDefinition object is used to define the input required for creating boundary patch features.
/// </summary>
public interface BoundaryPatchDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that specifies the set of boundary loops used to create the boundary patch feature.
    /// </summary>
    BoundaryPatchLoops BoundaryPatchLoops { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that gets and sets the guide rail objects for the boundary patch.
    /// </summary>
    ObjectCollection GuideRails { get; set; }
}

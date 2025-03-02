namespace Oblikovati.API;

/// <summary>
/// The PathAndGuideSurfaceSweepDef object provides access to the information that defines the variables for a sweep feature defined by a path and a guide surface.
/// </summary>
public interface PathAndGuideSurfaceSweepDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent SweepFeature of the definition.
    /// </summary>
    SweepFeature Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the guide surface the normal of which controls the twist of the swept profile about the path. This property is applicable when the SweepType is kPathAndGuideSurfaceSweepType.
    /// </summary>
    object GuideSurface { get; set; }
}

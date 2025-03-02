namespace Oblikovati.API;

/// <summary>
/// The PathAndGuideRailSweepDef object provides access to the information that defines the variables for a sweep feature defined by a path and a guide rail.
/// </summary>
public interface PathAndGuideRailSweepDef
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
    /// Read-write property that gets and sets the scaling direction for sweep profile. This property is applicable when the SweepType is kPathAndGuideRailSweepType.
    /// </summary>
    SweepProfileScalingEnum ProfileScaling { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the guide rail for the sweep which is the guide curve that controls the scaling and twist of the sweep profile. This property is applicable when the SweepType is kPathAndGuideRailSweepType.
    /// </summary>
    Path GuideRail { get; set; }
}

namespace Oblikovati.API;

/// <summary>
/// The PathSweepDef object provides access to the information that defines the variables for a sweep feature defined by a path and profile orientation constant.
/// </summary>
public interface PathSweepDef
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
    /// Read-write property that gets and sets the orientation of sweep profile. This property is applicable when the SweepType is kPathSweepType and kPathAndSectionTwistSweepType.
    /// </summary>
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the taper angle of sweep. This property is applicable when the SweepType is kPathSweepType and kPathAndSectionTwistSweepType and when the ProfileOrientation is kNormalToPath.
    /// </summary>
    Parameter TaperAngle { get; }
}

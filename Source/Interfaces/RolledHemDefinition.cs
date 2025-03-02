namespace Oblikovati.API;

/// <summary>
/// The RolledHemDefinition object defines all of the inputs that are unique to a rolled style of hem feature.
/// </summary>
public interface RolledHemDefinition
{
    /// <summary>
    /// Property that returns the parent hem definition feature.
    /// </summary>
    HemDefinition Parent { get; }
    /// <summary>
    /// Property that returns the parameter controlling the radius of a hem feature defined by a rolled style of bend.
    /// </summary>
    Parameter Radius { get; }
    /// <summary>
    /// Property that returns the parameter controlling the bend angle of a hem feature defined by a rolled style of bend.
    /// </summary>
    Parameter Angle { get; }
}

namespace Oblikovati.API;

/// <summary>
/// The SingleHemDefinition object defines all of the inputs that are unique to a single style of hem feature.
/// </summary>
public interface SingleHemDefinition
{
    /// <summary>
    /// Property that returns the parent hem definition feature.
    /// </summary>
    HemDefinition Parent { get; }
    /// <summary>
    /// Property that returns the parameter controlling the gap of a hem feature defined by a single bend.
    /// </summary>
    Parameter Gap { get; }
    /// <summary>
    /// Property that returns the parameter controlling the length of a hem feature defined by a single bend.
    /// </summary>
    Parameter Length { get; }
}

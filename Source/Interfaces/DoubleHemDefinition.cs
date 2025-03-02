namespace Oblikovati.API;

/// <summary>
/// The DoubleHemDefinition defines all of the inputs that are unique to a double style of hem feature.
/// </summary>
public interface DoubleHemDefinition
{
    /// <summary>
    /// Property that returns the parent hem definition feature.
    /// </summary>
    HemDefinition Parent { get; }
    /// <summary>
    /// Property that returns the parameter controlling the gap of a hem feature defined by a double bend style of bend.
    /// </summary>
    Parameter Gap { get; }
    /// <summary>
    /// Property that returns the parameter controlling the length of a hem feature defined by a double bend style of bend.
    /// </summary>
    Parameter Length { get; }
}

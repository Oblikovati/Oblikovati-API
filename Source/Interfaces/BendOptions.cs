namespace Oblikovati.API;

/// <summary>
/// The BendOptions object defines the settings that influence the creation of a bend in a sheet metal part.
/// </summary>
public interface BendOptions
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Defines the type of bend transition to use for the associated sheet metal feature.
    /// </summary>
    BendTransitionEnum BendTransition { get; set; }
    /// <summary>
    /// Defines the type of bend relief shape to use for the associated sheet metal feature.
    /// </summary>
    BendReliefShapeEnum BendReliefShape { get; set; }
    /// <summary>
    /// Provides access to the bend relief width of a sheet metal feature.
    /// </summary>
    object BendReliefWidth { get; set; }
    /// <summary>
    /// Provides access to the bend relief depth of a sheet metal feature.
    /// </summary>
    object BendReliefDepth { get; set; }
    /// <summary>
    /// Provides access to the minimum remnant of a sheet metal feature.
    /// </summary>
    object MinimumRemnant { get; set; }
    /// <summary>
    /// Provides access to the radius for an arc bend transition.
    /// </summary>
    object BendTransitionArcRadius { get; set; }
    /// <summary>
    /// Property that returns the parent object of this BendOptions object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Function that creates a copy of this BendOptions object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BendOptions Copy();
}

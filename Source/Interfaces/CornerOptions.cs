namespace Oblikovati.API;

/// <summary>
/// The CornerOptions object defines the settings that influence the creation of a corner in a sheet metal part.
/// </summary>
public interface CornerOptions
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Defines the type of two bend relief shape to use for the associated sheet metal feature.
    /// </summary>
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    /// <summary>
    /// Provides access to the two bend corner relief size of a sheet metal feature.
    /// </summary>
    object CornerReliefSize { get; set; }
    /// <summary>
    /// Property that indicates if the corner this CornerOptions object is associated with is a two or three bend corner.
    /// </summary>
    bool IsTwoBend { get; }
    /// <summary>
    /// Property that returns the parent object of this CornerOptions object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Defines the two bend relief placement to use for the associated sheet metal feature (valid only for round and square corners).
    /// </summary>
    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
    /// <summary>
    /// Function that creates a copy of this CornerOptions object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CornerOptions Copy();
}

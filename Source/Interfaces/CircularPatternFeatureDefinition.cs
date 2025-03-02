namespace Oblikovati.API;

/// <summary>
/// Part Circular Pattern Definition object.
/// </summary>
public interface CircularPatternFeatureDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of bodies affected by this feature. If this property is not set for multi-body parts, the default solid body is used as the affected body.&nbsp;This property applies only to features in a part.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the collection of occurrences that should participate in this feature. If this property is not set, all possible occurrences will participate.&nbsp;This property applies only to features in an assembly.
    /// </summary>
    ObjectCollection AffectedOccurrences { get; set; }
    /// <summary>
    /// Read-write property that that indicates the method of solution for the pattern.
    /// </summary>
    PatternComputeTypeEnum ComputeType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the angle of the pattern.
    /// </summary>
    object Angle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the number of instances.
    /// </summary>
    object Count { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the patterned occurrences keep the same rotation as their parent features.
    /// </summary>
    bool LockRotation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the point used to define the pattern radius against the rotation axis.
    /// </summary>
    object PatternRadiusPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the entity as rotation axis. This can be a linear Edge, a WorkAxis, a cylindrical or conical Face (axis is used).
    /// </summary>
    object RotationAxis { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the patterned occurrences should fall on either side of the original.
    /// </summary>
    bool MidPlanePattern { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the flag that indicates if the direction of the pattern is in the natural direction of the RotationAxis or reversed.
    /// </summary>
    bool NaturalRotationAxisDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model.&nbsp;Valid values are kNewBodyOperation and kJoinOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the enum indicating the positioning method used for pattern creation.
    /// </summary>
    PatternPositioningMethodEnum PositioningMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the parent features of the pattern.
    /// </summary>
    ObjectCollection ParentFeatures { get; set; }
    /// <summary>
    /// Read-only property that gets whether this pattern resulted from patterning the SurfaceBody objects.
    /// </summary>
    bool PatternOfBody { get; }
    /// <summary>
    /// Read-write property that gets and sets the PatternBoundarySetting object.
    /// </summary>
    PatternBoundarySetting BoundarySetting { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this pattern has boundary setting configured or not. When set this property it can only be set from True to False to clear the boundary setting.
    /// </summary>
    bool HasBoundarySettingConfigured { get; set; }
    /// <summary>
    /// Method that creates a copy of this CircularPatternFeatureDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CircularPatternFeatureDefinition Copy();
}

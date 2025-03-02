namespace Oblikovati.API;

/// <summary>
/// Part Rectangular Pattern Definition object.
/// </summary>
public interface RectangularPatternFeatureDefinition
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
    /// Read-write property that gets and sets the flag that indicates if the direction of the pattern is in the natural direction of the XDirectionEntity or reversed.
    /// </summary>
    bool NaturalXDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the flag that indicates if the direction of the pattern is in the natural direction of the YDirectionEntity or reversed.
    /// </summary>
    bool NaturalYDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model.&nbsp;Valid values are kNewBodyOperation and kJoinOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model.&nbsp;Valid values are kNewBodyOperation and kJoinOperation.
    /// </summary>
    PatternOrientationEnum OrientationMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the parent features of the pattern.
    /// </summary>
    ObjectCollection ParentFeatures { get; set; }
    /// <summary>
    /// Read-only property that gets whether this pattern resulted from patterning the SurfaceBody objects.
    /// </summary>
    bool PatternOfBody { get; }
    /// <summary>
    /// Read-write property that gets and sets the number of instances in the X direction.
    /// </summary>
    object XCount { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the X direction entity. This can be a linear Edge, a WorkAxis, a WorkPlane (normal is used), a planar Face (normal is used), or a GeometryIntent.
    /// </summary>
    object XDirectionEntity { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the enum that indicates if the occurrences in the x-direction have been fitted within a specified distance. Valid values are kDefault, kFitted and kFitToPathLength.
    /// </summary>
    PatternSpacingTypeEnum XDirectionSpacingType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the X direction start point. This can be a vertex, planar sketch point or a 3D sketch point.
    /// </summary>
    object XDirectionStartPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the spacing between instances in the X direction.
    /// </summary>
    object XSpacing { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the patterned occurrences should fall on either side of the original in the X direction.
    /// </summary>
    bool XDirectionMidPlanePattern { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the number of instances in the Y direction.
    /// </summary>
    object YCount { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the Y direction entity. This can be a linear Edge, a WorkAxis, a WorkPlane (normal is used), a planar Face (normal is used), or a GeometryIntent.
    /// </summary>
    object YDirectionEntity { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the enum that indicates if the occurrences in the y-direction have been fitted within a specified distance. Valid values are kDefault, kFitted and kFitToPathLength.
    /// </summary>
    PatternSpacingTypeEnum YDirectionSpacingType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the Y direction start point. This can be a vertex, planar sketch point or a 3D sketch point.
    /// </summary>
    object YDirectionStartPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the spacing between instances in the Y direction.
    /// </summary>
    object YSpacing { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the patterned occurrences should fall on either side of the original in the Y direction.
    /// </summary>
    bool YDirectionMidPlanePattern { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the PatternBoundarySetting object.
    /// </summary>
    PatternBoundarySetting BoundarySetting { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this pattern has boundary setting configured or not. When set this property it can only be set from True to False to clear the boundary setting.
    /// </summary>
    bool HasBoundarySettingConfigured { get; set; }
    /// <summary>
    /// Method that creates a copy of this RectangularPatternFeatureDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    RectangularPatternFeatureDefinition Copy();
}

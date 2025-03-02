namespace Oblikovati.API;

/// <summary>
/// The RectangularPatternFeatures object provides access to all of the objects in a component definition and provides methods to create additional RectangularPatternFeature objects.
/// </summary>
public interface RectangularPatternFeatures : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified object from the collection. This is the default property of the RectangularPatternFeatures collection object.
    /// </summary>
    RectangularPatternFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SketchCurve">SketchCurve</param>
    [PreserveSig]
    Path CreatePath([In] [MarshalAs(UnmanagedType.IDispatch)] object SketchCurve);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentFeatures">ParentFeatures</param>
    /// <param name="XDirectionEntity">XDirectionEntity</param>
    /// <param name="NaturalXDirection">NaturalXDirection</param>
    /// <param name="XCount">XCount</param>
    /// <param name="XSpacing">XSpacing</param>
    /// <param name="XSpacingType">XSpacingType</param>
    /// <param name="XDirectionStartPoint">XDirectionStartPoint</param>
    /// <param name="YDirectionEntity">YDirectionEntity</param>
    /// <param name="NaturalYDirection">NaturalYDirection</param>
    /// <param name="YCount">YCount</param>
    /// <param name="YSpacing">YSpacing</param>
    /// <param name="YSpacingType">YSpacingType</param>
    /// <param name="YDirectionStartPoint">YDirectionStartPoint</param>
    /// <param name="AdjustToModel">AdjustToModel</param>
    /// <param name="OrientationMethod">OrientationMethod</param>
    [PreserveSig]
    RectangularPatternFeature _Add2([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object XDirectionEntity, [In] bool NaturalXDirection, [In] [MarshalAs(UnmanagedType.Struct)] object XCount, [In] [MarshalAs(UnmanagedType.Struct)] object XSpacing, [In] PatternSpacingTypeEnum? XSpacingType = PatternSpacingTypeEnum.kDefault, [In] [MarshalAs(UnmanagedType.Struct)] object? XDirectionStartPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? YDirectionEntity = default, [In] bool? NaturalYDirection = true, [In] [MarshalAs(UnmanagedType.Struct)] object? YCount = default, [In] [MarshalAs(UnmanagedType.Struct)] object? YSpacing = default, [In] PatternSpacingTypeEnum? YSpacingType = PatternSpacingTypeEnum.kDefault, [In] [MarshalAs(UnmanagedType.Struct)] object? YDirectionStartPoint = default, [In] bool? AdjustToModel = false, [In] PatternOrientationEnum? OrientationMethod = PatternOrientationEnum.kIdentical);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentFeatures">ParentFeatures</param>
    /// <param name="XDirectionEntity">XDirectionEntity</param>
    /// <param name="NaturalXDirection">NaturalXDirection</param>
    /// <param name="XCount">XCount</param>
    /// <param name="XSpacing">XSpacing</param>
    /// <param name="XSpacingType">XSpacingType</param>
    /// <param name="XDirectionStartPoint">XDirectionStartPoint</param>
    /// <param name="YDirectionEntity">YDirectionEntity</param>
    /// <param name="NaturalYDirection">NaturalYDirection</param>
    /// <param name="YCount">YCount</param>
    /// <param name="YSpacing">YSpacing</param>
    /// <param name="YSpacingType">YSpacingType</param>
    /// <param name="YDirectionStartPoint">YDirectionStartPoint</param>
    /// <param name="ComputeType">ComputeType</param>
    /// <param name="OrientationMethod">OrientationMethod</param>
    [PreserveSig]
    RectangularPatternFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object XDirectionEntity, [In] bool NaturalXDirection, [In] [MarshalAs(UnmanagedType.Struct)] object XCount, [In] [MarshalAs(UnmanagedType.Struct)] object XSpacing, [In] PatternSpacingTypeEnum? XSpacingType = PatternSpacingTypeEnum.kDefault, [In] [MarshalAs(UnmanagedType.Struct)] object? XDirectionStartPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? YDirectionEntity = default, [In] bool? NaturalYDirection = true, [In] [MarshalAs(UnmanagedType.Struct)] object? YCount = default, [In] [MarshalAs(UnmanagedType.Struct)] object? YSpacing = default, [In] PatternSpacingTypeEnum? YSpacingType = PatternSpacingTypeEnum.kDefault, [In] [MarshalAs(UnmanagedType.Struct)] object? YDirectionStartPoint = default, [In] PatternComputeTypeEnum? ComputeType = PatternComputeTypeEnum.kOptimizedCompute, [In] PatternOrientationEnum? OrientationMethod = PatternOrientationEnum.kIdentical);
    /// <summary>
    /// Method that creates a new rectangular pattern feature.
    /// </summary>
    /// <param name="Definition">Input RectangularPatternFeatureDefinition objet that defines the  RectangularPatternFeature you want to create.</param>
    /// <returns></returns>
    [PreserveSig]
    RectangularPatternFeature AddByDefinition([In] [MarshalAs(UnmanagedType.Interface)] RectangularPatternFeatureDefinition Definition);
    /// <summary>
    /// Method that creates a new RectangularPatternFeatureDefinition object.
    /// </summary>
    /// <param name="ParentFeatures">Input ObjectCollection object that contains the features or solids to be patterned. The collection could contain the various part features, sheet metal features, work planes, work axes, work points, or SurfaceBody objects. If SurfaceBody objects are supplied, the only other objects that can be in the collection are work planes, work axes, work points, and surface part features. Finish features such as fillets and chamfers may be included only if their parent feature is also included.</param>
    /// <param name="XDirectionEntity">Input a linear entity that defines the first direction. This can be a linear Edge, a WorkAxis, a WorkPlane (normal is used), a planar Face (normal is used), or a GeometryIntent. When input GeometryIntent the geometry can be a non-linear Edge or Path, and the intent is used to specify a point on the geometry and the tangent direction at the point of the geometry will be used as the X-direction of the pattern feature.Use the CreatePath or CreateSpecifiedPath methods on the PartFeatures object to create a Path. The path can be a combination of 2D and 3D sketch elements.</param>
    /// <param name="NaturalXDirection">Input Boolean that indicates if the direction of the pattern is in the natural direction of the XDirectionEntity or reversed. A value of True indicates it is in the natural direction.</param>
    /// <param name="XCount">Input Variant that defines the number of instances in the X direction. This can be either a numeric value or a string. A parameter will be created to control this value when the feature is created. If a string is input it can be any string that can be evaluated by Inventor to result in a unitless number.</param>
    /// <param name="XSpacing">Input Variant that defines the spacing between instances in the X direction. This can be either a numeric value or a string. A parameter will be created to control this value when the feature is created. If a string is input it can be any string that can be evaluated by Inventor to result in a unitless number. This input may be left unspecified only if the XSpacingType is kFitToPathLength and if the XDirectionEntity is not a work axis.</param>
    /// <param name="XSpacingType">Optional input PatternSpacingTypeEnum enum that indicates if the occurrences along the x direction are to be fitted within a specified distance. A value of kDefault indicates that the occurrences are to be separated by the specified distance. A value of kFitted indicates that all occurrences are to be fitted within the specified distance. A value of kFitToPathLength indicates that all occurrences are to be fitted within a distance equal to the length of the XDirectionEntity. The kFitToPathLength value is invalid in cases where the XDirectionEntity is a work axis.</param>
    /// <returns></returns>
    [PreserveSig]
    RectangularPatternFeatureDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object XDirectionEntity, [In] bool NaturalXDirection, [In] [MarshalAs(UnmanagedType.Struct)] object XCount, [In] [MarshalAs(UnmanagedType.Struct)] object XSpacing, [In] PatternSpacingTypeEnum? XSpacingType = PatternSpacingTypeEnum.kDefault);
}

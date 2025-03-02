namespace Oblikovati.API;

/// <summary>
/// The CircularPatternFeatures collection object provides access to all of the objects in a component definition and provides methods to create additional CircularPatternFeature objects.
/// </summary>
public interface CircularPatternFeatures : IEnumerable
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
    /// Returns the specified CircularPatternFeature object from the collection. This is the default property of the CircularPatternFeatures collection object.
    /// </summary>
    CircularPatternFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentFeatures">ParentFeatures</param>
    /// <param name="AxisEntity">AxisEntity</param>
    /// <param name="NaturalAxisDirection">NaturalAxisDirection</param>
    /// <param name="Count">Count</param>
    /// <param name="Angle">Angle</param>
    /// <param name="FitWithinAngle">FitWithinAngle</param>
    /// <param name="AdjustToModel">AdjustToModel</param>
    [PreserveSig]
    CircularPatternFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] bool NaturalAxisDirection, [In] [MarshalAs(UnmanagedType.Struct)] object Count, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] bool FitWithinAngle, [In] bool? AdjustToModel = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentFeatures">ParentFeatures</param>
    /// <param name="AxisEntity">AxisEntity</param>
    /// <param name="NaturalAxisDirection">NaturalAxisDirection</param>
    /// <param name="Count">Count</param>
    /// <param name="Angle">Angle</param>
    /// <param name="FitWithinAngle">FitWithinAngle</param>
    /// <param name="ComputeType">ComputeType</param>
    [PreserveSig]
    CircularPatternFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] bool NaturalAxisDirection, [In] [MarshalAs(UnmanagedType.Struct)] object Count, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] bool FitWithinAngle, [In] PatternComputeTypeEnum? ComputeType = PatternComputeTypeEnum.kOptimizedCompute);
    /// <summary>
    /// Method that creates a new CircularPattern feature.
    /// </summary>
    /// <param name="Definition">Input CircularPatternFeatureDefinition objet that defines the  CircularPatternFeature you want to create.</param>
    /// <returns></returns>
    [PreserveSig]
    CircularPatternFeature AddByDefinition([In] [MarshalAs(UnmanagedType.Interface)] CircularPatternFeatureDefinition Definition);
    /// <summary>
    /// Method that creates a new CircularPatternFeatureDefinition object.
    /// </summary>
    /// <param name="ParentFeatures">Input ObjectCollection object that contains the features or solids to be patterned. The collection could contain the various part features, sheet metal features, work planes, work axes, work points, or SurfaceBody objects. If SurfaceBody objects are supplied, the only other objects that can be in the collection are work planes, work axes, work points, and surface part features. Finish features such as fillets and chamfers may be included only if their parent feature is also included.</param>
    /// <param name="AxisEntity">Input a linear entity that defines the rotation axis. This can be a linear Edge, a WorkAxis, a cylindrical/conical/spherical/toroidal Face (axis is used).</param>
    /// <param name="NaturalAxisDirection">Input Boolean that indicates if the direction of the pattern is in the natural direction of the AxisEntity or reversed. A value of True indicates it is in the natural direction.</param>
    /// <param name="Count">Input Variant that defines the number of instances in the pattern. This can be either a numeric value or a string. A parameter will be created to control this value when the feature is created. If a string is input it can be any string that can be evaluated by Inventor to result in a unitless number.</param>
    /// <param name="Angle">Input Variant that defines the angle of the pattern. This can be either a numeric value or a string. A parameter will be created to control this value when the feature is created. If a string is input it can be any string that can be evaluated by Inventor to result in a unitless value(document angular units will be used for it) or an angular unit value.</param>
    /// <param name="FitWithinAngle">Optional input Boolean that defines how the count and angle are used to space the occurrences.  If this property is true then the angle specifies the total sweep made by the pattern and the occurrences are evenly spaced within the angle.  If it is false then the angle specifies the angular offset between each occurrence. This defaults to True.</param>
    /// <returns></returns>
    [PreserveSig]
    CircularPatternFeatureDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] bool NaturalAxisDirection, [In] [MarshalAs(UnmanagedType.Struct)] object Count, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] bool? FitWithinAngle = true);
}

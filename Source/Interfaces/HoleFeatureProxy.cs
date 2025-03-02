namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface HoleFeatureProxy
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
    /// Property that returns the parent of the feature.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/Sets the name of this Part Feature within the scope of this Document.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Gets and sets whether this feature is adaptive or not.
    /// </summary>
    bool Adaptive { get; set; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that returns a collection that provides access to all of the faces of the feature. The Faces collection object will return the faces that still currently exist in the part. For example, if a face has been consumed by additional modeling operations it will not be returned.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SurfaceBody SurfaceBody { get; }
    /// <summary>
    /// Gets and sets whether this feature is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns the list of participants for an assembly feature. This list is empty for features in a part.
    /// </summary>
    ComponentOccurrencesEnumerator Participants { get; }
    /// <summary>
    /// Property that returns all the parameters associated with the feature.
    /// </summary>
    ParametersEnumerator Parameters { get; }
    /// <summary>
    /// Gets and sets whether the part feature is shared or not, applies only to surface features.
    /// </summary>
    bool Shared { get; set; }
    /// <summary>
    /// Gets and sets whether the inputs to this feature should be nested under this feature in the browser.
    /// </summary>
    bool ConsumeInputs { get; set; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature. If True, the OwnedBy property returns the owning feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Property that returns the owning PartFeature object. This property returns Nothing if the IsOwnedByFeature property returns False.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Property that returns the FeatureDimensions collection object.
    /// </summary>
    FeatureDimensions FeatureDimensions { get; }
    /// <summary>
    /// Property that returns the bodies that this feature has created or modified.
    /// </summary>
    SurfaceBodies SurfaceBodies { get; }
    /// <summary>
    /// Read-only property that returns the full feature name including any extended information.
    /// </summary>
    string ExtendedName { get; }
    /// <summary>
    /// Gets and sets the current appearance of the feature.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Gets and sets the source of the appearance for the feature.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Property that returns the type of hole. Can be kDrilledHole, kCounterBoreHole, kCounterSinkHole, or kSpotFaceHole. The hole type can be set by using the SetToCBore, SetToCSink, SetDrilled, and SetToSpotFace methods.
    /// </summary>
    HoleTypeEnum HoleType { get; }
    /// <summary>
    /// Property that returns the Boolean flag indicating whether the hole is tapped or not.
    /// </summary>
    bool Tapped { get; set; }
    /// <summary>
    /// Property that gets and sets the HoleTapInfo or TaperedThreadInfo object associated with the hole.
    /// </summary>
    object TapInfo { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool FlatBottom { get; }
    /// <summary>
    /// Property that returns the Parameter that defines the included angle of the tip of a blind hole, one that has been specified by a distance extent or 'to face' extent . If this is a Flat Bottomed hole then the property will return Nothing.
    /// </summary>
    Parameter BottomTipAngle { get; }
    /// <summary>
    /// Property that returns the parameter controlling the diameter of the hole. This property will return Nothing if the diameter is being read off a value from the HoleTapInfo, when this hole is tapped.
    /// </summary>
    Parameter HoleDiameter { get; }
    /// <summary>
    /// Property that returns the parameter controlling the CBore diameter. This property will return Nothing in the case where the HoleType is not kCounterBoreHole.
    /// </summary>
    Parameter CBoreDiameter { get; }
    /// <summary>
    /// Property that returns the parameter controlling the CSink diameter. This property will return Nothing in the case where the HoleType is not kCounterSinkHole.
    /// </summary>
    Parameter CSinkDiameter { get; }
    /// <summary>
    /// Property that returns the parameter controlling the CBore depth. This property will return Nothing in the case where the HoleType is not kCounterBoreHole.
    /// </summary>
    Parameter CBoreDepth { get; }
    /// <summary>
    /// Property that returns the parameter controlling the CSink angle. This property will return Nothing in the case where the HoleType is not kCounterSinkHole.
    /// </summary>
    Parameter CSinkAngle { get; }
    /// <summary>
    /// Property that returns the parameter controlling the SpotFace diameter. This property will return Nothing in the case where the HoleType is not kSpotFaceHole.
    /// </summary>
    Parameter SpotFaceDiameter { get; }
    /// <summary>
    /// Property that returns the parameter controlling the SpotFace depth. This property will return Nothing in the case where the HoleType is not kSpotFaceHole.
    /// </summary>
    Parameter SpotFaceDepth { get; }
    /// <summary>
    /// Property that returns the set of that cap the end of the hole. In the cases where there aren't any such end faces this property will return Nothing.
    /// </summary>
    Faces EndFaces { get; }
    /// <summary>
    /// Property that returns a object that provides access to all of the faces created around the perimeter of the feature.
    /// </summary>
    Faces SideFaces { get; }
    /// <summary>
    /// Property that returns the Sketch object that contains the points the hole is based on.
    /// </summary>
    PlanarSketch Sketch { get; }
    /// <summary>
    /// Property that returns the set of points that define the centers of the holes of this feature.
    /// </summary>
    ObjectCollection HoleCenterPoints { get; set; }
    /// <summary>
    /// Property that returns an enum indicating how the extent of the feature is defined. This indicates the type of object returned by the Extent property.
    /// </summary>
    PartFeatureExtentEnum ExtentType { get; }
    /// <summary>
    /// Property that returns the object that defines how the extent of the feature is defined. The type of extent object that this property will return can be determined by using the ExtentType property.
    /// </summary>
    PartFeatureExtent Extent { get; }
    /// <summary>
    /// Gets depth of hole.
    /// </summary>
    double Depth { get; }
    /// <summary>
    /// Gets and sets the HoleClearanceInfo object associated with the hole.
    /// </summary>
    HoleClearanceInfo ClearanceInfo { get; set; }
    /// <summary>
    /// Read – only property that returns the Boolean flag indicating whether the hole is clearance hole or not.
    /// </summary>
    bool IsClearanceHole { get; }
    /// <summary>
    /// Gets depth of hole coutersink.
    /// </summary>
    double CSinkDepth { get; }
    /// <summary>
    /// Property that returns a constant indicating the type of hole placement.
    /// </summary>
    HolePlacementTypeEnum PlacementType { get; }
    /// <summary>
    /// Gets the Placement Definition for the hole feature.
    /// </summary>
    HolePlacementDefinition PlacementDefinition { get; set; }
    /// <summary>
    /// Gets and sets whether to extend the start of the hole feature.&nbsp;&nbsp;When set this to True the hole feature will be extended to cut the body that is adjacent to the hole feature starting face.
    /// </summary>
    bool ExtendStart { get; set; }
    /// <summary>
    /// Gets and sets hole drill point type.
    /// </summary>
    HoleDrillPointTypeEnum DrillPointType { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    HoleFeature NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the feature. The arguments allow control over which dependent objects are also deleted.
    /// </summary>
    /// <param name="RetainConsumedSketches">Optional input Boolean indicating if consumed sketches within the feature should be deleted. If the feature being deleted is not a sketch based feature this argument is ignored.</param>
    /// <param name="RetainDependentFeaturesAndSketches">Optional input Boolean that specifies if dependent features should be deleted. If there are no dependent features this argument is ignored.</param>
    /// <param name="RetainDependentWorkFeatures">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void Delete([In] bool? RetainConsumedSketches = false, [In] bool? RetainDependentFeaturesAndSketches = false, [In] bool? RetainDependentWorkFeatures = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StyleSourceType">StyleSourceType</param>
    [PreserveSig]
    RenderStyle GetRenderStyle([Out] out StyleSourceTypeEnum StyleSourceType);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StyleSourceType">StyleSourceType</param>
    /// <param name="RenderStyle">RenderStyle</param>
    [PreserveSig]
    void SetRenderStyle([In] StyleSourceTypeEnum StyleSourceType, [In] [MarshalAs(UnmanagedType.Struct)] object? RenderStyle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that repositions the end-of-part marker relative to the object this method is called from.
    /// </summary>
    /// <param name="Before">Input Boolean that indicates if the end of part marker should be immediately before or after this work feature. A value of True indicates before and False indicates after.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Method that removes the specified participant from the assembly feature. This method fails for features in a part.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the participant to be removed. An error occurs if the input ComponentOccurrence is not a participant.</param>
    [PreserveSig]
    void RemoveParticipant([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Parameter">Parameter</param>
    /// <param name="ComparisonType">ComparisonType</param>
    /// <param name="Expression">Expression</param>
    [PreserveSig]
    bool GetSuppressionCondition([Out] [MarshalAs(UnmanagedType.Interface)] out Parameter Parameter, [Out] out ComparisonTypeEnum ComparisonType, [Out] [MarshalAs(UnmanagedType.Struct)] out object Expression);
    /// <summary>
    /// Method that sets the suppression condition for the feature.
    /// </summary>
    /// <param name="Parameter">Parameter object that specifies the parameter whose value is to be checked for feature suppression.</param>
    /// <param name="ComparisonType">ComparisonTypeEnum that specifies the type of comparison. Valid types are kEqualToComparison, kNotEqualToComparison, kLessThanComparison, kGreaterThanComparison, kLessThanOrEqualToComparison, kGreaterThanOrEqualToComparison.</param>
    /// <param name="Expression">Specifies the expression used for the comparison with the parameter value. This can either be a string, a value or a parameter object. If a value is input, the database units for the units defined by the parameter are used. For instance, if the parameter defines length units, the value is assumed to be in centimeters. If a string is input, the units can be specified as part of the string or it will default to the current units of the document. For instance, if the parameter defines length units, the current length units of the document are used.</param>
    [PreserveSig]
    void SetSuppressionCondition([In] [MarshalAs(UnmanagedType.Interface)] Parameter Parameter, [In] ComparisonTypeEnum ComparisonType, [In] [MarshalAs(UnmanagedType.Struct)] object Expression);
    /// <summary>
    /// Method that sets a collection of SurfaceBody objects affected by this feature.
    /// </summary>
    /// <param name="Bodies">ObjectCollection of SurfaceBody objects.</param>
    [PreserveSig]
    void SetAffectedBodies([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Bodies);
    /// <summary>
    /// Method that changes the hole to be a drilled hole type.
    /// </summary>
    [PreserveSig]
    void SetDrilled();
    /// <summary>
    /// Method that changes the hole to be a counterbore hole type. If the hole is already a counterbore type you can access and modify the counterbore parameters using the CBoreDiameter and CBoreDepth properties of the HoleFeature object.
    /// </summary>
    /// <param name="CBoreDiameter">Input Variant that defines the diameter of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units.</param>
    /// <param name="CBoreDepth">Input Variant that defines the depth of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetCBore([In] [MarshalAs(UnmanagedType.Struct)] object CBoreDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDepth);
    /// <summary>
    /// Method that changes the hole to be a countersink hole type. If the hole is already a countersink type you can access and modify the counterbore parameters using the CSinkDiameter and CSinkAngle properties of the HoleFeature object.
    /// </summary>
    /// <param name="CSinkDiameter">Input Variant that defines the diameter of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CSinkAngle">Input Variant that defines the angle of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    [PreserveSig]
    void SetCSink([In] [MarshalAs(UnmanagedType.Struct)] object CSinkDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkAngle);
    /// <summary>
    /// Method that changes the hole to be a spotface hole type. If the hole is already a spotface type you can access and modify the spotface parameters using the SpotFaceDiameter and SpotFaceDepth properties of the HoleFeature object. This method will fail of the hole contains a tapered thread.
    /// </summary>
    /// <param name="SpotFaceDiameter">Input Variant that defines the diameter of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="SpotFaceDepth">Input Variant that defines the depth of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    [PreserveSig]
    void SetSpotFace([In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDepth);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Depth">Depth</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    void SetDistanceExtent([In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    [PreserveSig]
    void SetToFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace);
    /// <summary>
    /// Method that specifies the termination type for the hole feature. Hole features can be specified to terminate at a particular distance or object, or can be specified as "through all," which means it extends through all faces of the feature. This method defines a through-all termination type.
    /// </summary>
    /// <param name="ExtentDirection">Input argument identifying the direction in which to extend the hole feature.</param>
    [PreserveSig]
    void SetThroughAllExtent([In] PartFeatureExtentDirectionEnum ExtentDirection);
    /// <summary>
    /// Method that adds the specified participant to the assembly feature. This method fails for features in a part.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the participant to be added. An error occurs if the input ComponentOccurrence is not a leaf occurrence.</param>
    [PreserveSig]
    void AddParticipant([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Method that specifies the termination type for the hole feature. Hole features can be specified to terminate at a particular distance or object, or can be specified as through all, which means it extends through all faces of the feature. This method defines th.
    /// </summary>
    /// <param name="Depth">Input Variant that specifies the depth to which to extend the hole feature.  This can be either a numeric value or a string.  A parameter for this value will be created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards.  Valid input is kPositive, kNegative, or kSymmetric.  kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    [PreserveSig]
    void SetDistanceExtent2([In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that specifies the termination type for the hole feature. Hole features can be specified to terminate at a particular distance or object, or can be specified as through all, which means it extends through all faces of the feature. This method defines th.
    /// </summary>
    /// <param name="ToFace">Input Object that defines the to face.  This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the “to face” should be extended to contain the extents of the profile.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    [PreserveSig]
    void SetToFaceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
}

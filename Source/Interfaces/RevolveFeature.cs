namespace Oblikovati.API;

/// <summary>
/// The RevolveFeature object represents revolved modeling features. The properties and methods listed below are in addition to those supported by the Feature object.
/// </summary>
public interface RevolveFeature
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
    /// Gets and sets the entity used to define the axis of revolution.
    /// </summary>
    object AxisEntity { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SketchLine _AxisEntity { get; set; }
    /// <summary>
    /// Property that returns the set of that cap one end of the revolution that are coincident with the sketch plane. In the case of a symmetric revolution these faces are the ones on the positive normal side of the sketch plane. In the cases where there aren't any start faces this property will return Nothing.
    /// </summary>
    Faces StartFaces { get; }
    /// <summary>
    /// Property that returns the set of that cap one end of the revolution that are coincident with the sketch plane. The end faces are those not coincident to the sketch plane of the feature's profile. In the case of a symmetric revolution these faces are the ones on the negative normal side of the sketch plane. In the cases where there aren't any end faces this property will return Nothing.
    /// </summary>
    Faces EndFaces { get; }
    /// <summary>
    /// Property that returns a object that provides access to all of the faces created around the perimeter of the feature.
    /// </summary>
    Faces SideFaces { get; }
    /// <summary>
    /// Gets and sets the Profile that defines the shape of the feature.
    /// </summary>
    Profile Profile { get; set; }
    /// <summary>
    /// Property that gets and sets the type of operation used to add the feature to the model. Valid input is kJoinOperation, kCutOperation, kIntersectOperation, or kSurfaceOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Property that returns an enum indicating how the extent of the feature is defined. This indicates the type of object returned by the Extent property. The valid possibilities returned are kAngleExtent and kFullSweepExtent.
    /// </summary>
    PartFeatureExtentEnum ExtentType { get; }
    /// <summary>
    /// Property that returns the object that defines how the extent of the feature is defined. The type of extent object that this property will return can be determined by using the ExtentType property.
    /// </summary>
    PartFeatureExtent Extent { get; }
    /// <summary>
    /// Property that returns the PartFeatureExtent object that defines how the second direction extent of the feature is defined. The type of extent object returned can be determined by using the ExtentTwoType property. This property returns Nothing if the IsTwoDirectional property returns False.
    /// </summary>
    PartFeatureExtent ExtentTwo { get; }
    /// <summary>
    /// Property that returns an enum indicating how the second direction extent of the feature is defined. This indicates the type of object returned by the Extent property. This property returns a failure if the IsTwoDirectional property \returns False.
    /// </summary>
    PartFeatureExtentEnum ExtentTwoType { get; }
    /// <summary>
    /// Property that returns whether extents have been defined in two directions for the revolve. If this property returns True, the ExtentTwoType and ExtentTwo properties can be used to query details about the second direction extent.
    /// </summary>
    bool IsTwoDirectional { get; }
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
    /// Method that changes the angle of the revolve to a full (360-degree) revolution.
    /// </summary>
    [PreserveSig]
    void SetFullExtent();
    /// <summary>
    /// Method that changes the extents of the revolution to the given angle
    /// </summary>
    /// <param name="Angle">Defines the sweep angle of the revolution. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="ExtentDirection">constant that indicates the direction of the sweep. Valid input is kPositive, kNegative, or kSymmetric. The sweep direction is defined relative to the natural direction of the axis entity. kPositive defines the sweep to be in a positive direction using the right-hand rule about the axis.</param>
    [PreserveSig]
    void SetAngleExtent([In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] PartFeatureExtentDirectionEnum ExtentDirection);
    /// <summary>
    /// Method that changes the extents to be 'from and to face' extents.
    /// </summary>
    /// <param name="FromFace">Input Object that defines the 'from face'. This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendFromFace">Input Boolean that defines whether the 'from face' should be extended to contain the extents of the profile.</param>
    /// <param name="ToFace">Input Object that defines the 'to face'. This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the profile.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositiveExtentDirection or kNegativeExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="MinimumSolution">Input Boolean that defines whether the feature terminates on the nearest valid face when there are multiple options for valid termination faces.</param>
    [PreserveSig]
    void SetFromToExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] bool ExtendFromFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] bool MinimumSolution);
    /// <summary>
    /// Method that changes the extents to be 'to face' extents.
    /// </summary>
    /// <param name="ToFace">Input Object that defines the 'to face'. This can be either a Face or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the profile.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositiveExtentDirection, kNegativeExtentDirection or kSymmetricExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="MinimumSolution">Input Boolean that defines whether the feature terminates on the nearest valid face when there are multiple options for valid termination faces.</param>
    [PreserveSig]
    void SetToFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] bool MinimumSolution);
    /// <summary>
    /// Method that changes the extents to be 'to next face' extents.
    /// </summary>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositiveExtentDirection or kNegativeExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="Terminator">Input SurfaceBody object that specifies the solid or the surface on which to terminate the revolution.</param>
    [PreserveSig]
    void SetToNextExtent([In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Terminator);
    /// <summary>
    /// Method that adds the specified participant to the assembly feature. This method fails for features in a part.
    /// </summary>
    /// <param name="Occurrence">ComponentOccurrence object that specifies the participant to be added. An error occurs if the input ComponentOccurrence is not a leaf occurrence.</param>
    [PreserveSig]
    void AddParticipant([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
}

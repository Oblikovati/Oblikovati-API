namespace Oblikovati.API;

/// <summary>
/// The BendPartFeature object represents an existing bend part feature in an Inventor part document.
/// </summary>
public interface BendPartFeature
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
    /// Property that gets and sets the bend direction.
    /// </summary>
    bool BendInSketchNormalDirection { get; set; }
    /// <summary>
    /// Property that gets and sets the sketch line that represents the bend line.
    /// </summary>
    SketchLine BendLine { get; set; }
    /// <summary>
    /// Property that gets and sets whether minimum bend should be applied.
    /// </summary>
    bool BendMinimum { get; set; }
    /// <summary>
    /// Property that returns the type of the bend part feature. The valid return values are kArcLengthAndAngleBendPart, kRadiusAndAngleBendPart and kRadiusAndArcLengthBendPart.
    /// </summary>
    BendPartTypeEnum BendPartType { get; }
    /// <summary>
    /// Property that gets and sets the bend side.
    /// </summary>
    PartFeatureExtentDirectionEnum BendSide { get; set; }
    /// <summary>
    /// Input Variant that defines the first input for the bend arc.
    /// </summary>
    Parameter InputOne { get; }
    /// <summary>
    /// Input Variant that defines the second input for the bend arc.
    /// </summary>
    Parameter InputTwo { get; }
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
    /// Method that edits the bend part feature using the new inputs.
    /// </summary>
    /// <param name="BendLine">Input SketchLine object that represents the bend line.</param>
    /// <param name="BendPartType">Input constant that indicates the type of the bend part feature.
    /// The BendPartType argument specifies the type of the input values used to define the bend arc. The values specified for the InputOne and InputTwo arguments will depend on the value specified for this argument.
    /// The valid input is one of the constants in BendPartTypeEnum: kArcLengthAndAngleBendPart, kRadiusAndAngleBendPart and kRadiusAndArcLengthBendPart.
    /// The following table describes how this argument determines the values that need to be specified for the InputOne and InputTwo arguments:
    /// BendPartType InputOne InputOne
    /// kArcLengthAndAngleBendPart Arc Length Angle
    /// kRadiusAndAngleBendPart Radius Angle
    /// kRadiusAndArcLengthBendPart Radius Arc Length
    /// For example, if kArcLengthAndAngleBendPart is specified for this argument, then the arc length value should be specified in the InputOne argument and the angle value should be specified in the InputTwo argument.</param>
    /// <param name="InputOne">Input Variant that defines the first input for the bend arc.
    /// The InputOne parameter can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter.
    /// The type of the input value will be determined by the BendPartType argument. The following table shows what this input value should be based on the BendPartType argument:
    /// BendPartType InputOne
    /// kArcLengthAndAngleBendPart Arc Length
    /// kRadiusAndAngleBendPart Radius
    /// kRadiusAndArcLengthBendPart Radius
    /// For example, if the bend is defined using the arc length and angle as indicated by the BendPartType argument being kArcLengthAndAngleBendPart, then this argument should be used to specify the arc length of the bend arc. Similarly, if the bend is defined using the radius and angle as indicated by the BendPartType argument being kRadiusAndAngleBendPart, then this argument should be used to specify the radius of the bend arc.
    /// If a value is input, the units are the default database units (centimeters for distance and radians for angle). If a string is input, the units can be specified as part of the string or it will default to the current unit type for the document.</param>
    /// <param name="InputTwo">Input Variant that defines the second input for the bend arc.
    /// The InputTwo parameter can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter.
    /// The type of the input value will be determined by the BendPartType argument. The following table shows what this input value should be based on the BendPartType argument:
    /// BendPartType InputTwo
    /// kArcLengthAndAngleBendPart Angle
    /// kRadiusAndAngleBendPart Angle
    /// kRadiusAndArcLengthBendPart Arc Length
    /// For example, if the bend is defined using the arc length and angle as indicated by the BendPartType argument being kArcLengthAndAngleBendPart, then this argument should be used to specify the angle of the bend arc. Similarly, if the bend is defined using the radius and arc length as indicated by the BendPartType argument being kRadiusAndArcLengthBendPart, then this argument should be used to specify the arc length of the bend arc. If a value is input, the units are the default database units (centimeters for distance and radians for angle). If a string is input, the units can be specified as part of the string or it will default to the current unit type for the document.</param>
    /// <param name="BendSide">Input constant that indicates which side of the model to bend.
    /// The bend side is specified with respect to the input bend line (sketch line), i.e. whether the model to the left, right or both sides of the bend line should be bent. The left side is the natural normal direction at any point on the sketch line (the cross-product of the vector representing the direction of the sketch line and the vector representing the sketch normal). The right side refers to the direction opposite to that of the natural normal. The following figure demonstrates an example of how the bend side is determined based on the normal direction of the sketch line.
    /// The figure represents a model in which a sketch plane has been drawn on the rectangular side face. The sketch plane consists of a single sketch line which represents the bend line. The sketch plane normal direction is perpendicular to the face and coming out of the model. The direction of the sketch line which can be inferred from the start point and end points of the sketch line is towards the right. Therefore, the normal vector at any point on the sketch line is pointing in the downward direction (imagine standing on the normal side of the sketch plane and viewing in the direction of the sketch line, the normal of the sketch line will be towards your right). For the bend part feature, the left side of the bend corresponds to this normal direction of the sketch line. As indicated by the preview in the figure, when the left side is specified, the model in the normal direction of the sketch line is selected for the bend.
    /// The valid input is one of the constants in PartFeatureExtentDirectionEnum: kNegativeExtentDirection, kPositiveExtentDirection or kSymmetricExtentDirection.
    /// If kNegativeExtentDirection is specified, the model on the left side of the input bend line will be bent.
    /// If kPositiveExtentDirection is specified, the model on the right side of the input bend line will be bent.
    /// If kSymmetricExtentDirection is specified, the model on both sides of the input bend line will be bent.</param>
    /// <param name="BendInSketchNormalDirection">Input boolean that indicates the bend direction. If True is specified, the model will be bent in the direction normal to the sketch on which the input bend line (sketch line) exists. If False is specified, the model will be bent in the direction opposite to the sketch normal. If no value is explicitly specified, the default value of True will be used.</param>
    /// <param name="Body">Optional input SurfaceBody object that specifies the solid body to bend.  If not specified, the body used for creating the feature is used.</param>
    /// <param name="BendMinimum">Optional Input boolean that indicates whether minimum bend should be applied. If True is specified, minium bend will be applied. If no value is explicitly specified, the default value of True will be used.</param>
    [PreserveSig]
    void Edit([In] [MarshalAs(UnmanagedType.Interface)] SketchLine BendLine, [In] BendPartTypeEnum BendPartType, [In] [MarshalAs(UnmanagedType.Struct)] object InputOne, [In] [MarshalAs(UnmanagedType.Struct)] object InputTwo, [In] PartFeatureExtentDirectionEnum BendSide, [In] bool BendInSketchNormalDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? Body = default, [In] bool? BendMinimum = true);
}

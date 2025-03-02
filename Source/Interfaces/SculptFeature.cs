namespace Oblikovati.API;

/// <summary>
/// The SculptFeature object represents sculpt modeling features.
/// </summary>
public interface SculptFeature
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool FillOperation { get; set; }
    /// <summary>
    /// Gets and sets the set of surfaces and their respective directions associated with the sculpt feature.
    /// </summary>
    ObjectCollection Surfaces { get; set; }
    /// <summary>
    /// Gets and sets the type of operation used to add the feature to the model.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
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
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
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
}

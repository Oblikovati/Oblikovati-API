namespace Oblikovati.API;

/// <summary>
/// ModelToleranceFeatureDefinition Object.
/// </summary>
public interface ModelToleranceFeatureDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelToleranceFeature Parent { get; }
    /// <summary>
    /// Returns the ModelAnnotationsEnumerator collection that contains all the ModelAnnotation objects consumed by the tolerance annotation.
    /// </summary>
    ModelAnnotationsEnumerator Annotations { get; }
    /// <summary>
    /// Gets or sets the faces the model tolerance feature is associative with.
    /// </summary>
    FaceCollection Faces { get; set; }
    /// <summary>
    /// Gets or sets the model tolerance feature type.
    /// </summary>
    ModelToleranceFeatureTypeEnum FeatureType { get; set; }
    /// <summary>
    /// Returns the subfeatures in the model tolerance feature.
    /// </summary>
    ModelToleranceFeaturesEnumerator SubFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatum ModelDatum { get; set; }
    /// <summary>
    /// Adds a new member to the model tolerance feature.
    /// </summary>
    [PreserveSig]
    void AddAnnotation([In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotation ModelAnnotation);
    /// <summary>
    /// Removes a member from the model tolerance feature.
    /// </summary>
    [PreserveSig]
    void RemoveAnnotation([In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotation ModelAnnotation);
    /// <summary>
    /// Creates a copy of this ModelToleranceFeatureDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelToleranceFeatureDefinition Copy();
    /// <summary>
    /// Adds a new subfeature to the model tolerance feature.
    /// </summary>
    [PreserveSig]
    void AddSubFeature([In] [MarshalAs(UnmanagedType.Interface)] ModelToleranceFeature ModelToleranceFeature);
    /// <summary>
    /// Removes a subfeature from the model tolerance feature.
    /// </summary>
    [PreserveSig]
    void RemoveSubFeature([In] [MarshalAs(UnmanagedType.Interface)] ModelToleranceFeature ModelToleranceFeature);
}

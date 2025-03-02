namespace Oblikovati.API;

/// <summary>
/// ModelToleranceFeature Object.
/// </summary>
public interface ModelToleranceFeature
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns string that uniquely identifies the client.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelToleranceFeatureDefinition Definition { get; set; }
    /// <summary>
    /// Returns the current health status of the tolerance feature.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Returns the parent ModelToleranceFeature object if this ModelToleranceFeature is a sub feature of it.
    /// </summary>
    ModelToleranceFeature ParentToleranceFeature { get; }
    /// <summary>
    /// Gets or sets the name of the tolerance feature.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets or sets the visibility of the tolerance feature.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets all faces associated with the tolerance feature and its subfeatures.
    /// </summary>
    FaceCollection AllFaces { get; }
    /// <summary>
    /// Gets or sets the constrained status of the tolerance feature.
    /// </summary>
    ModelToleranceFeatureConstrainedStatusEnum ConstrainedStatus { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumFeature DatumFeature { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void PseudoDelete();
}

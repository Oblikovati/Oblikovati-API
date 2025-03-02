namespace Oblikovati.API;

/// <summary>
/// ModelDatumReferenceFrame Object.
/// </summary>
public interface ModelDatumReferenceFrame
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
    /// Gets and sets the ModelDatumReferenceFrameDefinition associative with this object.
    /// </summary>
    ModelDatumReferenceFrameDefinition Definition { get; set; }
    /// <summary>
    /// Returns the current health status of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Gets or sets the name of the tolerance feature.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets or sets the visibility of the object.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that returns the identifier of the object.
    /// </summary>
    string Identifier { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Deletes the model datum reference frame.
    /// </summary>
    [PreserveSig]
    void Delete();
}

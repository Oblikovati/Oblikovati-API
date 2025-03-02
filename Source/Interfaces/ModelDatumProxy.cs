namespace Oblikovati.API;

/// <summary>
/// ModelDatumProxy Object.
/// </summary>
public interface ModelDatumProxy
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
    /// Gets and sets the ModelDatumDefinition associated with this ModelDatum object.
    /// </summary>
    ModelDatumDefinition Definition { get; set; }
    /// <summary>
    /// Returns the current health status of the model datum.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Returns a ModelDatumTargets collection object providing access to the existing model datum targets in this model datum.
    /// </summary>
    ModelDatumTargets ModelDatumTargets { get; }
    /// <summary>
    /// Gets or sets the name of this object.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    ModelDatum NativeObject { get; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Deletes this object.
    /// </summary>
    [PreserveSig]
    void Delete();
}

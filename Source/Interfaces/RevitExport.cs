namespace Oblikovati.API;

/// <summary>
/// RevitExport Object.
/// </summary>
public interface RevitExport
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that returns the RevitExport definition that defines the current state of the RevitExport.
    /// </summary>
    RevitExportDefinition Definition { get; set; }
    /// <summary>
    /// Read-only property that returns the full filename of the Revit model file that relates with this RevitExport object.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Read-only property that gets browser node name of RevitExport..
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the RevitExport browser node.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that updates the Revit model file that relates with this RevitExport object.
    /// </summary>
    [PreserveSig]
    void Update();
}

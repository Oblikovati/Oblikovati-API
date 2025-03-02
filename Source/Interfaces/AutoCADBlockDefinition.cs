namespace Oblikovati.API;

/// <summary>
/// The AutoCADBlockDefinition object represents an AutoCAD block definition.
/// </summary>
public interface AutoCADBlockDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that specifies if the definition is being referenced or not. A definition is referenced when an instance of the definition has been placed on a sheet. A referenced definition cannot be deleted.
    /// </summary>
    bool IsReferenced { get; }
    /// <summary>
    /// Property that indicates the name of this object or instance.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Property returning the parent DrawingDocument object.
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TargetDocument">TargetDocument</param>
    /// <param name="ReplaceExisting">ReplaceExisting</param>
    [PreserveSig]
    AutoCADBlockDefinition CopyTo([In] [MarshalAs(UnmanagedType.Interface)] _DrawingDocument TargetDocument, [In] bool? ReplaceExisting = false);
    /// <summary>
    /// Method that deletes the AutoCADBlockDefinition object. This method will fail in the case where the definition is being referenced. This can be determined by using the IsReferenced property.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tags">Tags</param>
    /// <param name="Prompts">Prompts</param>
    [PreserveSig]
    void GetPromptTags();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tags">Tags</param>
    /// <param name="Prompts">Prompts</param>
    [PreserveSig]
    void GetPromptTags([Out] [MarshalAs(UnmanagedType.Struct)] out object Tags, [Out] [MarshalAs(UnmanagedType.Struct)] out object Prompts);
}

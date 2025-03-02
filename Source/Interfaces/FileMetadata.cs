namespace Oblikovati.API;

/// <summary>
/// A container object for defining the name and file properties for an Inventor file.
/// </summary>
public interface FileMetadata
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the full file name (with the extension and the path).
    /// </summary>
    string FullFileName { get; set; }
    /// <summary>
    /// Gets and sets just the file name portion (no extension and no path) of the FullFileName string.
    /// </summary>
    string FileName { get; set; }
    /// <summary>
    /// Gets and sets whether the file name has been overridden. This property should be set by the (PDM) application that overrides the file name to indicate that the overridden file name should not be changed by the command or the user. Defaults to False.
    /// </summary>
    bool FileNameOverridden { get; set; }
    /// <summary>
    /// Gets and sets name of the file.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets and sets whether the display name has been overridden. This property should be set by the (PDM) application that overrides the display name to indicate that the overridden display name should not be changed by the command or the user. Defaults to False.
    /// </summary>
    bool DisplayNameOverridden { get; set; }
    /// <summary>
    /// Gets and sets an XML string containing the values for file properties.
    /// </summary>
    string FileProperties { get; set; }
    /// <summary>
    /// Gets and sets the document object for which the file name and properties are being requested. This can be set to Nothing if the document hasn’t yet been created.
    /// </summary>
    _Document Document { get; set; }
    /// <summary>
    /// Gets and sets the full filename of the file used as the template when create a new file.
    /// </summary>
    string TemplateFileName { get; set; }
    /// <summary>
    /// Gets and sets the default BOM structure.
    /// </summary>
    BOMStructureEnum BOMStructure { get; set; }
}

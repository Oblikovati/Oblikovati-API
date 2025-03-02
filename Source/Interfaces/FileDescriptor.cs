namespace Oblikovati.API;

/// <summary>
/// The FileDescriptor object represents a reference to an Autodesk Inventor file or a foreign file.
/// </summary>
public interface FileDescriptor
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
    /// Property that returns the parent File object of this descriptor.
    /// </summary>
    File Parent { get; }
    /// <summary>
    /// Property that returns the full path name of the file as currently found (or the last known full file name, if the reference is not found).
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Gets the relative file name from the resolved location of this reference. This property is only valid when ReferenceMissing is false.
    /// </summary>
    string RelativeFileName { get; }
    /// <summary>
    /// Gets the type of location this reference was resolved in. This property is only valid when ReferenceMissing is false.
    /// </summary>
    LocationTypeEnum LocationType { get; }
    /// <summary>
    /// Gets the name of the library this reference was resolved in. This property is only valid when ReferenceMissing is false.
    /// </summary>
    string LibraryName { get; }
    /// <summary>
    /// Property that returns the File object being referenced. The property returns Nothing for foreign file references.
    /// </summary>
    File ReferencedFile { get; }
    /// <summary>
    /// Property that returns type of the referenced file.
    /// </summary>
    FileTypeEnum ReferencedFileType { get; }
    /// <summary>
    /// Property that returns the save counter associated with the file.
    /// </summary>
    int FileSaveCounter { get; }
    /// <summary>
    /// Property that returns whether the referenced file is missing (unresolved).
    /// </summary>
    bool ReferenceMissing { get; }
    /// <summary>
    /// Gets whether the link to this file is disabled.
    /// </summary>
    bool ReferenceDisabled { get; }
    /// <summary>
    /// Gets whether the internal name of the referenced file is different from the last time the parent (referencing) file was saved. A value of True indicates that the currently referenced file has a different internal name than the originally referenced file.
    /// </summary>
    bool ReferenceInternalNameDifferent { get; }
    /// <summary>
    /// Gets whether the file path or the file name of the referenced file is different from the last time the parent (referencing) file was saved. A value of True indicates that the currently referenced file has a different file path or file name.
    /// </summary>
    bool ReferenceLocationDifferent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ResolvedFullFileName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileOwnershipEnum OwnershipType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ReferencedFileInternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ReferenceReplaced { get; }
    /// <summary>
    /// Similar in nature to the Logical Filename, except that the application interprets and perhaps controls the location and access to the file being referenced.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    byte[,] GetCustomLogicalFileName();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Value">Value</param>
    [PreserveSig]
    void PutCustomLogicalFileName([In] [MarshalAs(UnmanagedType.SafeArray)] ref byte[,] Value);
    /// <summary>
    /// Method that replaces the referenced file.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name to which the reference should be switched.</param>
    [PreserveSig]
    void ReplaceReference([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}

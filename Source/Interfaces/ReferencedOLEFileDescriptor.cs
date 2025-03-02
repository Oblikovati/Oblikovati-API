namespace Oblikovati.API;

/// <summary>
/// The ReferencedOLEFileDescriptor object represents an OLE reference to another file.
/// </summary>
public interface ReferencedOLEFileDescriptor
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent Document (in Inventor) or ApprenticeServerDocument (in Apprentice).
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the type of OLE reference this represents. Valid values are kOLEDocumentEmbeddingObject, kOLEDocumentLinkObject, or kOLEDocumentUnknownObject.
    /// </summary>
    OLEDocumentTypeEnum OLEDocumentType { get; }
    /// <summary>
    /// Property that returns the logical name of the reference. This is essentially the relative path used by Autodesk Inventor to find the file using the project paths as the search paths.
    /// </summary>
    string LogicalName { get; }
    /// <summary>
    /// Gets/Sets the display name of the file as currently found (or the last known display name, if reference is not found).
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Property that returns the full path name of the file as currently found (or the last known full file name, if reference is not found). This property returns a null string for an embedding descriptor.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Property that returns the current status of the file reference. This property returns kUpToDateReference for embeddings.
    /// </summary>
    ReferenceStatusEnum ReferenceStatus { get; }
    /// <summary>
    /// Property that returns the time stamp on the file when it was last reviewed. This property returns Nothing for embeddings.
    /// </summary>
    object LastKnownFileTime { get; }
    /// <summary>
    /// Property that returns the corresponding FileDescriptor object. The ReplaceReference method on the returned object can be used to replace the referenced file. This property returns Nothing for embeddings.
    /// </summary>
    FileDescriptor FileDescriptor { get; }
    /// <summary>
    /// Gets/Sets visible of the file reference in 3rdPartyFolder.
    /// </summary>
    bool BrowserVisible { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/Sets whether the linked/embedded object is visible in the graphics window.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets/Sets whether the referenced file is monitored by Inventor for changes.
    /// </summary>
    IntPtr ReferenceMonitoring { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Verb">Verb</param>
    /// <param name="OLEDocumentObject">OLEDocumentObject</param>
    [PreserveSig]
    void Activate([In] OLEVerbEnum Verb, [Out] [MarshalAs(UnmanagedType.IUnknown)] out object OLEDocumentObject);
    /// <summary>
    /// Method that deletes the reference file attachment.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}

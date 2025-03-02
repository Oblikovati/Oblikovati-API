namespace Oblikovati.API;

/// <summary>
/// Object that represents a reference held within this Document, to a file.
/// </summary>
public interface ReferencedFileDescriptor
{
    /// <summary>
    /// Property that returns the type of document being referenced.
    /// </summary>
    DocumentTypeEnum DocumentType { get; }
    /// <summary>
    /// Property that returns the display name of the document. This is the name that is displayed for a document when it is open within Autodesk Inventor. By default, it is the same as the filename, but it can be changed using the DisplayName property of the Document and ApprenticeServerDocument objects.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the full filename of the referenced file.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Property that returns the current value of the file save counter of the referenced document. This counter is incremented whenever the referenced file is saved.
    /// </summary>
    int FileSaveCounter { get; }
    /// <summary>
    /// Property that returns the Document object being referenced.
    /// </summary>
    object ReferencedDocument { get; }
    /// <summary>
    /// Property returning a constant indicating the status of the file reference.
    /// </summary>
    ReferenceStatusEnum ReferenceStatus { get; }
    /// <summary>
    /// Gets the corresponding DocumentDescriptor for this descriptor.
    /// </summary>
    DocumentDescriptor DocumentDescriptor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DifferentDocument { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DocumentFound { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    [PreserveSig]
    void GetLogicalFileName([Out] [MarshalAs(UnmanagedType.BStr)] out string RelativeFileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LibraryName);
    /// <summary>
    /// Posts the logical file name of the referenced file indirectly, by supplying its full filename.
    /// </summary>
    [PreserveSig]
    void PutLogicalFileNameUsingFull([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Obtains the custom logical name of the file saved in this Document.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    byte[,] GetCustomLogicalFileName();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CustomLogicalFileName">CustomLogicalFileName</param>
    [PreserveSig]
    void PutCustomLogicalFileName([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] CustomLogicalFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    [PreserveSig]
    void _PutLogicalFileName([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    void PutLogicalFileNameUsingFullSpl([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}

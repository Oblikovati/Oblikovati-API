namespace Oblikovati.API;

/// <summary>
/// The ReferencedOLEFileDescriptors collection object contains information about all linked and embedded files within a document. Embeddings are not accessible in Apprentice.
/// </summary>
public interface ReferencedOLEFileDescriptors : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified ReferencedOLEFileDescriptor object from the collection. This is the default property of the ReferencedOLEFileDescriptors collection object.
    /// </summary>
    ReferencedOLEFileDescriptor Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ReferencedOLEFileDescriptor object from the collection.
    /// </summary>
    ReferencedOLEFileDescriptor ItemByName { get; }
    /// <summary>
    /// Method that creates a new ReferencedOLEFileDescriptor by linking/embedding a file. The newly created ReferencedOLEFileDescriptor is returned.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of the file.</param>
    /// <param name="Type">Constant indicating the OLE document type.</param>
    /// <returns></returns>
    [PreserveSig]
    ReferencedOLEFileDescriptor Add([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] OLEDocumentTypeEnum? Type = OLEDocumentTypeEnum.kOLEDocumentLinkObject);
}

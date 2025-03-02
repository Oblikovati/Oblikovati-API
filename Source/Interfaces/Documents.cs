namespace Oblikovati.API;

/// <summary>
/// The Document collection object contains all in-memory Inventor documents.
/// </summary>
public interface Documents : IEnumerable
{
    /// <summary>
    /// Returns the specified object from the collection. This is the default property of the DocumentsEnumerator object.
    /// </summary>
    _Document this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified Document object from the collection.
    /// </summary>
    _Document ItemByName { get; }
    /// <summary>
    /// Gets the collection of visible documents.
    /// </summary>
    DocumentsEnumerator VisibleDocuments { get; }
    /// <summary>
    /// Query Loaded documents.
    /// </summary>
    int LoadedCount { get; }
    /// <summary>
    /// Creates a new of the specified type. Optionally, a template file can be specified instead.
    /// </summary>
    /// <param name="DocumentType">Input that specifies the type of document to add. If the DocumentType argument is specified to be kDrawingDocumentObject, the method will honor the application option to decide whether to use an idw template or an Inventor DWG template.</param>
    /// <param name="TemplateFileName">Input String that specifies the name of the template file.</param>
    /// <param name="CreateVisible">Optional input Boolean that specifies whether the created document or template is visible.</param>
    /// <returns></returns>
    [PreserveSig]
    _Document Add([In] DocumentTypeEnum DocumentType, [In] [MarshalAs(UnmanagedType.BStr)] string? TemplateFileName = "", [In] bool? CreateVisible = true);
    /// <summary>
    /// Method that opens the specified Oblikovati document.
    /// </summary>
    /// <param name="FullDocumentName">Input String that specifies the full document name of the document to open. If only the FullFileName is specified for part and assembly documents, the master document within the file is opened.</param>
    /// <param name="OpenVisible">Optional input Boolean that specifies whether to open the document as visible.</param>
    /// <returns></returns>
    [PreserveSig]
    _Document Open([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] bool? OpenVisible = true);
    /// <summary>
    /// Method that opens the specified Oblikovati document.
    /// </summary>
    /// <param name="FullDocumentName">Input String that specifies the full document name of the document to open. If only the FullFileName is specified for an assembly, the master document within the file is opened.</param>
    /// <param name="Options">Input NameValueMap object that specifies additional options for open. (An empty NameValueMap object can be provided). See Remarks section for the valid options.</param>
    /// <param name="OpenVisible">Optional input Boolean that specifies whether to open the document as visible. If not specified, the document is opened visible.</param>
    /// <returns></returns>
    [PreserveSig]
    _Document OpenWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] bool? OpenVisible = true);
    /// <summary>
    /// Method that closes all the documents in the current Oblikovati session. Changes are not saved to any of the documents. In other words, if there are dirty documents in the collection, changes made to them will be lost.
    /// </summary>
    /// <param name="UnreferencedOnly">Optional input Boolean that indicates whether to close only the unreferenced documents. If not specified, a value of False is assumed and all documents are closed. Examples of unreferenced documents: * Create a new assembly, place an instance of a part "block.ipt", (provided block.ipt is not open in it's own window) and then delete the instance in the assembly. At this point, block.ipt is an unreferenced document. * Set the Suppressed property of a ComponentOccurrence to True within an API Transaction (or a ChangeProcessor). Assuming that the document that this occurrence was referencing is not referenced elsewhere, it becomes an "unreferenced" document.</param>
    [PreserveSig]
    void CloseAll([In] bool? UnreferencedOnly = false);
}

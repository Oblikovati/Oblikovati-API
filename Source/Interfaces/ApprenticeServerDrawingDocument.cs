namespace Oblikovati.API;

/// <summary>
/// The ApprenticeServerDrawingDocument object represents the drawing document within an Apprentice context, and provides access to the Sheets in the drawing.
/// </summary>
public interface ApprenticeServerDrawingDocument
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this document.
    /// </summary>
    DocumentTypeEnum DocumentType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ComponentDefinitions ComponentDefinitions { get; }
    /// <summary>
    /// Gets the primary that resides in this file.
    /// </summary>
    ComponentDefinition ComponentDefinition { get; }
    /// <summary>
    /// Gets the fully qualified file-name of this document.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Gets/Sets the user-displayable name of this Document. Defaults to file-name.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets the number that indicates the number of times the file has been saved.
    /// </summary>
    int FileSaveCounter { get; }
    /// <summary>
    /// Gets the object that encapsulates the version of the software with which this document was first created.
    /// </summary>
    SoftwareVersion SoftwareVersionCreated { get; }
    /// <summary>
    /// Gets the object that encapsulates the version of the software with which this document was last saved.
    /// </summary>
    SoftwareVersion SoftwareVersionSaved { get; }
    /// <summary>
    /// Gets the Boolean indicating whether this file needs to be migrated first, using Autodesk Inventor (opened and saved using Autodesk Inventor), before any edits can be performed to the Autodesk Inventor-specific data within this file.
    /// </summary>
    bool NeedsMigrating { get; }
    /// <summary>
    /// Gets/Sets a Boolean flag indicating if the Document has been written into, since opened.
    /// </summary>
    bool Dirty { get; set; }
    /// <summary>
    /// Gets the Boolean that states whether this file has been processed for compaction since the last save.
    /// </summary>
    bool Compacted { get; }
    /// <summary>
    /// Gets the Boolean flag indicating whether this file has been reserved for write by someone.
    /// </summary>
    bool ReservedForWrite { get; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether this file has been reserved for write by the caller.
    /// </summary>
    bool ReservedForWriteByMe { get; set; }
    /// <summary>
    /// Gets the name of the person who currently holds the reservation to write.
    /// </summary>
    string ReservedForWriteName { get; }
    /// <summary>
    /// Gets the login of the person who currently holds the reservation to write.
    /// </summary>
    string ReservedForWriteLogin { get; }
    /// <summary>
    /// Gets the version within this file that has been reserved for write.
    /// </summary>
    int ReservedForWriteVersion { get; }
    /// <summary>
    /// Gets the time at which the reservation was made.
    /// </summary>
    DateTime ReservedForWriteTime { get; }
    /// <summary>
    /// Property that returns whether this document can be currently modified. One of the reasons a document may be non-modifiable is if any other document belonging to the file containing this document is currently being edited.
    /// </summary>
    bool IsModifiable { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns the collection of linked files in the document. Embeddings are not accessible in Apprentice.
    /// </summary>
    ReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    /// <summary>
    /// Gets the collection of descriptor objects, presenting (editable) information about opaque references held.
    /// </summary>
    ReferencedOpaqueFileDescriptors ReferencedOpaqueFileDescriptors { get; }
    /// <summary>
    /// Gets the object that manages the File Properties.
    /// </summary>
    PropertySets PropertySets { get; }
    /// <summary>
    /// Gets the Internal Name (a GUID) for this document.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string RevisionId { get; }
    /// <summary>
    /// Gets the GUID that represents the last saved revision of database contained in this document. This revision id tracks modifications to the database (such as reference changes, geometry changes, etc.) but does not track file property changes.
    /// </summary>
    string DatabaseRevisionId { get; }
    /// <summary>
    /// Returns the AttributeManager object.
    /// </summary>
    AttributeManager AttributeManager { get; }
    /// <summary>
    /// Property that returns the UnitsOfMeasure object.
    /// </summary>
    UnitsOfMeasure UnitsOfMeasure { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyle ActiveRenderStyle { get; }
    /// <summary>
    /// Property that returns a bitmap picture of the document.
    /// </summary>
    IPictureDisp Thumbnail { get; }
    /// <summary>
    /// Property that returns the document's .
    /// </summary>
    ClientViews ClientViews { get; }
    /// <summary>
    /// Property that returns the object for this document.
    /// </summary>
    ApprenticePrintManager PrintManager { get; }
    /// <summary>
    /// Property that returns an enumeration of descriptors that represent the native document references held by this document.
    /// </summary>
    DocumentDescriptorsEnumerator ReferencedDocumentDescriptors { get; }
    /// <summary>
    /// Property that returns the file (storage) on disk that contains this document.
    /// </summary>
    File File { get; }
    /// <summary>
    /// Property that returns the fully qualified name of the document. The string is the full file name concatenated with the document name and is a unique identifier for the document. The document name is returned by the Name property on the Document object.
    /// </summary>
    string FullDocumentName { get; }
    /// <summary>
    /// Property that returns whether this document is currently open. If False, the document has only been initialized and calling methods or properties on the document could cause it to open.
    /// </summary>
    bool Open { get; }
    /// <summary>
    /// Property that returns all the documents referenced by this document.
    /// </summary>
    ApprenticeServerDocuments ReferencedDocuments { get; }
    /// <summary>
    /// Property that returns all the documents in memory that reference this document.
    /// </summary>
    ApprenticeServerDocuments ReferencingDocuments { get; }
    /// <summary>
    /// Property that returns all the document references of this document along with all of the recursively nested references.
    /// </summary>
    ApprenticeServerDocuments AllReferencedDocuments { get; }
    /// <summary>
    /// Property that returns the DocumentInterests collection object.
    /// </summary>
    DocumentInterests DocumentInterests { get; }
    /// <summary>
    /// Read-only property that returns whether this part is intended to be used as a substitute part. (applies only to part documents).
    /// </summary>
    bool IsSubstitutePart { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferenceStatusEnum SubstitutePartStatus { get; }
    /// <summary>
    /// Gets this Document's ReferenceKeyManager object.
    /// </summary>
    ReferenceKeyManager ReferenceKeyManager { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns whether the document requires an update. Note that the document cannot be updated in Apprentice.
    /// </summary>
    bool RequiresUpdate { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _DocPerformanceMonitor _DocPerformanceMonitor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string RedirectionInfo { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ApprenticeServerDocuments ReferencedFiles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ApprenticeServerDocuments AllReferencedFiles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptors ReferencedFileDescriptors { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    HighlightSets HighlightSets { get; }
    /// <summary>
    /// Read-only property that returns the file PropertySets. This is equivalent to the iProperties that got from Shell Extension.
    /// </summary>
    PropertySets FilePropertySets { get; }
    /// <summary>
    /// Property that returns the collection of all the sheets making up this document.
    /// </summary>
    Sheets Sheets { get; }
    /// <summary>
    /// Gets the currently active drafting standard that applies to all of the sheets.
    /// </summary>
    DraftingStandard ActiveStandard { get; }
    /// <summary>
    /// Gets the reference to the containing DWG document when this document is stored in a DWG.
    /// </summary>
    object ContainingDWGDocument { get; }
    /// <summary>
    /// Property that returns whether this is an Inventor DWG document.
    /// </summary>
    bool IsInventorDWG { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LocationName">LocationName</param>
    /// <param name="Type">Type</param>
    [PreserveSig]
    void GetLocationFoundIn([Out] [MarshalAs(UnmanagedType.BStr)] out string LocationName, [Out] out LocationTypeEnum Type);
    /// <summary>
    /// Method that reverts the file checked out by the caller.
    /// </summary>
    [PreserveSig]
    void RevertReservedForWriteByMe();
    /// <summary>
    /// Method that obtains the set of documents that reference the given file within this document.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full file name of the file to search for references to. to.</param>
    /// <returns></returns>
    [PreserveSig]
    ApprenticeServerDocuments FindWhereUsed([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that creates a new highlight set.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HighlightSet CreateHighlightSet();
    /// <summary>
    /// Closes this document.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DatabaseRevisionId">DatabaseRevisionId</param>
    /// <param name="LastSavedLocation">LastSavedLocation</param>
    /// <param name="Indices">Indices</param>
    /// <param name="OldPaths">OldPaths</param>
    /// <param name="CurrentPaths">CurrentPaths</param>
    /// <param name="SkipUnreferenced">SkipUnreferenced</param>
    [PreserveSig]
    void _GetReferenceInfo([Out] [MarshalAs(UnmanagedType.BStr)] out string DatabaseRevisionId, [Out] [MarshalAs(UnmanagedType.BStr)] out string LastSavedLocation, [Out] [MarshalAs(UnmanagedType.Struct)] out object Indices, [Out] [MarshalAs(UnmanagedType.Struct)] out object OldPaths, [Out] [MarshalAs(UnmanagedType.Struct)] out object CurrentPaths, [In] bool? SkipUnreferenced = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Indices">Indices</param>
    /// <param name="CurrentPaths">CurrentPaths</param>
    [PreserveSig]
    void _GetForeignFileReferenceInfo([Out] [MarshalAs(UnmanagedType.Struct)] out object Indices, [Out] [MarshalAs(UnmanagedType.Struct)] out object CurrentPaths);
}

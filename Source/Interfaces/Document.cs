namespace Oblikovati.API;

/// <summary>
/// The Document object represents an in-memory Inventor document.
/// </summary>
public interface Document
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this document.
    /// </summary>
    DocumentTypeEnum DocumentType { get; }
    /// <summary>
    /// Gets/Sets the user-displayable name of this Document. Defaults to file-name.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the display name of the document has been overridden.
    /// </summary>
    bool DisplayNameOverridden { get; set; }
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
    /// Property that returns an enumeration of descriptors that represent the native document references held by this document.
    /// </summary>
    DocumentDescriptorsEnumerator ReferencedDocumentDescriptors { get; }
    /// <summary>
    /// Property that returns all the documents directly referenced by this document.
    /// </summary>
    DocumentsEnumerator ReferencedDocuments { get; }
    /// <summary>
    /// Property that returns all the documents in memory that reference this document. A referencing document may or may not be fully open (i.e. may just be initialized).
    /// </summary>
    DocumentsEnumerator ReferencingDocuments { get; }
    /// <summary>
    /// Property that returns all the document references of this Document along with all of the recursively nested references.
    /// </summary>
    DocumentsEnumerator AllReferencedDocuments { get; }
    /// <summary>
    /// Gets/Sets the fully qualified file-name of this Document.
    /// </summary>
    string FullFileName { get; set; }
    /// <summary>
    /// Gets all the open views of this document in a collection.
    /// </summary>
    Views Views { get; }
    /// <summary>
    /// Returns document's client views.
    /// </summary>
    ClientViews ClientViews { get; }
    /// <summary>
    /// Gets/Sets a Boolean flag indicating if the Document has been written into, since opened.
    /// </summary>
    bool Dirty { get; set; }
    /// <summary>
    /// Gets the Boolean that states whether this file has been processed for compaction since the last save.
    /// </summary>
    bool Compacted { get; }
    /// <summary>
    /// This object supports a set of events that are specific to the document.
    /// </summary>
    DocumentEvents DocumentEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandIDEnum _DefaultCommand { get; }
    /// <summary>
    /// Gets the default command for this document.
    /// </summary>
    string DefaultCommand { get; }
    /// <summary>
    /// Property that returns the collection of linked and embedded files in the document.
    /// </summary>
    ReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    /// <summary>
    /// Gets the collection of OLE attachments made in this Document that match the input type. Returns all OLE attachments if type is kOLEDocumentUnknownObject.
    /// </summary>
    ObjectsEnumerator ReferencedOLEFileDescriptors2 { get; }
    /// <summary>
    /// Gets the collection of descriptor objects, presenting (editable) information about opaque references held.
    /// </summary>
    ReferencedOpaqueFileDescriptors ReferencedOpaqueFileDescriptors { get; }
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
    /// Gets the Property Sets object that controls the file's published-format properties.
    /// </summary>
    PropertySets PropertySets { get; }
    /// <summary>
    /// Returns the AttributeManager object.
    /// </summary>
    AttributeManager AttributeManager { get; }
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
    /// Gets/Sets the sub-Type (a published GUID. See DocCLSIDs.h) of this Document. Setting a new sub-Type will invoke a validation sequence and may fail if the operation is invalid.
    /// </summary>
    string SubType { get; set; }
    /// <summary>
    /// Property that returns the UnitsOfMeasure object.
    /// </summary>
    UnitsOfMeasure UnitsOfMeasure { get; }
    /// <summary>
    /// Gets the Boolean indicating if any of the entities within this document's scope is out of date with respect to their driving entities.
    /// </summary>
    bool RequiresUpdate { get; }
    /// <summary>
    /// Gets the object that has been in-place activated for edit within the context of this document.
    /// </summary>
    object ActivatedObject { get; }
    /// <summary>
    /// Property that returns the PrintManager, or when called from a DrawingDocument it returns a DrawingPrintManager object.
    /// </summary>
    PrintManager PrintManager { get; }
    /// <summary>
    /// Property that returns the object for the document.
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    RenderStyles RenderStyles { get; }
    /// <summary>
    /// Property that returns the <link Inventor::BrowserPanes, BrowserPanes> collection object.
    /// </summary>
    BrowserPanes BrowserPanes { get; }
    /// <summary>
    /// Gets this document's ReferenceKeyManager.
    /// </summary>
    ReferenceKeyManager ReferenceKeyManager { get; }
    /// <summary>
    /// Property that returns the SelectSet object.
    /// </summary>
    SelectSet SelectSet { get; }
    /// <summary>
    /// Gets the SelectionPreferences.
    /// </summary>
    SelectionPreferences SelectionPreferences { get; }
    /// <summary>
    /// Bit mask indicating the disabled command types.
    /// </summary>
    CommandTypesEnum DisabledCommandTypes { get; set; }
    /// <summary>
    /// Property that returns the subtype of the document.
    /// </summary>
    DocumentSubType DocumentSubType { get; }
    /// <summary>
    /// Property that returns a bitmap picture of the document.
    /// </summary>
    IPictureDisp Thumbnail { get; }
    /// <summary>
    /// Gets a bit-encoded value where the bits indicate the kind of changes made to the document since it became dirty.
    /// </summary>
    CommandTypesEnum RecentChanges { get; }
    /// <summary>
    /// Gets and sets the current selection priority for the document.
    /// </summary>
    SelectionPriorityEnum SelectionPriority { get; set; }
    /// <summary>
    /// Property that returns the DocumentInterests collection object.
    /// </summary>
    DocumentInterests DocumentInterests { get; }
    /// <summary>
    /// Property that returns whether the document needs to be migrated to the current release.
    /// </summary>
    bool NeedsMigrating { get; }
    /// <summary>
    /// Property that returns the current thumbnail (preview picture) save option.
    /// </summary>
    ThumbnailSaveOptionEnum ThumbnailSaveOption { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _SickNodesCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _ComatoseNodesCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _PrimaryDeselGUID { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsTemplateUsed { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _DocPerformanceMonitor _DocPerformanceMonitor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileOwnershipEnum OwnershipType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _Document InventorDocument { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DocumentsEnumerator ReferencedFiles { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptors ReferencedFileDescriptors { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    HighlightSets HighlightSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _InternalName { get; }
    /// <summary>
    /// Read-only property that returns the non-transacting GraphicsDataSetsCollection object.
    /// </summary>
    GraphicsDataSetsCollection NonTransactingGraphicsDataSetsCollection { get; }
    /// <summary>
    /// Read-only property that returns the non-transacting ClientGraphicsCollection object.
    /// </summary>
    ClientGraphicsCollection NonTransactingClientGraphicsCollection { get; }
    /// <summary>
    /// Read-only property that returns the model state that this document represents.
    /// </summary>
    string ModelStateName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelState _MigrateLODToModelState { get; }
    /// <summary>
    /// Read-only property that returns the file PropertySets. This is equivalent to the iProperties that got from Shell Extension.
    /// </summary>
    PropertySets FilePropertySets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ExplicitName { get; }
    /// <summary>
    /// Read-only property that returns whether there are references missing for this document.
    /// </summary>
    bool HasReferencesMissing { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LocationName">LocationName</param>
    /// <param name="LocationType">LocationType</param>
    [PreserveSig]
    void GetLocationFoundIn([Out] [MarshalAs(UnmanagedType.BStr)] out string LocationName, [Out] out LocationTypeEnum LocationType);
    /// <summary>
    /// Makes this document the active one (receives user-focus).
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Closes this document.
    /// </summary>
    /// <param name="SkipSave">Optional input Boolean that specifies whether to skip the save. If SkipSave is set to True, it indicates that the changes to the document should not be saved and that the document should be closed silently. If SkipSave is set to False, it indicates that the normal save process should be followed (including prompting a dialog to the user). In addition, if Application.SilentOperation is set to True, the default choice on the dialog should be accepted. The Close method will fail if the combination of SkipSave = False and SilentOperation = True is used for a previously unsaved document.</param>
    [PreserveSig]
    void Close([In] bool? SkipSave = false);
    /// <summary>
    /// Saves this document to disk.
    /// </summary>
    [PreserveSig]
    void Save();
    /// <summary>
    /// Method that saves the document and the specified dependent documents.
    /// </summary>
    /// <param name="SaveDependents">Optional input Boolean that specifies whether or not to save dependent documents that have been dirtied. Defaults to True indicating that the dependents will be saved. If the DependentsToSave argument is not specified, all dirty dependents are saved. If the argument is specified as False, only this document will be saved. The argument is ignored if the document doesn't have any dependents needing save.</param>
    /// <param name="DocumentsToSave">Optional input ObjectCollection that contains the Document objects to save. Use the Document.AllReferencedDocuments property to iterate over all dependent documents and find the ones that need to be saved (i.e. Dirty property returns True). If the SaveDependents argument is True and this argument is not specified, all dirty documents are saved. The argument is ignored if the document doesn't have any dependents needing save.</param>
    [PreserveSig]
    void Save2([In] bool? SaveDependents = true, [In] [MarshalAs(UnmanagedType.Struct)] object? DocumentsToSave = default);
    /// <summary>
    /// Saves this document into a file of the specified name.
    /// </summary>
    /// <param name="FileName">Input String that specifies the name of the file to save the document into.</param>
    /// <param name="SaveCopyAs">Input Boolean that indicates whether the file to be saved is new or is a copy of a previously existing file.</param>
    [PreserveSig]
    void SaveAs([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool SaveCopyAs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="Options">Options</param>
    [PreserveSig]
    void SaveAsWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
    /// <summary>
    /// Obtains a Boolean flag indicating if the specified sub-storage exists within this document.
    /// </summary>
    /// <param name="StorageName">Input String that specifies the name of the sub-storage.</param>
    /// <returns></returns>
    [PreserveSig]
    bool HasPrivateStorage([In] [MarshalAs(UnmanagedType.BStr)] string StorageName);
    /// <summary>
    /// Obtains a Boolean flag indicating if the specified stream exists within this document.
    /// </summary>
    /// <param name="StreamName">Input String value that specifies the name of the stream.</param>
    /// <returns></returns>
    [PreserveSig]
    bool HasPrivateStream([In] [MarshalAs(UnmanagedType.BStr)] string StreamName);
    /// <summary>
    /// Obtains a private sub-storage within this document with the given name. Can create one, if one does not exist.
    /// </summary>
    /// <param name="StorageName">Input String that specifies the name of the private sub-storage.</param>
    /// <param name="CreateIfNecessary">Input Boolean that specifies whether to create a private sub-storage if one does not already exist.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetPrivateStorage([In] [MarshalAs(UnmanagedType.BStr)] string StorageName, [In] bool CreateIfNecessary);
    /// <summary>
    /// Obtains a private stream within this document with the given name. Can create one, if one does not exist.
    /// </summary>
    /// <param name="StreamName">Input String value that specifies the name of the stream to get (31 chars max).</param>
    /// <param name="CreateIfNecessary">Input Boolean that specifies whether to create a private stream if one does not already exist.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetPrivateStream([In] [MarshalAs(UnmanagedType.BStr)] string StreamName, [In] bool CreateIfNecessary);
    /// <summary>
    /// Method that obtains the set of documents that reference the given file within this document.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full file name of the file to search for references to.</param>
    /// <returns></returns>
    [PreserveSig]
    DocumentsEnumerator FindWhereUsed([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that reverts the file checked out by the caller.
    /// </summary>
    [PreserveSig]
    void RevertReservedForWriteByMe();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalNameToken">InternalNameToken</param>
    /// <param name="RevisionIdToken">RevisionIdToken</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="RevisionId">RevisionId</param>
    [PreserveSig]
    void PutInternalNameAndRevisionId([In] [MarshalAs(UnmanagedType.BStr)] string InternalNameToken, [In] [MarshalAs(UnmanagedType.BStr)] string RevisionIdToken, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RevisionId);
    /// <summary>
    /// Performs compute operations on all of the entities within this Document's scope that may be out of date with respect to their driving entities.
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Method that performs compute operations on all of the entities within this Document's scope that may be out of date with respect to their driving entities.
    /// </summary>
    /// <param name="AcceptErrorsAndContinue">Optional argument that specifies if errors should be ignored and the update completed or if the update should be aborted if an error occurs.  If the IgnoreErrors argument is set to True, errors are skipped and the update process continues. If IgnoreErrors is set to False, the method returns as soon as the first error is encountered.</param>
    /// <returns></returns>
    [PreserveSig]
    bool Update2([In] bool? AcceptErrorsAndContinue = true);
    /// <summary>
    /// Performs compute operations on all of the entities within this document's scope as if all of the driving entities had been 'dirtied.'
    /// </summary>
    [PreserveSig]
    void Rebuild();
    /// <summary>
    /// Method that performs compute operations on all of the entities within this Document's scope as if all of the driving entities had been 'dirtied'.
    /// </summary>
    /// <param name="AcceptErrorsAndContinue">Optional argument that specifies if errors should be ignored and the rebuild completed or if the rebuild should be aborted if an error occurs.  If the IgnoreErrors argument is set to True, errors are skipped and the rebuild process continues. If IgnoreErrors is set to False, the method returns as soon as the first error is encountered.</param>
    /// <returns></returns>
    [PreserveSig]
    bool Rebuild2([In] bool? AcceptErrorsAndContinue = true);
    /// <summary>
    /// Method that sets the commands to be disabled when a particular AddIn is absent.
    /// </summary>
    /// <param name="ClientId">Specifies the ClassId of the AddIn. When the AddIn corresponding to this ClientId is absent (unloaded or uninstalled), the commands specified are disabled.</param>
    /// <param name="DisabledCommandTypesEnum">CommandTypesEnum that specifies the classifications of the commands to be disabled.</param>
    /// <param name="DisabledCommands">Optional input ObjectCollection that specifies the commands to be disabled. The ObjectCollection must contain only ControlDefinition objects.</param>
    [PreserveSig]
    void SetMissingAddInBehavior([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] CommandTypesEnum DisabledCommandTypesEnum, [In] [MarshalAs(UnmanagedType.Struct)] object? DisabledCommands = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="DisabledCommandTypesEnum">DisabledCommandTypesEnum</param>
    /// <param name="DisabledCommands">DisabledCommands</param>
    [PreserveSig]
    void GetMissingAddInBehavior([Out] [MarshalAs(UnmanagedType.BStr)] out string ClientId, [Out] out CommandTypesEnum DisabledCommandTypesEnum, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection DisabledCommands);
    /// <summary>
    /// Method that creates a new highlight set.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HighlightSet CreateHighlightSet();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Migrate();
    /// <summary>
    /// Method that releases the reference that gets added if a document is opened invisibly through the API. Releasing the reference on a hidden document makes it a candidate for closure the next time Oblikovati closes all unreferenced documents.
    /// </summary>
    [PreserveSig]
    void ReleaseReference();
    /// <summary>
    /// Method that sets the thumbnail (preview picture) save option.
    /// </summary>
    /// <param name="SaveOption">ThumbnailSaveOptionEnum indicating what gets saved as a thumbnail, if anything. Options include kNoThumbnail, kActiveComponentIsoViewOnSave, kActiveWindowOnSave, kActiveWindow, and kImportFromFile.</param>
    /// <param name="ImageFullFileName">Indicates what image file to use if SaveOption is set to kImportFromFile.</param>
    [PreserveSig]
    void SetThumbnailSaveOption([In] ThumbnailSaveOptionEnum SaveOption, [In] [MarshalAs(UnmanagedType.BStr)] string? ImageFullFileName = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="schemaXmlString">schemaXmlString</param>
    /// <param name="outXmlFile">outXmlFile</param>
    [PreserveSig]
    void _XmlOutToFile([In] [MarshalAs(UnmanagedType.BStr)] string schemaXmlString, [In] [MarshalAs(UnmanagedType.BStr)] string outXmlFile);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void LockSaveSet();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _VBAProjectChanged();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="Number">Number</param>
    /// <param name="Custom">Custom</param>
    /// <param name="InternalName">InternalName</param>
    [PreserveSig]
    void PutInternalName([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Number, [In] [MarshalAs(UnmanagedType.BStr)] string Custom, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="Number">Number</param>
    /// <param name="Custom">Custom</param>
    /// <param name="Revision">Revision</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="FileVersion">FileVersion</param>
    [PreserveSig]
    void _PutInternalNameAndFileVersion([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Number, [In] [MarshalAs(UnmanagedType.BStr)] string Custom, [In] [MarshalAs(UnmanagedType.BStr)] string Revision, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileVersion);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Preview">Preview</param>
    /// <param name="NumEmbeddings">NumEmbeddings</param>
    /// <param name="Embeddings">Embeddings</param>
    [PreserveSig]
    void _DeleteUnusedEmbeddings([In] bool Preview, [Out] out int NumEmbeddings, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref string[] Embeddings);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void MakeModelStateMemberModifiable();
    /// <summary>
    /// Saves this document into a file of the specified name.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of the file to save the document into.</param>
    /// <param name="SaveCopyAs">Input Boolean that indicates whether the file to be saved is new or is a copy of a previously existing file.</param>
    /// <param name="Options">Optional input NameValueMap to specify additional options when save the document. Valid options include:
    /// Name = SaveDependents. Value = Boolean that specifies whether or not to save dependent documents that have been dirtied. Defaults to True indicating that the dependents will be saved. If the DependentsToSave argument is not specified, all dirty dependents are saved. If the argument is specified as False, only this document will be saved. The argument is ignored if the document doesn't have any dependents needing save.
    /// Name = DocumentsToSave. Value = ObjectCollection that contains the Document objects to save. Use the Document.AllReferencedDocuments property to iterate over all dependent documents and find the ones that need to be saved (i.e. Dirty property returns True). If the SaveDependents argument is True and this argument is not specified, all dirty documents are saved. The argument is ignored if the document doesn't have any dependents needing save.</param>
    [PreserveSig]
    void SaveAs2([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] bool SaveCopyAs, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Method that invoke the resolve file for the document if there are references missing.
    /// </summary>
    [PreserveSig]
    void ResolveFile();
}

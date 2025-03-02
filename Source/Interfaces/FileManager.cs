namespace Oblikovati.API;

/// <summary>
/// The FileManager object provides access to file-related utility functions.
/// </summary>
public interface FileManager
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
    /// Property that gets the object that fires the File Manager related events.
    /// </summary>
    FileManagerEvents FileManagerEvents { get; }
    /// <summary>
    /// Property that returns the FilesEnumerator object
    /// </summary>
    FilesEnumerator Files { get; }
    /// <summary>
    /// Gets the Scripting.FileSystemObject in Inventor process.
    /// </summary>
    object FileSystemObject { get; }
    /// <summary>
    /// Method that deletes the specified file.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full path and filename of the file to delete.</param>
    /// <param name="FileManagementOption">Input constant that specifies how to handle the results of the file operation.</param>
    [PreserveSig]
    void DeleteFile([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] FileManagementEnum? FileManagementOption = FileManagementEnum.kNoForceFile);
    /// <summary>
    /// Method that copies the specified  Oblikovati file (.ipt, .idw, .ipt etc.) from one location to another.
    /// </summary>
    /// <param name="SourceFullFileName">Input String that specifies the full path and filename of the file to copy.</param>
    /// <param name="DestinationFullFileName">Input String that specifies the full path and filename in which to place the results of the copy procedure.</param>
    /// <param name="FileManagementOption">Input constant that specifies how to handle the results of the file operation.</param>
    [PreserveSig]
    void CopyFile([In] [MarshalAs(UnmanagedType.BStr)] string SourceFullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string DestinationFullFileName, [In] FileManagementEnum? FileManagementOption = FileManagementEnum.kNoForceFile);
    /// <summary>
    /// Method that moves the specified file from one location to another.
    /// </summary>
    /// <param name="SourceFullFileName">Input String that specifies the full path and filename of the file to move.</param>
    /// <param name="DestinationFullFileName">Input String that specifies the full path and filename in which to place the results of the move procedure.</param>
    /// <param name="FileManagementOption">Input constant that specifies how to handle the results of the file operation.</param>
    [PreserveSig]
    void MoveFile([In] [MarshalAs(UnmanagedType.BStr)] string SourceFullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string DestinationFullFileName, [In] FileManagementEnum? FileManagementOption = FileManagementEnum.kNoForceFile);
    /// <summary>
    /// Method that specifies the template to use when creating a file.
    /// </summary>
    /// <param name="DocumentType">Input constant that specifies the type of to create.</param>
    /// <param name="SystemOfMeasure">Input constant that specifies the system of measure to use in the drawing being created.</param>
    /// <param name="DraftingStandard">Input constant that specifies the drafting standard to use in the drawing being created.</param>
    /// <param name="DocumentSubType">Input constant (GUID) that specifies the subtype of the document to be created (sheet metal or weldment).</param>
    /// <returns></returns>
    [PreserveSig]
    string GetTemplateFile([In] DocumentTypeEnum DocumentType, [In] SystemOfMeasureEnum? SystemOfMeasure = SystemOfMeasureEnum.kDefaultSystemOfMeasure, [In] DraftingStandardEnum? DraftingStandard = DraftingStandardEnum.kDefault_DraftingStandard, [In] [MarshalAs(UnmanagedType.Struct)] object? DocumentSubType = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="Identifier">Identifier</param>
    /// <param name="AbsolutePath">AbsolutePath</param>
    [PreserveSig]
    void GetIdentifierFromFileName([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] Identifier, [In] [MarshalAs(UnmanagedType.BStr)] string? AbsolutePath = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Identifier">Identifier</param>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="AbsolutePath">AbsolutePath</param>
    [PreserveSig]
    void GetFileNameFromIdentifier([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] Identifier, [Out] [MarshalAs(UnmanagedType.BStr)] out string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string? AbsolutePath = "");
    /// <summary>
    /// Returns the full document name which is a unique identifier for an open Document. The returned string is the full file name concatenated with the model state name for a part or assembly document.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the Inventor file on disk.</param>
    /// <param name="ModelStateName">Optional input String that specifies the name of the model state within the file. This argument is ignored for presentation and drawing documents. If an assembly or partt document has multiple model states and this argument is not specified, the full document name of the primary document is returned.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetFullDocumentName([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string? ModelStateName = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentName">FullDocumentName</param>
    [PreserveSig]
    string GetLevelOfDetailName([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
    /// <summary>
    /// Returns the full file name given its full document name.
    /// </summary>
    /// <param name="FullDocumentName">Input String that specifies the full document name.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetFullFileName([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
    /// <summary>
    /// Method that returns the names of all the design view representations contained within the input file (either *.iam, *.ipt or *.idv).
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the file (*.iam, *.ipt or *.idv) to retrieve the design view names from. A FullDocumentName can also be specified. If an idv file is specified, the private design views contained within it are returned.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetDesignViewRepresentations([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that returns the names of all the positional representations contained within the input assembly file.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the file to retrieve the positinal representations from.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetPositionalRepresentations([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    string[] GetLevelOfDetailRepresentations([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    string GetLastActiveLevelOfDetailRepresentation([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="ValidFileName">ValidFileName</param>
    [PreserveSig]
    bool IsFileNameValid([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [Out] [MarshalAs(UnmanagedType.BStr)] out string ValidFileName);
    /// <summary>
    /// Gets the set of direct file references from a DWG file.
    /// </summary>
    /// <param name="DocumentOrFileName">Input String that specifies the full document or file name.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetDWGDocumentReferences([In] [MarshalAs(UnmanagedType.Struct)] object DocumentOrFileName);
    /// <summary>
    /// Method that returns whether the input file is an Oblikovati DWG file.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of a DWG file.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsInventorDWG([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Refreshes all documents in memory to the latest version on disk.
    /// </summary>
    [PreserveSig]
    void RefreshAllDocuments();
    /// <summary>
    /// Method that returns the name of the design view representation that was active when the file was last saved.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full file name (currently only supported for assembly documents).</param>
    /// <returns></returns>
    [PreserveSig]
    string GetLastActiveDesignViewRepresentation([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Returns the object that encapsulates the version of the software with which this file was last saved.
    /// </summary>
    /// <param name="FullFileName">Input string value that indicates the full filename of an Inventor file.</param>
    /// <returns></returns>
    [PreserveSig]
    SoftwareVersion SoftwareVersionSaved([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that returns the names of all the AutoCAD block definitions contained within the input DWG file. The input file can be an AutoCAD DWG or an Oblikovati DWG.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full file name of the AutoCAD or Inventor DWG file from which to return the block definition names.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetAutoCADBlockDefinitions([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Returns a value indicating the current state of the express graphics in the specified assembly.
    /// </summary>
    /// <param name="AssemblyFullFilename">Input String that specifies the assembly full filename.</param>
    /// <returns></returns>
    [PreserveSig]
    CachedGraphicsStatusEnum GetExpressGraphicsStatus([In] [MarshalAs(UnmanagedType.BStr)] string AssemblyFullFilename);
    /// <summary>
    /// Returns the number of uniquely referenced documents the input document had at the time it was last saved. This is the number that is used in determining whether or not an assembly will open in Express mode or Full mode.
    /// </summary>
    /// <param name="FullFileName">Input string value that indicates the assembly full filename.</param>
    /// <returns></returns>
    [PreserveSig]
    int ReferencedDocumentCount([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Returns whether the input assembly will open in Express mode by default.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool WillOpenExpressDefault([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that checks whether a foreign CAD file can be associatively imported into Oblikovati document or not.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of a CAD file. Valid filename can be an AnyCAD filename or Inventor part or assembly filename.</param>
    /// <returns></returns>
    [PreserveSig]
    bool CanCADFileBeAssociativelyImported([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Returns whether the input file is an Oblikovati Component (part or assembly).
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies full file name.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsInventorComponent([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that returns whether the input CAD file is a future CAD file. If an invalid CAD filename is provided an error would occur.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of a CAD file. Valid filename can be an AnyCAD filename or Inventor part or assembly filename.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsFutureCADFile([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="ResultXML">ResultXML</param>
    [PreserveSig]
    void GetCADFileStructure([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string ResultXML);
    /// <summary>
    /// Method that returns whether the input string indicates an embedded document path.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of a file.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEmbeddedDocumentPath([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that returns the short filename of an embedded document path.
    /// </summary>
    /// <param name="FullFileName">Input the full filename of an embedded document.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetEmbeddedDocumentShortName([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that gets the array of strings containing the SHX font name list.
    /// </summary>
    /// <param name="BigFont">Optional input Boolean value that specifies whether to get the big font name list or not. This default to False means to return the common SHX font name list, when set this to True the big font name list will be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetSHXFontList([In] [MarshalAs(UnmanagedType.Struct)] object? BigFont = default);
    /// <summary>
    /// Method that returns the names of all the model states contained within the input file.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of a document. This can be a full filename of a part or assembly document.</param>
    /// <returns></returns>
    [PreserveSig]
    string[] GetModelStates([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that returns the name of the model state given its full document name.
    /// </summary>
    /// <param name="FullDocumentName">Input String value that specifies the full document name of a document.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetModelStateName([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
    /// <summary>
    /// Method that returns the name of the model state that was active when the file was last saved.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full filename of a document. This can be a full filename of a part or assembly document.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetLastActiveModelState([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that gets a template file that can be used to create a new document.
    /// </summary>
    /// <param name="DocType">Input constant that specifies the type of to create.</param>
    /// <param name="SystemOfMeasure">Optional input SystemOfMeasureEnum that specifies the system of measure to use in the drawing being created.</param>
    /// <param name="DraftingStandard">Optional input DraftingStandardEnum that specifies the drafting standard to use in the drawing being created.</param>
    /// <param name="DocumentSubType">Optional input constant (GUID) that specifies the subtype of the document to be created (sheet metal or weldment).</param>
    /// <param name="MoreOptions">Optional NameValueMap that species more options. Valid options are:
    /// Name = “TemplatePathType”. Value = String value that indicates where the template file is retrieved from. The “Application” indicates that the template path that is defined by Application is used. The “Project” indicates that the template path that is defined by active Inventor Project is used. The “Global” indicates the template path that is from installation folder. If not specified the templates path defined in the active Inventor Project will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetTemplateFileWithOptions([In] DocumentTypeEnum DocType, [In] [MarshalAs(UnmanagedType.Struct)] object? SystemOfMeasure = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DraftingStandard = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DocumentSubType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MoreOptions = default);
    /// <summary>
    /// Method that tries to install specified Revit engine and returns the installation status. The installation is asynchronous, and this returns kInstallationInProcessStatus if the installation is started.
    /// </summary>
    /// <param name="RevitEngineVersion">Input String value that specifies the Revit engine version(e.g. “Revit 2025”) to install.</param>
    /// <returns></returns>
    [PreserveSig]
    InstallationStatusEnum InstallRevitEngineVersion([In] [MarshalAs(UnmanagedType.BStr)] string RevitEngineVersion);
    /// <summary>
    /// Method that returns the Revit engine installation status for available versions.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    NameValueMap GetRevitEngineInstallationStatus();
}

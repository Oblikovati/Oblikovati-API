namespace Oblikovati.API;

/// <summary>
/// Standalone mini component allowing limited access to an Inventor File. Refer to the Apprentice Server overview article.
/// </summary>
public interface ApprenticeServer
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the top-level Apprentice Server Document.
    /// </summary>
    ApprenticeServerDocument Document { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileLocations FileLocations { get; }
    /// <summary>
    /// Gets the object that provides access to the helper object that provides the Save As facility.
    /// </summary>
    FileSaveAs FileSaveAs { get; }
    /// <summary>
    /// Gets all the Application AddIns found on this machine in a collection.
    /// </summary>
    ApplicationAddIns ApplicationAddIns { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MultiUsersEnabled { get; set; }
    /// <summary>
    /// Get or set the enum indicating the Multi-User mode.
    /// </summary>
    MultiUserModeEnum MultiUserMode { get; set; }
    /// <summary>
    /// Get or set the Boolean flag indicating whether Multi-User facility is managed by Inventor or not.
    /// </summary>
    bool MultiUserExternallyManaged { get; set; }
    /// <summary>
    /// Gets the object that encapsulates the version of the current software.
    /// </summary>
    SoftwareVersion SoftwareVersion { get; }
    /// <summary>
    /// Get or set the string that identifies the current user. Inventor saves its own copy of this name per user and can thus be manipulated without effecting the rest of the OS.
    /// </summary>
    string UserName { get; set; }
    /// <summary>
    /// Gets the object through which all transient geometry objects can be constructed.
    /// </summary>
    TransientGeometry TransientGeometry { get; }
    /// <summary>
    /// Indicates the Boolean flag that fine tunes the performance of Apprentice when it is being used to display Inventor files. Defaults to false.
    /// </summary>
    bool DisplayAffinity { get; set; }
    /// <summary>
    /// Gets the file manager object.
    /// </summary>
    FileManager FileManager { get; }
    /// <summary>
    /// Gets the File Options object.
    /// </summary>
    FileOptions FileOptions { get; }
    /// <summary>
    /// Gets the Locale Id currently in use in Inventor.
    /// </summary>
    int Locale { get; }
    /// <summary>
    /// Get the DisplayOptions object.
    /// </summary>
    DisplayOptions DisplayOptions { get; }
    /// <summary>
    /// Get the HardwareOptions object.
    /// </summary>
    HardwareOptions HardwareOptions { get; }
    /// <summary>
    /// Property that returns the full path where Inventor/Apprentice is installed.
    /// </summary>
    string InstallPath { get; }
    /// <summary>
    /// Property that returns the DesignProjectManager object.
    /// </summary>
    DesignProjectManager DesignProjectManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string CurrentUserAppDataPath { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string AllUsersAppDataPath { get; }
    /// <summary>
    /// Property that returns the TransientObjects object.
    /// </summary>
    TransientObjects TransientObjects { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileAccessEvents FileAccessEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferenceKeyEvents ReferenceKeyEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsRegistryEntry { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object _RegistryEntry { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DebugInstrumentation _DebugInstrumentation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _AppPerformanceMonitor _AppPerformanceMonitor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IndirectReferences { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    TestManager TestManager { get; }
    /// <summary>
    /// Gets the Help Manager object that provides access to the help-related activity taking place in the system.
    /// </summary>
    HelpManager HelpManager { get; }
    /// <summary>
    /// Opens a file. It can now be accessed as the top-level Document
    /// </summary>
    /// <param name="FullDocumentName">Specifies the full document name of the document to open. If only the FullFileName is specified for part and assembly documents, the master document within the file is opened.</param>
    /// <returns></returns>
    [PreserveSig]
    ApprenticeServerDocument Open([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
    /// <summary>
    /// Opens a document of the specified file-name with the specified set of options.
    /// </summary>
    /// <param name="FullDocumentName">Input String that specifies the full document name of the document to open. If only the FullFileName is specified for an assembly, the master document within the file is opened.</param>
    /// <param name="Options">Input NameValueMap object that specifies additional options for open. (An empty NameValueMap object can be provided).</param>
    /// <returns></returns>
    [PreserveSig]
    ApprenticeServerDocument OpenWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
    /// <summary>
    /// Closes the current file. After this call there is no top-level Document. An attempt is also made to close the children Documents.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ForceDependentsToClose">ForceDependentsToClose</param>
    [PreserveSig]
    void Close2([In] bool? ForceDependentsToClose = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SubKey">SubKey</param>
    /// <param name="ValueName">ValueName</param>
    /// <param name="Value">Value</param>
    /// <param name="RegistryHive">RegistryHive</param>
    /// <param name="RefreshWithEntry">RefreshWithEntry</param>
    [PreserveSig]
    void _SetRegistryEntry([In] [MarshalAs(UnmanagedType.BStr)] string SubKey, [In] [MarshalAs(UnmanagedType.BStr)] string ValueName, [In] [MarshalAs(UnmanagedType.Struct)] object Value, [In] _RegistryHiveTypeEnum RegistryHive, [In] bool RefreshWithEntry);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SubKey">SubKey</param>
    /// <param name="ValueName">ValueName</param>
    /// <param name="RegistryHive">RegistryHive</param>
    [PreserveSig]
    void _DeleteRegistryEntry([In] [MarshalAs(UnmanagedType.BStr)] string SubKey, [In] [MarshalAs(UnmanagedType.BStr)] string ValueName, [In] _RegistryHiveTypeEnum RegistryHive);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="TopicName">TopicName</param>
    [PreserveSig]
    void _DisplayHelpTopic([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] [MarshalAs(UnmanagedType.BStr)] string TopicName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void _DisplayHelpContext([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] int Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StylesLibraryLocation">StylesLibraryLocation</param>
    [PreserveSig]
    bool _GetStylesLibraryLockStatus([In] [MarshalAs(UnmanagedType.BStr)] string StylesLibraryLocation);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FileName">FileName</param>
    /// <param name="bLock">bLock</param>
    [PreserveSig]
    void _SetStylesLibraryLockStatus([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool bLock);
}

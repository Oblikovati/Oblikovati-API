namespace Oblikovati.API;

/// <summary>
/// InventorServer Object.
/// </summary>
public interface InventorServerObject
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets all the in-memory documents in a collection.
    /// </summary>
    Documents Documents { get; }
    /// <summary>
    /// Gets the object that encapsulates the version of the current software.
    /// </summary>
    SoftwareVersion SoftwareVersion { get; }
    /// <summary>
    /// Property that returns the ApplicationEvents object. This object supports a set of events that are application-centric.
    /// </summary>
    ApplicationEvents ApplicationEvents { get; }
    /// <summary>
    /// Property that returns the ModelingEvents object. This object supports a set of events that are common to parts and assemblies.
    /// </summary>
    ModelingEvents ModelingEvents { get; }
    /// <summary>
    /// Property that returns the SketchEvents object. This object supports a set of 2d and 3d sketch-related events that are common to parts, assemblies and drawings.
    /// </summary>
    SketchEvents SketchEvents { get; }
    /// <summary>
    /// Property that returns the StyleEvents object. This object supports a set of events that relate to styles.
    /// </summary>
    StyleEvents StyleEvents { get; }
    /// <summary>
    /// Property that returns the RepresentationEvents object. This object supports a set of events related to design view and positional representations that are assembly centric.
    /// </summary>
    RepresentationEvents RepresentationEvents { get; }
    /// <summary>
    /// Property that returns the AssemblyEvents object. This object supports a set of events that are assembly centric.
    /// </summary>
    AssemblyEvents AssemblyEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PublicationEvents _PublicationEvents { get; }
    /// <summary>
    /// Property that returns the FileAccessEvents object. This object supports a set of events that are fired as a result of a file being accessed.
    /// </summary>
    FileAccessEvents FileAccessEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelStateEvents ModelStateEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectsEnumeratorByVariant Preferences { get; }
    /// <summary>
    /// Property that returns the ApplicationAddIns object. This object provides access to the Add-Ins currently installed.
    /// </summary>
    ApplicationAddIns ApplicationAddIns { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FileLocations FileLocations { get; }
    /// <summary>
    /// Gets the TransactionManager object that controls all the database transactions taking place in the system.
    /// </summary>
    TransactionManager TransactionManager { get; }
    /// <summary>
    /// Gets the ChangeManager object. The ChangeManager object manages the processes involved in making changes to data and recording the change process.
    /// </summary>
    ChangeManager ChangeManager { get; }
    /// <summary>
    /// Property that returns the Locale Id currently in use in Autodesk Inventor, along with a string name of the language. Calling GetLocaleInfo with the LocaleId should give you further information.
    /// </summary>
    int Locale { get; }
    /// <summary>
    /// Gets the language currently in use in Autodesk Inventor.
    /// </summary>
    string LanguageName { get; }
    /// <summary>
    /// Gets the object through which all transient geometry objects can be constructed.
    /// </summary>
    TransientGeometry TransientGeometry { get; }
    /// <summary>
    /// Gets the object through which all general transient objects are created.
    /// </summary>
    TransientObjects TransientObjects { get; }
    /// <summary>
    /// Gets/sets the string that identifies the current user. Autodesk Inventor saves its own copy of this name per user and can thus be manipulated without affecting the rest of the OS.
    /// </summary>
    string UserName { get; set; }
    /// <summary>
    /// Gets the top-level automation pointer to VBA's IDE.
    /// </summary>
    object VBE { get; }
    /// <summary>
    /// Property that returns the FileManager object.
    /// </summary>
    FileManager FileManager { get; }
    /// <summary>
    /// Property that returns the AssemblyOptions object. The AssemblyOptions object provides access to various assembly related application level options. This is somewhat equivalent to the Assembly tab of the Application Options dialog.
    /// </summary>
    AssemblyOptions AssemblyOptions { get; }
    /// <summary>
    /// Property that returns the GeneralOptions object. The GeneralOptions object provides access to various application level options. This is somewhat equivalent to the General tab of the Application Options dialog.
    /// </summary>
    GeneralOptions GeneralOptions { get; }
    /// <summary>
    /// Property that returns the SketchOptions object. The SketchOptions object provides access to various 2D sketch related application level options. This is somewhat equivalent to the 2D Sketch portion on the Sketch tab of the Application Options dialog.
    /// </summary>
    SketchOptions SketchOptions { get; }
    /// <summary>
    /// Property that returns the PartOptions object. The PartOptions object provides access to various part related application level options. This is somewhat equivalent to the Part tab of the Application Options dialog.
    /// </summary>
    PartOptions PartOptions { get; }
    /// <summary>
    /// Property that returns the Sketch3DOptions object. The Sketch3DOptions object provides access to various 3D sketch related application level options. This is somewhat equivalent to the 3D Sketch portion on the Sketch tab of the Application Options dialog.
    /// </summary>
    Sketch3DOptions Sketch3DOptions { get; }
    /// <summary>
    /// Property that returns the DrawingOptions object. The DrawingOptions object provides access to various drawing related application level options. This is somewhat equivalent to the Drawing tab of the Application Options dialog.
    /// </summary>
    DrawingOptions DrawingOptions { get; }
    /// <summary>
    /// Property that returns the SaveOptions object. The SaveOptions object provides access to various save related application level options. This is somewhat equivalent to the Save tab of the Application Options dialog.
    /// </summary>
    SaveOptions SaveOptions { get; }
    /// <summary>
    /// Property that returns the FileOptions object. The FileOptions object provides access to various file related application level options. This is somewhat equivalent to the File tab of the Application Options dialog.
    /// </summary>
    FileOptions FileOptions { get; }
    /// <summary>
    /// Gets the Hardware Options.
    /// </summary>
    HardwareOptions HardwareOptions { get; }
    /// <summary>
    /// Property that returns the ContentCenter object.
    /// </summary>
    ContentCenter ContentCenter { get; }
    /// <summary>
    /// Property that returns the iFeatureOptions object. The iFeatureOptions object provides access to various iFeature related application level options. This is somewhat equivalent to the iFeature tab of the Application Options dialog.
    /// </summary>
    iFeatureOptions iFeatureOptions { get; }
    /// <summary>
    /// Property that returns the NotebookOptions object. The NotebookOptions object provides access to various notebook related application level options. This is somewhat equivalent to the Notebook tab of the Application Options dialog.
    /// </summary>
    NotebookOptions NotebookOptions { get; }
    /// <summary>
    /// Gets the Display Options.
    /// </summary>
    DisplayOptions DisplayOptions { get; }
    /// <summary>
    /// Returns the MeasureTools object.
    /// </summary>
    MeasureTools MeasureTools { get; }
    /// <summary>
    /// Property that returns the full path where Inventor/Apprentice is installed.
    /// </summary>
    string InstallPath { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string CurrentUserAppDataPath { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string AllUsersAppDataPath { get; }
    /// <summary>
    /// Property that returns the LanguageTools object.
    /// </summary>
    LanguageTools LanguageTools { get; }
    /// <summary>
    /// Boolean property indicating whether Inventor has completed its initialization. This includes initialization of all the Add-ins loaded at startup.This property should be used in conjunction with the ApplicationEvents.OnReady event.
    /// </summary>
    bool Ready { get; }
    /// <summary>
    /// Property that returns the UnitsOfMeasure object.
    /// </summary>
    UnitsOfMeasure UnitsOfMeasure { get; }
    /// <summary>
    /// Property that returns the TransientBRep object.
    /// </summary>
    TransientBRep TransientBRep { get; }
    /// <summary>
    /// Gets/Sets whether a file management AddIn is present.
    /// </summary>
    bool SupportsFileManagement { get; set; }
    /// <summary>
    /// Property that returns the ErrorManager object. This object can be used to get errors that occurred during an API call, add to Inventor's errors or to display them.
    /// </summary>
    ErrorManager ErrorManager { get; }
    /// <summary>
    /// Returns the ContentCenterOptions object.
    /// </summary>
    ContentCenterOptions ContentCenterOptions { get; }
    /// <summary>
    /// Gets the StylesManager object.
    /// </summary>
    StylesManager StylesManager { get; }
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
    bool _CanReplayTranscript { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _TranscriptAPIChanges { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DebugInstrumentation _DebugInstrumentation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object _TestIO { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _AppPerformanceMonitor _AppPerformanceMonitor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _ForceMigrationOnOpen { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _UpdateAnnotationsOnSheetActivate { set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _HarvestStylesOnOpen { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _PurgeStylesOnOpen { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    TestManager TestManager { get; }
    /// <summary>
    /// Gets the design project manager object.
    /// </summary>
    DesignProjectManager DesignProjectManager { get; }
    /// <summary>
    /// Gets the Presentation Options.
    /// </summary>
    PresentationOptions PresentationOptions { get; }
    /// <summary>
    /// Read-write property that gets and sets the library whose contents is listed in the appearances drop-down list in the QAT (Quick Access Toolbar)_at the top of the Inventor window.&nbsp;The initial active appearance is defined by the active project.&nbsp;Using this property you can override the project appearance.&nbsp;When a new project is activated the active appearance will be determined by the activated project.
    /// </summary>
    AssetLibrary ActiveAppearanceLibrary { get; set; }
    /// <summary>
    /// Gets and sets the library whose contents is listed in the materials drop-down list in the QAT(Quick Access Toolbar) at the top of the Inventor window.
    /// </summary>
    AssetLibrary ActiveMaterialLibrary { get; set; }
    /// <summary>
    /// Gets AssetLibraries collection object. This collection provides access to the all of the appearance and material libraries.
    /// </summary>
    AssetLibraries AssetLibraries { get; }
    /// <summary>
    /// Gets the set of favorite assets. This includes both appearance and material assets.
    /// </summary>
    AssetsEnumerator FavoriteAssets { get; }
    /// <summary>
    /// Gets and sets the units that are used in the user interface when working with materials.
    /// </summary>
    MaterialDisplayUnitsEnum MaterialDisplayUnits { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ColorScheme ActiveColorScheme { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ColorSchemes ColorSchemes { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iLogicOptions iLogicOptions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _SuppressFileDirtyEvents { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _TranscriptFileName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferenceKeyEvents ReferenceKeyEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientOperationEvents ClientOperationEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _DefaultPrinter3DName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsFileVersionSupported { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsReplayingTranscript { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsInventorFile { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _DefaultDocType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsTranscriptingOn { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CustomDataEvents _CustomDataEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _LibraryDocumentModifiable { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentType">DocumentType</param>
    /// <param name="SystemOfMeasure">SystemOfMeasure</param>
    /// <param name="DraftingStandard">DraftingStandard</param>
    /// <param name="DocumentSubType">DocumentSubType</param>
    [PreserveSig]
    string GetTemplateFile([In] DocumentTypeEnum DocumentType, [In] SystemOfMeasureEnum? SystemOfMeasure = SystemOfMeasureEnum.kDefaultSystemOfMeasure, [In] DraftingStandardEnum? DraftingStandard = DraftingStandardEnum.kDefault_DraftingStandard, [In] [MarshalAs(UnmanagedType.Struct)] object? DocumentSubType = default);
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
    void _ConstructInternalNameAndFileVersion([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Number, [In] [MarshalAs(UnmanagedType.BStr)] string Custom, [In] [MarshalAs(UnmanagedType.BStr)] string Revision, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName, [Out] [MarshalAs(UnmanagedType.BStr)] out string FileVersion);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="Number">Number</param>
    /// <param name="Custom">Custom</param>
    /// <param name="InternalName">InternalName</param>
    [PreserveSig]
    void CreateInternalName([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Number, [In] [MarshalAs(UnmanagedType.BStr)] string Custom, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName);
    /// <summary>
    /// Constructs and returns the IUnknown object for the specified ProgID or CLSID.
    /// </summary>
    /// <param name="ProgIDorCLSID">The class ID (CLSID) or ProgID of the required IUknown object.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetInterfaceObject([In] [MarshalAs(UnmanagedType.BStr)] string ProgIDorCLSID);
    /// <summary>
    /// In 32-bit  Oblikovati, this method always returns the same object as GetInterfaceObject.
    /// </summary>
    /// <param name="ProgIDorCLSID">_nt_</param>
    /// <returns></returns>
    [PreserveSig]
    object GetInterfaceObject32([In] [MarshalAs(UnmanagedType.BStr)] string ProgIDorCLSID);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalNameToken">InternalNameToken</param>
    /// <param name="RevisionIdToken">RevisionIdToken</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="RevisionId">RevisionId</param>
    [PreserveSig]
    void ConstructInternalNameAndRevisionId([In] [MarshalAs(UnmanagedType.BStr)] string InternalNameToken, [In] [MarshalAs(UnmanagedType.BStr)] string RevisionIdToken, [Out] [MarshalAs(UnmanagedType.BStr)] out string InternalName, [Out] [MarshalAs(UnmanagedType.BStr)] out string RevisionId);
    /// <summary>
    /// Informs Oblikovati/Apprentice that a license should be retained for this instance of the application. Used to prevent idle detection from returning the seat license to the license pool. Requires a call to UnreserveLicense with the same ClientID to allow license reclamation to resume.
    /// </summary>
    [PreserveSig]
    void ReserveLicense([In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
    /// <summary>
    /// Informs Oblikovati/Apprentice that normal seat license reclamation can resume. Use this method when extended processing for which a license was reserved completes. Do not use without a previous call to ReserveLicense using the same ClientID.
    /// </summary>
    [PreserveSig]
    void UnreserveLicense([In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
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
    /// <param name="TranscriptFileName">TranscriptFileName</param>
    [PreserveSig]
    void _ReplayTranscript([In] [MarshalAs(UnmanagedType.BStr)] string TranscriptFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LibraryPath">LibraryPath</param>
    /// <param name="Result">Result</param>
    /// <param name="NumLibraries">NumLibraries</param>
    [PreserveSig]
    void _MigrateStylesLibrary([In] [MarshalAs(UnmanagedType.BStr)] string LibraryPath, [Out] [MarshalAs(UnmanagedType.BStr)] out string Result, [Out] out int NumLibraries);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Value">Value</param>
    [PreserveSig]
    void _LogExceptionDump([In] ref int Value);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MajorVersion">MajorVersion</param>
    /// <param name="MinorVersion">MinorVersion</param>
    /// <param name="PointVersion">PointVersion</param>
    [PreserveSig]
    void _GetShapeManagerVersion([Out] out int MajorVersion, [Out] out int MinorVersion, [Out] out int PointVersion);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    string LicenseChallenge();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Response">Response</param>
    [PreserveSig]
    void LicenseResponse([In] [MarshalAs(UnmanagedType.BStr)] string Response);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CustomSettingsType">CustomSettingsType</param>
    /// <param name="FromBuildIdentifier">FromBuildIdentifier</param>
    [PreserveSig]
    bool _CanMigrateCustomSettings([In] CustomSettingsTypeEnum CustomSettingsType, [In] [MarshalAs(UnmanagedType.BStr)] string FromBuildIdentifier);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CustomSettingsType">CustomSettingsType</param>
    /// <param name="FromBuildIdentifier">FromBuildIdentifier</param>
    [PreserveSig]
    bool _MigrateCustomSettings([In] CustomSettingsTypeEnum CustomSettingsType, [In] [MarshalAs(UnmanagedType.BStr)] string FromBuildIdentifier);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ProductKey">ProductKey</param>
    /// <param name="ProductVersion">ProductVersion</param>
    /// <param name="BrandingImagePath">BrandingImagePath</param>
    [PreserveSig]
    PluginLicenseManager GetPluginLicenseManager([In] [MarshalAs(UnmanagedType.BStr)] string ProductKey, [In] [MarshalAs(UnmanagedType.BStr)] string ProductVersion, [In] [MarshalAs(UnmanagedType.Struct)] object? BrandingImagePath = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FeatureId">FeatureId</param>
    /// <param name="Options">Options</param>
    [PreserveSig]
    PluginLicenseManager GetPluginLicenseManager2([In] [MarshalAs(UnmanagedType.BStr)] string FeatureId, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void LoadRealDWGInfrastructure();
}

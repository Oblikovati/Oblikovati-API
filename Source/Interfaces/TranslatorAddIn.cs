namespace Oblikovati.API;

/// <summary>
/// Object that represents an Translator AddIn inside Autodesk Inventor.
/// </summary>
public interface TranslatorAddIn
{
    /// <summary>
    /// Gets the CLSID of the AddIn as the string used in the class moniker.
    /// </summary>
    string ClassIdString { get; }
    /// <summary>
    /// Gets the ProgID of the AddIn.
    /// </summary>
    string ProgId { get; }
    /// <summary>
    /// Gets the displayable name of the AddIn.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the short display name of the Add-in. Used in places to succinctly identify the AddIn inside Inventor's UI.
    /// </summary>
    string ShortDisplayName { get; }
    /// <summary>
    /// Gets the description of the AddIn.
    /// </summary>
    string Description { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool StartUpEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Version { get; }
    /// <summary>
    /// Gets and sets whether the AddIn is hidden or not.
    /// </summary>
    bool Hidden { get; set; }
    /// <summary>
    /// Gets and sets whether the AddIn is allowed to be unloaded by the user.
    /// </summary>
    bool UserUnloadable { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this AddIn.
    /// </summary>
    ApplicationAddInTypeEnum AddInType { get; }
    /// <summary>
    /// Gets a Boolean flag indicating whether this AddIn is currently active in the session.
    /// </summary>
    bool Activated { get; }
    /// <summary>
    /// Property that returns the Add-in's automation interface (if any). Fails if the Add-in is currently inactive.
    /// </summary>
    object Automation { get; }
    /// <summary>
    /// Gets and sets the current data version of the AddIn.&nbsp;This value corresponds to the 'Data Version' registry entry in the AddIn's registry hive.
    /// </summary>
    int DataVersion { get; set; }
    /// <summary>
    /// Gets the license status of the AddIn.
    /// </summary>
    AddInLicenseStatusEnum LicenseStatus { get; }
    /// <summary>
    /// Property that returns a GUID in string format that uniquely identifies this Add-in. This GUID is used as an identifier when creating Add-in specific objects such as user interface elements, client features, etc.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Application object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the full file name of the dll associated with this Add-in.
    /// </summary>
    string Location { get; }
    /// <summary>
    /// Property that returns the version of the user interface of the add-in. Incrementing this version results in all of the add-in"s UI getting cleaned up during Inventor start-up.
    /// </summary>
    int UserInterfaceVersion { get; }
    /// <summary>
    /// Gets a constant indicating the load behavior (load time) of the add-in. This applies only if the LoadAutomatically property is set to True.
    /// </summary>
    AddInLoadBehaviorEnum LoadBehavior { get; }
    /// <summary>
    /// Gets/Sets whether the add-in loads automatically based on the load behavior specified for the add-in.&nbsp;If set to False, the add-in needs to be manually loaded by the user.
    /// </summary>
    bool LoadAutomatically { get; set; }
    /// <summary>
    /// Property that gets whether this translator supports opening files.
    /// </summary>
    bool SupportsOpen { get; }
    /// <summary>
    /// Property that gets whether this translator supports saving data to a file.
    /// </summary>
    bool SupportsSaveCopyAs { get; }
    /// <summary>
    /// Property that gets the semicolon-separated list of the native file extensions that this translator reads from and/or writes to.
    /// </summary>
    string FileExtensions { get; }
    /// <summary>
    /// Property that gets the filter text string to be displayed in the file dialog for this translator.
    /// </summary>
    string FilterText { get; }
    /// <summary>
    /// Gets whether the translator has options available for opening the specified data-source.
    /// </summary>
    bool HasOpenOptions { get; }
    /// <summary>
    /// Gets whether the translator has options available for saving the specified data-source.
    /// </summary>
    bool HasSaveCopyAsOptions { get; }
    /// <summary>
    /// Gets/Sets a Boolean flag indicating whether this Translator is available to Inventor, regardless of whether it is loaded or not.
    /// </summary>
    bool TranslatorAvailable { get; set; }
    /// <summary>
    /// Property that returns semicolon-separated Inventor file types that this translator supports importing into. Example: ".iam;.ipt."
    /// </summary>
    string SupportsImportInto { get; }
    /// <summary>
    /// Property that returns semicolon-separated Inventor file types that this translator supports opening into. Example: ".iam;.ipt."
    /// </summary>
    string SupportsOpenInto { get; }
    /// <summary>
    /// Property that returns semicolon-separated Inventor file types that this translator supports saving from. Example: ".iam;.ipt."
    /// </summary>
    string SupportsSaveCopyAsFrom { get; }
    /// <summary>
    /// Creates and initializes the AddIn. No effect if AddIn already active.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Invokes the shutdown sequence on the AddIn. No effect if AddIn inactive.
    /// </summary>
    [PreserveSig]
    void Deactivate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentTypes">DocumentTypes</param>
    [PreserveSig]
    void DocumentTypesSupported([Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] DocumentTypes);
    /// <summary>
    /// Show the open options for the specified data-source. This method is only called if True was returned from HasOpenOptions.
    /// </summary>
    /// <param name="SourceData">Input DataMedium object that specifies the data source.</param>
    /// <param name="Context">Input TranslationContext object that can be used to determine the context for the translation.</param>
    /// <param name="ChosenOptions">Input NameValueMap that specifies the options chosen.</param>
    [PreserveSig]
    void ShowOpenOptions([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap ChosenOptions);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceData">SourceData</param>
    /// <param name="Context">Context</param>
    /// <param name="Options">Options</param>
    /// <param name="TargetObject">TargetObject</param>
    [PreserveSig]
    void Open([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object TargetObject);
    /// <summary>
    /// Show the save options for the specified data-source. This method is only called if True was returned from HasSaveCopyAsOptions.
    /// </summary>
    /// <param name="SourceObject">Input object that specifies the source of the data to show the save options for.</param>
    /// <param name="Context">Input TranslationContext object that can be used to determine the context for the translation.</param>
    /// <param name="ChosenOptions">Input NameValueMap that specifies the options chosen.</param>
    [PreserveSig]
    void ShowSaveCopyAsOptions([In] [MarshalAs(UnmanagedType.IDispatch)] object SourceObject, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap ChosenOptions);
    /// <summary>
    /// Save the document to the specified data-source.
    /// </summary>
    /// <param name="SourceObject">Input object that specifies the source of the data to be saved. This can be a Document or FlatPattern object. FlatPattern can be exported to DXF, DWG, STEP and IGES formats.</param>
    /// <param name="Context">Input TranslationContext object that can be used to determine the context for the translation.</param>
    /// <param name="Options">Input NameValueMap that specifies translation options.</param>
    /// <param name="TargetData">Input DataMedium object that specifies the medium of the data to be saved.</param>
    [PreserveSig]
    void SaveCopyAs([In] [MarshalAs(UnmanagedType.IDispatch)] object SourceObject, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] [MarshalAs(UnmanagedType.Interface)] DataMedium TargetData);
    /// <summary>
    /// Obtains the thumbnail, if any, for the given data-source. Could be a metafile handle (long) or the interface to a StdPicture object.
    /// </summary>
    /// <param name="SourceData">Input DataMedium object that specifies the data source.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetThumbnail([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData);
}

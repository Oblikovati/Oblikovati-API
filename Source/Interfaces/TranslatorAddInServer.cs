namespace Oblikovati.API;

/// <summary>
/// Object required to be supported by Server to qualify as an Autodesk Inventor Translator AddIn.
/// </summary>
public interface TranslatorAddInServer
{
    /// <summary>
    /// Gets the IUnknown of the object implemented inside the AddIn that supports AddIn-specific API.
    /// </summary>
    object Automation { get; }
    /// <summary>
    /// Gets whether the translator has options available for opening the specified data-source.
    /// </summary>
    bool HasOpenOptions { get; }
    /// <summary>
    /// Gets whether the translator has options available for saving the specified data-source.
    /// </summary>
    bool HasSaveCopyAsOptions { get; }
    /// <summary>
    /// Invoked by  Oblikovati after creating the AddIn. AddIn should initialize within this call.
    /// </summary>
    /// <param name="AddInSiteObject">Input argument that specifies the object, which provides access to the Autodesk Inventor Application object.</param>
    /// <param name="FirstTime">The FirstTime flag, if True, indicates to the Addin that this is the first time it is being loaded and to take some specific action. It does not take these actions when this flag is False. Typically, when the flag is True, the AddIn proceeds to create all of the objects under the UserInterfaceManager that it needs - Environments, Ribbons and Controls. These objects are persistent, but if this is the first time the Addin is loaded, they need to be created from scratch. When the FirstTime flag is False, meaning the Addin has already been loaded, it only needs to create the objects under the CommandManager - CommandCategories and ControlDefinitions.</param>
    [PreserveSig]
    void Activate([In] [MarshalAs(UnmanagedType.Interface)] ApplicationAddInSite AddInSiteObject, [In] bool FirstTime);
    /// <summary>
    /// Invoked by  Oblikovati to shut down the AddIn. AddIn should complete shutdown within this call.
    /// </summary>
    [PreserveSig]
    void Deactivate();
    /// <summary>
    /// Invoked by  Oblikovati in response to user requesting the execution of an AddIn-supplied command. AddIn must perform the command within this call.
    /// </summary>
    /// <param name="CommandID">Input Long that specifies the command to execute.</param>
    [PreserveSig]
    void ExecuteCommand(int CommandID);
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
    void Open([In] [MarshalAs(UnmanagedType.Interface)] DataMedium SourceData, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] [Out] [MarshalAs(UnmanagedType.IDispatch)] ref object TargetObject);
    /// <summary>
    /// Show the save options for the specified data-source. This method is only called if True was returned from HasSaveCopyAsOptions.
    /// </summary>
    /// <param name="SourceObject">Input object that specifies the source of the data to show the save options for.</param>
    /// <param name="Context">Input TranslationContext object that can be used to determine the context for the translation.</param>
    /// <param name="ChosenOptions">Input NameValueMap that specifies the options chosen.</param>
    [PreserveSig]
    void ShowSaveCopyAsOptions([In] [MarshalAs(UnmanagedType.IDispatch)] object SourceObject, [In] [MarshalAs(UnmanagedType.Interface)] TranslationContext Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap ChosenOptions);
    /// <summary>
    /// Save the specified document to the specified data-source.
    /// </summary>
    /// <param name="SourceObject">Input object that specifies the source of the data to be saved.</param>
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

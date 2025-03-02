namespace Oblikovati.API;

/// <summary>
/// The BrowserPanes object provides access to the existing objects of the browser and allows you to create additional panes. See the article in the overviews section.
/// </summary>
public interface BrowserPanes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of browser panes in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    BrowserPane Item { get; }
    /// <summary>
    /// Property that returns the that is currently being displayed.
    /// </summary>
    BrowserPane ActivePane { get; }
    /// <summary>
    /// Property that returns the collection of ClientNodeResource objects. A ClientNodeResource holds the icons necessary to define the open, closed and status images for all of the ClientBrowserNodes associated with this document. The ClientNodeResources collection has a method that allows you to add a new set of images that can then be used to create a new ClientBrowserNodeDefinition.
    /// </summary>
    ClientNodeResources ClientNodeResources { get; }
    /// <summary>
    /// Property that returns the events sink object for the BrowserPanes object.
    /// </summary>
    BrowserPanesEvents BrowserPanesEvents { get; }
    /// <summary>
    /// Method that creates and returns a new BrowserPane object. The BrowserPane created is one that is explicitly used to house ActiveX controls.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the BrowserPane object. This is the name that will be displayed to the user. The name must be unique with respect to the other browser panes currently created for the document. It can be changed programmatically at any time, and can be localized. It can also be used as an index into the BrowserPanes collection.</param>
    /// <param name="InternalName">Input string that identifies the ActiveX control that will be displayed on the pane. This identifier can be either the ProgID or the GUID of the control as a string, (including the braces "{ }"). This string will also be used to uniquely identify the BrowserPane within the collection. This identifier string once provided cannot be changed.</param>
    /// <returns></returns>
    [PreserveSig]
    BrowserPane Add([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName);
    /// <summary>
    /// Method that creates and returns a new BrowserPane object. The BrowserPane created is one in which Oblikovati's BrowserTreeNodes can be instanced to generate a completely customizable tree view.
    /// </summary>
    /// <param name="Name">Input string that specifies the name of the browser pane. This is the name that will be displayed to the user. The name must be unique with respect to the other browser panes currently created for the document. It can be changed programmatically at any time, and can be localized. It can also be used as an index into the BrowserPanes collection.</param>
    /// <param name="InternalName">Input string that uniquely identifies the application. Suggestions are to use the 'ProgID' of the Add-In creating the pane or its CLSID in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", although any unique string is valid. If the Add-In is going to create more than one such pane, you would want to further qualify the string by appending a suffix to the CLSID, say "{}:0" and "{}:1", etc.</param>
    /// <param name="TopNodeDefinition">Input definition object that will be used to build the single topmost node that starts the browser tree.</param>
    /// <returns></returns>
    [PreserveSig]
    BrowserPane AddTreeBrowserPane([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.Interface)] BrowserNodeDefinition TopNodeDefinition);
    /// <summary>
    /// Method that creates a new The definition object can then be further used to construct ClientBrowserNodes that make up the tree in a custom tree-browser pane. The new ClientBrowserNodeDefinition is returned. Note that this node definition object is constructed and has an identity within the 'name space' or context of the entire owning document.
    /// </summary>
    /// <param name="Label">Input string that specifies the label of the browser node. This label will be displayed as the text of this resulting browser node.</param>
    /// <param name="Id">Input long that uniquely identifies the Client Browser Node Definition within the scope of this Document.</param>
    /// <param name="Icon">ClientNodeResource that specifies the bitmap pictures for the node.</param>
    /// <param name="ToolTipText">Optional input string that specifies the tool tip to be displayed for the node.</param>
    /// <param name="ExpandedIcon">Optional input of a 16X16 pixel image. If this argument is not supplied then the StandardIcon is used for the purpose when the corresponding BrowserNode is to be displayed in an expanded state.</param>
    /// <param name="DisplayState">Optional input BrowserNodeDisplayStateEnum that specifies the display state to use for the node.</param>
    /// <param name="StateIconToolTipText">Optional input string that specifies the tool tip to be displayed for the state icon.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientBrowserNodeDefinition CreateBrowserNodeDefinition([In] [MarshalAs(UnmanagedType.BStr)] string Label, [In] int Id, [In] [MarshalAs(UnmanagedType.Interface)] ClientNodeResource Icon, [In] [MarshalAs(UnmanagedType.Struct)] object? ToolTipText = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ExpandedIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayState = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StateIconToolTipText = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="TopNodeDefinition">TopNodeDefinition</param>
    [PreserveSig]
    BrowserPane AddTransientTreeBrowserPane([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.Interface)] BrowserNodeDefinition TopNodeDefinition);
    /// <summary>
    /// Method to obtain the NativeBrowserNodeDefinition object corresponding to a data model object.Also see CreateNativeBrowserNodeDefinition for information on creating a new client browser node definition.
    /// </summary>
    /// <param name="NativeObject">The object for whom to obtain the NativeBrowserNodeDefinition.</param>
    /// <returns></returns>
    [PreserveSig]
    NativeBrowserNodeDefinition GetNativeBrowserNodeDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object NativeObject);
    /// <summary>
    /// Method that returns the specified ClientBrowserNodeDefinition.
    /// </summary>
    /// <param name="ClientId">Input string that specifies ClientId associated with the definition.</param>
    /// <param name="Id">Input long that uniquely identifies the Client Browser Node Definition within the scope of this Document.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientBrowserNodeDefinition GetClientBrowserNodeDefinition([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] int Id);
    /// <summary>
    /// Method that creates and returns a new BrowserPane object. The BrowserPane created is one that is explicitly used to house un-registered ActiveX Controls.
    /// </summary>
    /// <param name="Name">Input string that specifies the name of the browser pane.  This is the name that will be displayed to the user.  And thus is expected to be localized. The name must be unique with respect to the other browser panes currently created for the document. It can be changed, programmatically, at any time. It may also be used to index into the BrowserPanes collection.</param>
    /// <param name="InternalName">Input string that uniquely identifies the application. Suggestions are to use the 'ProgID' of the Add-In creating the pane or its CLSID in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", although any unique string is valid. If the Add-In is going to create more than one such pane, you would want to further qualify the string by appending a suffix to the CLSID, say "{}:0" and "{}:1", etc.</param>
    /// <param name="ManifestFileName">Input the full filename of the manifest which defines the information of an un-registered ActiveX control.
    /// Sample manifest can be like below:
    /// <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
    /// <assembly xmlns="urn:schemas-microsoft-com:asm.v1" manifestVersion="1.0">
    /// <file name = "x64\SimpleMFCControl.ocx">
    /// <typelib tlbid="{E230D8E9-C189-49AA-A932-01B5F43507EB}" version="1.0" helpdir=""/>
    /// <comClass progid = "SIMPLEMFCCONTROL.SIMPLEMFCCONTROLCtrl.1" clsid="{50CCD357-FA53-42B6-8B06-C5D6AB37CDBF}" threadingModel = "Apartment"/>
    /// </file>
    /// <comInterfaceExternalProxyStub name="_DSIMPLEMFCCONTROLEvents" iid="{B1A2EFBE-A44E-4A40-A4CA-801685A6A624}" tlbid="{E230D8E9-C189-49AA-A932-01B5F43507EB}" proxyStubClsid32="{00020420-0000-0000-C000-000000000046}"/>
    /// <comInterfaceExternalProxyStub name="_DSIMPLEMFCCONTROL" iid="{EA9F39CD-0356-4F7C-8DA8-DE913DB64D99}" tlbid="{E230D8E9-C189-49AA-A932-01B5F43507EB}" proxyStubClsid32="{00020420-0000-0000-C000-000000000046}"/>
    /// </assembly></param>
    /// <returns></returns>
    [PreserveSig]
    BrowserPane AddByManifest([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string ManifestFileName);
    /// <summary>
    /// Method that returns the NativeBrowserNodeDefinition that corresponds to the input object.
    /// </summary>
    /// <param name="NativeObject">Input object to return the definition for.</param>
    /// <param name="Options">Optinoal input NameValueMap object to specify options for how to find the definition. Below are the valid values:
    /// Name = DepthFirst, Value = Boolean that indicates whether the search is depth first. If this is set to Ture then it will search the browser nodes recursively in depth level, otherwise it will search the top browser nodes first and then their children. If this is not specified it defaults to True.</param>
    /// <returns></returns>
    [PreserveSig]
    NativeBrowserNodeDefinition GetNativeBrowserNodeDefinitionWithOptions([In] [MarshalAs(UnmanagedType.IDispatch)] object NativeObject, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}

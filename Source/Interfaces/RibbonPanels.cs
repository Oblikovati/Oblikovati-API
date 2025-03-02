namespace Oblikovati.API;

/// <summary>
/// The RibbonPanels collection object provides access to all existing panels within a ribbon tab and provides methods to create additional panels.
/// </summary>
public interface RibbonPanels : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns the specified RibbonPanel object from the collection.
    /// </summary>
    RibbonPanel this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new RibbonPanel within a ribbon tab. The newly created RibbonPanel is returned.
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the ribbon panel. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the unique internal name of the ribbon panel. This is the internal name and is not displayed to the user. The name must be unique with respect to all other ribbon panels within the tab. The name should remain constant in all locales so it can be used to find a specific panel.</param>
    /// <param name="ClientId">Input String that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580\-3817\-11D0\-BE4E\-080036E87B02}". If supplied, this string is used at Inventor start up time to determine whether the AddIn that created this ribbon panel has since been uninstalled. If so, the panel is deleted.The string is also used to find all the panels to delete when the associated Add\-in is unloaded. A 'dummy' string or a null string can be specified, but is not recommended.</param>
    /// <param name="TargetPanelInternalName">Optional input String that specifies the internal name of an existing panel to position the new panel next to. If specified, the InsertBeforeTargetPanel argument indicates whether to place the new panel before or after the target panel. If not specified, the new panel is positioned at the end.</param>
    /// <param name="InsertBeforeTargetPanel">Optional input Boolean that specifies whether to position the new panel before or after the target ribbon panel. The argument defaults to False and is not used if the TargetPanelInternalName argument is not specified.</param>
    /// <returns></returns>
    [PreserveSig]
    RibbonPanel Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetPanelInternalName = "", [In] bool? InsertBeforeTargetPanel = false);
}

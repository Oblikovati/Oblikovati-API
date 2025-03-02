namespace Oblikovati.API;

/// <summary>
/// The RibbonTabs collection object provides access to all existing tabs within a ribbon and provides methods to create additional tabs.
/// </summary>
public interface RibbonTabs : IEnumerable
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
    /// Returns the specified RibbonTab object from the collection.
    /// </summary>
    RibbonTab this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new RibbonTab within a ribbon. The newly created RibbonTab is returned.
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the ribbon tab. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the unique \internal name of the ribbon tab. This is the internal name and is not displayed to the user. The name must be unique with respect to all other ribbon tabs. The name should remain constant in all locales so it can be used to find a specific tab.</param>
    /// <param name="ClientId">Input String that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580\-3817\-11D0\-BE4E\-080036E87B02}". If supplied, this string is used at Inventor start up time to determine whether the AddIn that created this ribbon tab has since been uninstalled. If so, the tab is deleted.The string is also used to find all the tabs to delete when the associated Add\-in is unloaded. A 'dummy' string or a null string can be specified, but is not recommended.</param>
    /// <param name="TargetTabInternalName">Optional input String that specifies the internal name of an existing tab to position the new tab next to. If specified, the InsertBeforeTargetTab argument indicates whether to place the new tab before or after the specified tab. If not specified, the new tab is positioned at the end.</param>
    /// <param name="InsertBeforeTargetTab">Optional input Boolean that specifies whether to position the new tab before or after the target ribbon tab. The argument defaults to False and is not used if the TargetTabInternalName argument is not specified.</param>
    /// <param name="Contextual">Optional input Boolean that specifies whether this is a contextual tab. Contextual tabs, such as the Sketch tab in the Sketch environment, come and go based on the current environment. They are displayed in a different color to indicate to the user that this is not a permanent tab. If not provided, this argument defaults to False. If a value of False is provided, the tab is added visibly. If a value of True is provided, the tab is added invisibly. Contextual tabs should then be added to the Environment.AdditionalVisibleRibbonTabs so that they show up visible in the appropriate environment(s).</param>
    /// <returns></returns>
    [PreserveSig]
    RibbonTab Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string? TargetTabInternalName = "", [In] bool? InsertBeforeTargetTab = false, [In] bool? Contextual = false);
}

namespace Oblikovati.API;

/// <summary>
/// The CommandBars collection object provides access to all of the objects in Autodesk Inventor.
/// </summary>
public interface CommandBars : IEnumerable
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
    /// Property that returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    CommandBar Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new CommandBar object.
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the command bar. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the name of the command bar. This is the internal name and is not displayed to the user. The name must be unique with respect to all other command bars and control definitions in Inventor. The name should remain constant in all locales so it can be used to find a specific command bar.</param>
    /// <param name="CommandBarType">Optional input that specifies the type of command bar to create. Valid inputs are kRegularCommandBar, kPopupCommandBar, kButtonPopupCommandBar, kSplitButtonCommandBar and kSplitButtonMRUCommandBar. Command bars would typically be created as regular toolbars (using the kRegularCommandBar type). If the intention is to use the command bar in a pop-up, a button pop-up, a split button control or an MRU (Most Recently Used) split button control, the type should be specified as kPopupCommandBar, kButtonPopupCommandBar, kSplitButtonCommandBar and kSplitButtonMRUCommandBar, respectively. The default value is kRegularCommandBar.</param>
    /// <param name="ClientId">Optional input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}". If supplied, this string is used at Inventor start up time to determine whether the AddIn that created this command bar has since been uninstalled. If so, the command bar is deleted. Do not use this argument if programming in VBA unless you do not want the command bar to be persisted to the next session.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBar Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] CommandBarTypeEnum? CommandBarType = CommandBarTypeEnum.kRegularCommandBar, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default);
}

namespace Oblikovati.API;

/// <summary>
/// The CommandBar object represents an individual command bar. See the article in the overviews section.
/// </summary>
public interface CommandBar
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent of the CommandBar.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns whether the command bar is built-in or not. True if it is a standard Autodesk Inventor command bar. A built-in command bar has restrictions on the modifications that can be performed. For example, a built-in command bar cannot be deleted.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that returns the collection. This collection provides access to the controls on the command bar.
    /// </summary>
    CommandBarControls Controls { get; }
    /// <summary>
    /// Property returning the type of the command bar. The possible return values are kRegularCommandBar, kPopupCommandBar, kButtonPopupCommandBar, kSplitButtonCommandBar and kSplitButtonMRUCommandBar.
    /// </summary>
    CommandBarTypeEnum CommandBarType { get; }
    /// <summary>
    /// Property that returns the display name. This is the name that is displayed to the user.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Property that returns the name. The name is the internal unique identifier for the CommandBar.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that specifies if this command bar is visible or not. Setting this property will fail if the CommandBarType is not kRegularCommandBar.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Method that creates a by making a copy of this command bar. New command bar controls are created for the copied command bar, but the underlying definitions for the control are the same.
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the copied command bar. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the name of the copied command bar. This is the internal name and is not displayed to the user. The name must be unique with respect to all other command bars and control definitions in Inventor. The name should remain constant in all locales so it can be used to find a specific command bar.</param>
    /// <param name="ClientId">Optional input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}'. If supplied, this string is used at Inventor start up time to determine whether the AddIn that created this command bar has since been uninstalled. If so, the command bar is deleted. Do not use this argument if programming in VBA unless you do not want the command bar to be persisted to the next session.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandBar Copy([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string? ClientId = "");
    /// <summary>
    /// Method that deletes this CommandBar object.
    /// </summary>
    [PreserveSig]
    void Delete();
}

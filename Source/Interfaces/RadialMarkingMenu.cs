namespace Oblikovati.API;

/// <summary>
/// The RadialMarkingMenu object provides access to the contents of the radial marking menu (displayed when the user right clicks).
/// </summary>
public interface RadialMarkingMenu
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
    /// Gets and sets the command to display in the east control.
    /// </summary>
    object EastControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the north control.
    /// </summary>
    object NorthControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the north-east control.
    /// </summary>
    object NortheastControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the north-west control.
    /// </summary>
    object NorthwestControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the south control.
    /// </summary>
    object SouthControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the south-east control.
    /// </summary>
    object SoutheastControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the south-west control.
    /// </summary>
    object SouthwestControl { get; set; }
    /// <summary>
    /// Gets and sets the command to display in the west control.
    /// </summary>
    object WestControl { get; set; }
    /// <summary>
    /// Read-only property that indicates if this radial marking menu is a standard Inventor marking menu or one created by an add-in.&nbsp;Returns True in the case where it’s an Inventor marking menu.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Read-only property that returns the string that uniquely identifies the client that created this radial marking menu. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// If the menu is built-in, an empty string is returned.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Read-only property that returns the internal name of the radial marking menu.&nbsp;This is a unique name with respect to all other radial marking menus and can be used to access a specific radial marking menu.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the radial marking menu.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Method that creates a transient RadialMarkingMenu.&nbsp;This object can then be assigned to any of the radial menu controls to create a sub-menu.&nbsp;Controls within the sub-menu can be left un-assigned to indicate the absence of those controls.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the sub-menu.</param>
    /// <returns></returns>
    [PreserveSig]
    RadialMarkingMenu CreateRadialSubMenu([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Method that deletes this radial marking menu.&nbsp;Standard Oblikovati radial marking menus cannot be deleted, so this method is only valid for radial marking menus where the BuiltIn property returns False.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that clears the all of the controls for this radial marking menu.&nbsp;This is equivalent to assigning Nothing to each control. When no controls are defined, the radial marking menu is not displayed.
    /// </summary>
    [PreserveSig]
    void Clear();
}

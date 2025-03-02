namespace Oblikovati.API;

/// <summary>
/// The RadialMarkingMenus object provides access to the existing radial marking menus and provides the ability to create additional radial marking menus.
/// </summary>
public interface RadialMarkingMenus : IEnumerable
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
    /// Returns the specified RadialMarkingMenu from the collection.
    /// </summary>
    RadialMarkingMenu this[object Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new radial marking menu.&nbsp;The newly created marking menu is returned.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the radial marking menu. This is the name that the user will see in the Customize dialog.</param>
    /// <param name="InternalName">Input String that specifies the unique identifier for this radial marking menu.  The name specified must be unique with respect to all other radial marking menus or an error will occur.</param>
    /// <param name="ClientId">Input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <returns></returns>
    [PreserveSig]
    RadialMarkingMenu Add([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
}

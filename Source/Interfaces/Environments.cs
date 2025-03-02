namespace Oblikovati.API;

/// <summary>
/// The Environments collection object provides access to all of the existing objects, and allows creation of new ones. See the UI customization and Environments overviews for more information.
/// </summary>
public interface Environments : IEnumerable
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
    /// Returns the specified Environment object from the collection.
    /// </summary>
    Environment this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of Environments in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Environment object.
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the environment. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the name of the environment. This is the internal name and is not displayed to the user. The name must be unique with respect to all other environments and is typically a GUID. The name should remain constant in all locales to it can be used to find a specific environment.</param>
    /// <param name="ClientId">Optional input string that uniquely identifies the client. Ignored for VBA clients, but Addins should supply the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}". If supplied, this string is used at Inventor start up time to determine whether the AddIn that created this environment has since been uninstalled. If so, the environment is deleted. If a ClientId is supplied, it must be the CLSID of an Add-in, else the method returns a failure.</param>
    /// <param name="StandardIcon">Optional input Picture object that specifies the standard size icon to use for the environment. A standard size icon is 16 pixels wide and 16 pixels high. All icons use 16 colors. If not supplied the icon from the source environment will be used.</param>
    /// <param name="LargeIcon">Optional input Picture object that specifies the large size icon to use for the environment. A large size icon is 24 pixels wide and 24 pixels high. All icons use 16 colors. If not supplied and a standard size icon is supplied a large icon will be automatically created by scaling the standard size icon. Because scaling a bitmap does not necessarily create a good image, it is recommended that you create and supply a large bitmap.</param>
    /// <returns></returns>
    [PreserveSig]
    Environment Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default);
}

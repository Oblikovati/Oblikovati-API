namespace Oblikovati.API;

/// <summary>
/// The CustomParameterGroups collection object provides access to all existing custom parameter groups and provides methods to create additional groups
/// </summary>
public interface CustomParameterGroups : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified CustomParameterGroup object from the collection.
    /// </summary>
    CustomParameterGroup Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a custom parameter group.
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the custom group. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the name of the custom group. This is the internal name and is not displayed to the user. The name must be unique with respect to all other groups. The name should remain constant in all locales to it can be used to find a specific group.</param>
    /// <param name="ClientId">Optional input string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <returns></returns>
    [PreserveSig]
    CustomParameterGroup Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string? ClientId = "");
}

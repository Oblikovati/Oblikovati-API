namespace Oblikovati.API;

/// <summary>
/// The CommandCategories collection object provides access to all existing objects and provides methods to create additional categories. See the article in the overviews section.
/// </summary>
public interface CommandCategories : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    CommandCategory this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a .
    /// </summary>
    /// <param name="DisplayName">Input string that defines the display name of the command category. This is the name that is displayed to the user and should be localized for different locales.</param>
    /// <param name="InternalName">Input string that defines the name of the command category. This is the internal name and is not displayed to the user. The name must be unique with respect to all other command categories. The name should remain constant in all locales to it can be used to find a specific command category.</param>
    /// <param name="ClientId">Input string that uniquely identifies the client. Suggestions are the 'ProgID' of the Add-In creating the resource or its CLSID in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", although any unique string is valid. If you do not use a CLSID or a ProgID, it is recommended that you add your application name to the ClientId to help eliminate naming conflicts.</param>
    /// <returns></returns>
    [PreserveSig]
    CommandCategory Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default);
}

namespace Oblikovati.API;

/// <summary>
/// The ClientGraphicsCollection object provides access to all of the existing objects associated with a graphics container.
/// </summary>
public interface ClientGraphicsCollection : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returns the logical parent of this object. This could currently be a ComponentDefinition or an AssemblyOccurrence.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an existing ClientGraphics object.
    /// </summary>
    ClientGraphics Item { get; }
    /// <summary>
    /// Property that returns the number of ClientGraphics objects associated with the graphic container.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns whether the creation of this ClientGraphicsColection object and all its associated data is non-transacting.
    /// </summary>
    bool NonTransacting { get; }
    /// <summary>
    /// Method that creates a new ClientGraphics object. The identifier supplied needs to uniquely identify the client. The method will fail in the case where a ClientGraphics object with this ClientId already exists on the object.
    /// </summary>
    /// <param name="ClientId">Input string that uniquely identifies the application. Suggestion are the 'ProgID' of the Add-In creating the graphics or the its CLSID in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02},"although any unique string is valid.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientGraphics Add([In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    [PreserveSig]
    ClientGraphics AddNonTransacting([In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
}

namespace Oblikovati.API;

/// <summary>
/// This object is accessible through the . But it is in fact, just the one associated with the Document. In other words, all of the ClientNodeResource objects that are used inside the various BrowserPanes of this Document are to be found here.
/// </summary>
public interface ClientNodeResources : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified NodeResource object from the collection.
    /// </summary>
    ClientNodeResource Item { get; }
    /// <summary>
    /// Returns the specified NodeResource object from the collection.
    /// </summary>
    /// <param name="ClientId">String that was specified by the client or AddIn when the resource was created.</param>
    /// <param name="Id">Input value that specifies the integer identifier that the client or AddIn had supplied while creating the resource.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientNodeResource ItemById([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] int Id);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="Id">Id</param>
    /// <param name="Icon">Icon</param>
    [PreserveSig]
    ClientNodeResource Add([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] int Id, [In] [MarshalAs(UnmanagedType.Interface)] IPictureDisp Icon);
    /// <summary>
    /// Method which creates new client resource object.
    /// </summary>
    /// <param name="ClientId">Input string that uniquely identifies the client. Suggestions are the ‘ProgID’ of the Add-In creating the resource or the its CLSID in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", although any unique string is valid.</param>
    /// <param name="Id">Input integer identifier that uniquely identifies the resource to the client. This identifier better be unique within the context of this owning document, and within this AddIn. The ClientId and the Id taken together uniquely identify this object.</param>
    /// <param name="IconName">Input String value that specifies name of a client icon from ClientResourceMap. If use default node icon an empty string can be provided.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientNodeResource AddNodeResource([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] int Id, [In] [MarshalAs(UnmanagedType.BStr)] string IconName);
}

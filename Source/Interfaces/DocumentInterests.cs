namespace Oblikovati.API;

/// <summary>
/// Description of the collection object. Below are some common methods and properties.
/// </summary>
public interface DocumentInterests : IEnumerable
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
    /// Returns the specified DocumentInterest object from the collection
    /// </summary>
    DocumentInterest Item { get; }
    /// <summary>
    /// Method that returns whether an AddIn with the input ClientId/Name has expressed interest in this document.
    /// </summary>
    /// <param name="ClientIdOrName">Input String that uniquely identifies a client. This could be the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", or the Name of the interest.</param>
    /// <returns></returns>
    [PreserveSig]
    bool HasInterest([In] [MarshalAs(UnmanagedType.BStr)] string ClientIdOrName);
    /// <summary>
    /// Method that creates a new DocumentInterest.
    /// </summary>
    /// <param name="ClientId">Input String that uniquely identifies a client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <param name="Name">Input String that specifies the name associated with this interest. This is typically a string specifying the document 'sub-type'.</param>
    /// <param name="InterestType">Input DocumentInterestTypeEnum that specifies the type of interest that the client has in this document. Valid inputs are kInterested and kNotInterested.</param>
    /// <param name="DataVersion">Optional input Long that specifies the current data version of the document. If not specified, this is assumed to be a 'non-migrating' type of interest. When a document is opened, if this DataVersion value is less than the current DataVersion value of the AddIn (ApplicationAddIn.DataVersion), the 'Migrate' command is enabled. When the user invokes the Migrate command, the OnMigrateDocument event is fired and gives the client an opportunity to migrate their data.</param>
    /// <param name="ClientData">Optional input String that contains some additional data that the client would like to store with the interest. This string is not interpreted by Inventor. Clients are expected to use the string with extreme economy.</param>
    /// <returns></returns>
    [PreserveSig]
    DocumentInterest Add([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] DocumentInterestTypeEnum InterestType, [In] int? DataVersion = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientData = default);
}

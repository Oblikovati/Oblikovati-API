namespace Oblikovati.API;

/// <summary>
/// Represents a ClientResourceMaps collection Object.
/// </summary>
public interface ClientResourceMaps : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ClientResourceMap Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Adds a ClientResourceMap object.
    /// </summary>
    /// <param name="ClientId">Input string that uniquely identifies the client. Some suggestions might be the 'ProgID' of the Add-In creating the resource, or its CLSID in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}", although any unique string is valid.</param>
    /// <param name="Id">Input Long value that uniquely identifies the ClientResourceMap. This identifier must be unique within the context of this owning document, and within this AddIn. The ClientId and the Id taken together uniquely identify this object.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientResourceMap Add([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] int Id);
    /// <summary>
    /// Retrieves a ClientResourceMap object based on the Id.
    /// </summary>
    /// <param name="ClientId">Input string that was specified by the client or AddIn when the client resource map was created.</param>
    /// <param name="Id">Input Long value that specifies the integer identifier that the client or AddIn had supplied while creating the client resource map.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientResourceMap ItemById([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] int Id);
}

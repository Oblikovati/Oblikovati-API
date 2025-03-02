namespace Oblikovati.API;

/// <summary>
/// The ClientGraphicsCollection object allows you to create new objects and supports access to existing GraphicsDataSets objects. See the article in the overview section for more information.
/// </summary>
public interface GraphicsDataSetsCollection : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returns the parent document of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an existing GraphicsDataSets object.
    /// </summary>
    GraphicsDataSets this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of coordinates defined within the set.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns whether the creation of this GraphicsDataSetsCollection object and all its associated data is non-transacting.
    /// </summary>
    bool NonTransacting { get; }
    /// <summary>
    /// Method that creates a new GraphicsDataSets object. When the GraphicsDataSetsCollection object is obtained from a Document, this will always create a transient graphics data object. That is, its lifetime is only for the period of time the document is open.
    /// When the GraphicsDataSetsCollection object is obtained from a ClientFeatureDefinition object, the graphics data objects created are persistent and will be saved with the document. In that case it is only intended to be used for graphics that are associated with a client feature.
    /// </summary>
    /// <param name="ClientId">Specifies the unique identifier for the GraphicsDataSets object. This must be unique with respect to all other GraphicsDataSets objects. Typically, this is a GUID in string form, but any string is valid.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsDataSets Add([In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="SaveWithDocument">SaveWithDocument</param>
    [PreserveSig]
    GraphicsDataSets _Add2([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] bool? SaveWithDocument = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    [PreserveSig]
    GraphicsDataSets AddNonTransacting([In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
}

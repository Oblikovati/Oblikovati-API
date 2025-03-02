namespace Oblikovati.API;

/// <summary>
/// The Profile object defines a set of connected curves used as input for a feature. See the article in the overviews section.
/// </summary>
public interface Profile : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ProfilePath object from the collection.
    /// </summary>
    ProfilePath Item { get; }
    /// <summary>
    /// Property that returns the sketch that the profile was derived from.
    /// </summary>
    Sketch Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the MergeFaces setting.
    /// </summary>
    bool MergeFaces { get; set; }
    /// <summary>
    /// Returns the RegionProperties object.
    /// </summary>
    RegionProperties RegionProperties { get; }
    /// <summary>
    /// Property returning the Wires collection object associated with this Profile.
    /// </summary>
    Wires Wires { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Deletes this profile object.
    /// </summary>
    [PreserveSig]
    void Delete();
}

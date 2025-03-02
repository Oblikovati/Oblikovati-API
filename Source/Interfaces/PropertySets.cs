namespace Oblikovati.API;

/// <summary>
/// Object that manages the collection of objects and provides the ability to add new property sets to the collection. See the article in the overviews section.
/// </summary>
public interface PropertySets : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the set in this collection in a sequences fashion; by index, or by its name -- Display or Internal.
    /// </summary>
    PropertySet Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns a Boolean flag that indicates whether any of the Properties have been edited, deleted or created.
    /// </summary>
    bool Dirty { get; }
    /// <summary>
    /// Adds a new PropertySet. The new set's FMTID can be optionally provided (as a string).
    /// </summary>
    /// <param name="Name">Name of the PropertySet. If the name begins with an underscore the property set is hidden and can only be retrieved by asking for it by name.</param>
    /// <param name="InternalName">Input Variant that specifies the internal name of the PropertySet to be added.</param>
    /// <returns></returns>
    [PreserveSig]
    PropertySet Add([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object? InternalName = default);
    /// <summary>
    /// Refresh all of the Properties in each of the PropertySets from the File. The 'dirty' flags are reset and any edits are lost. Please note that this method is available in Apprentice only.
    /// </summary>
    [PreserveSig]
    void RefreshFromFile();
    /// <summary>
    /// Flush all of the Properties in each of the PropertySets onto the file. The 'dirty' flags are reset. Please note that this method is available in Apprentice only.
    /// </summary>
    [PreserveSig]
    void FlushToFile();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropertySetName">PropertySetName</param>
    /// <param name="PropertySet">PropertySet</param>
    [PreserveSig]
    bool PropertySetExists();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropertySetName">PropertySetName</param>
    /// <param name="PropertySet">PropertySet</param>
    [PreserveSig]
    bool PropertySetExists([In] [MarshalAs(UnmanagedType.BStr)] string PropertySetName, [Out] [MarshalAs(UnmanagedType.Struct)] out object PropertySet);
}

namespace Oblikovati.API;

/// <summary>
/// Object that represents a PropertySet. This is a collection of related Properties. See the article in the overviews section.
/// </summary>
public interface PropertySet : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    PropertySets Parent { get; }
    /// <summary>
    /// Gets/Sets the human-readable name associated with this Property Set.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets the unambiguous, internal name (FMTID) associated with this PropertySet.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets the Property given either its name or its sequential index.
    /// </summary>
    Property this[object Index] { get; }
    /// <summary>
    /// Gets the Property in this set by its PropId.
    /// </summary>
    Property ItemByPropId { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns a Boolean flag that indicates whether any of the Properties have been edited, deleted or created.
    /// </summary>
    bool Dirty { get; }
    /// <summary>
    /// Gets the name of this PropertySet.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _CodePage { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _Locale { get; }
    /// <summary>
    /// Adds a new Property to this PropertySet.
    /// </summary>
    /// <param name="PropValue">Input Variant that specifies the value of the Property to add to the set.</param>
    /// <param name="Name">Input Variant that specifies the name of the Property. When add a property in a custom property set but not the built-in "User Defined Properties" set(whose internal name is {D5CDD505-2E9C-101B-9397-08002B2CF9AE}), if this name is prefixed with an "_" character, then this property is created as a hidden property and can only be accessed if indexed by its name or propID. PropertySet.Count will not account for such hidden properties.</param>
    /// <param name="PropId">Input Variant that specifies the PropertyID of the Property to add to the set. Valid propids are 2 through 254 and 256 through 0x80000000. Other values are reserved.</param>
    /// <returns></returns>
    [PreserveSig]
    Property Add([In] [MarshalAs(UnmanagedType.Struct)] object PropValue, [In] [MarshalAs(UnmanagedType.Struct)] object? Name = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PropId = default);
    /// <summary>
    /// Method that deletes this PropertySet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Ids">Ids</param>
    /// <param name="Names">Names</param>
    /// <param name="Values">Values</param>
    [PreserveSig]
    void GetPropertyInfo([Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] Ids, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[] Names, [Out] [MarshalAs(UnmanagedType.SafeArray)] out object[] Values);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropertyNames">PropertyNames</param>
    /// <param name="PropertyValues">PropertyValues</param>
    [PreserveSig]
    void SetPropertyValues([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] PropertyNames, [In] [MarshalAs(UnmanagedType.SafeArray)] ref object[] PropertyValues);
}

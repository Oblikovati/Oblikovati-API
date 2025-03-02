namespace Oblikovati.API;

/// <summary>
/// Provides access to the objects associated with a specific object and provides the ability to create additional sets on the object. See the article in the overviews section.
/// </summary>
public interface AttributeSets : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the object this attribute set is attached to.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object from the collection. This is the default property of the AttributeSets collection object.
    /// </summary>
    AttributeSet Item { get; }
    /// <summary>
    /// Property that returns whether an existing attribute set has the specified name or not. Multiple AttributeSets with the same name are not allowed within this collection. Returns True if the name is already being used.
    /// </summary>
    bool NameIsUsed { get; }
    /// <summary>
    /// Property that returns the object that allows you to write the contents of all of the AttributeSets attached to object as XML. The DataIO object returned supports the WriteDataToFile method with the format "XML." The AttributeSet names are used as the tag names in the XML data. Because of this, the names must be valid XML tag names. This means they must begin with a letter and can contain the following characters '_', '-', '.'. Spaces are not allowed.
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Method that creates a new for the object the AttributeSets collection was obtained from. The created AttributeSet object is returned.
    /// </summary>
    /// <param name="AttributeSetName">Input String value that specifies the name of the attribute set. The name must be unique with respect to the other attribute sets attached to this object. If it is not unique, an error will occur.</param>
    /// <param name="CopyWithOwner">Property that specifies whether the attribute set should be copied with its owner when the object it is associated with is copied or split. If True, the attribute set is copied.</param>
    /// <returns></returns>
    [PreserveSig]
    AttributeSet Add([In] [MarshalAs(UnmanagedType.BStr)] string AttributeSetName, [In] bool? CopyWithOwner = false);
    /// <summary>
    /// Adds a transient into this collection. This set is transient as it is available only during this session.
    /// </summary>
    /// <param name="AttributeSetName">Input String value that specifies the name of the attribute set. The name must be unique with respect to the other attribute sets attached to this object. If it is not unique, an error will occur.</param>
    /// <param name="CopyWithOwner">Property that specifies whether the attribute set should be copied with its owner when the object it is associated with is copied or split. If True, the attribute set is copied.</param>
    /// <returns></returns>
    [PreserveSig]
    AttributeSet AddTransient([In] [MarshalAs(UnmanagedType.BStr)] string AttributeSetName, [In] bool? CopyWithOwner = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Parent">Parent</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    bool ParentAvailable();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Parent">Parent</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    bool ParentAvailable([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Parent, [Out] [MarshalAs(UnmanagedType.Struct)] out object Context);
}

namespace Oblikovati.API;

/// <summary>
/// The AttributeSet object provides the ability to create new attributes and access existing attributes. See the article in the overviews section.
/// </summary>
public interface AttributeSet : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the Autodesk Inventor object being attributed with this AttributeSet. If this AttributeSet is being shared by more than one Autodesk Inventor object, then an ObjectCollection is returned that contains all of the Autodesk Inventor objects attributed with this AttributeSet.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets/Sets the name of the Attribute Set.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the number of attributes within this attribute set.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified Attribute object from the attribute set. This is the default property of the AttributeSet object.
    /// </summary>
    Attribute this[object Index] { get; }
    /// <summary>
    /// Gets the Boolean flag that controls the behavior of whether this set will copied onto this Inventor Object's copy.
    /// </summary>
    bool CopyWithOwner { get; set; }
    /// <summary>
    /// Gets the Boolean flag that indicates whether this set was created as a result of a operation that copied the owner Inventor Object.
    /// </summary>
    bool Copy { get; set; }
    /// <summary>
    /// Property that returns whether an existing attribute has the specific name or not. Returns True if the name is already being used.
    /// </summary>
    bool NameIsUsed { get; }
    /// <summary>
    /// Property that returns the object that allows you to write the contents of the AttributeSet as XML. The DataIO object returned supports the WriteDataToFile method with the format "XML." The AttributeSet name is used as a tag name in the XML data. Because of this, the name must be a valid XML tag name. This means it must begin with a letter and can contain the following characters '_', '-', '.'. Spaces are not allowed.
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Gets the Boolean flag indicating whether this Attribute set is transient. (Meaning it is available only during this session).
    /// </summary>
    bool Transient { get; }
    /// <summary>
    /// Method that creates a new attribute in the attribute set. The created Attribute object is returned.
    /// </summary>
    /// <param name="AttributeName">Input String value that specifies the name of the attribute. The name must be unique with respect to the other attributes within this attribute set. If it is not unique, a failure will occur. A failure will also occur if the name contains a space.</param>
    /// <param name="ValueType">Input value from that specifies the type of the attribute.</param>
    /// <param name="Value">Input Variant value that specifies the value of the attribute.</param>
    /// <returns></returns>
    [PreserveSig]
    Attribute Add([In] [MarshalAs(UnmanagedType.BStr)] string AttributeName, [In] ValueTypeEnum ValueType, [In] [MarshalAs(UnmanagedType.Struct)] object Value);
    /// <summary>
    /// Method that deletes this AttributeSet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Copies the Attribute Set to another object. Returns reference to the copied Attribute Set.
    /// </summary>
    /// <param name="Object">The object to copy to.</param>
    /// <param name="ReplaceExisting">Indictates whether to replaces an existing attribute set.</param>
    /// <returns></returns>
    [PreserveSig]
    AttributeSet CopyTo([In] [MarshalAs(UnmanagedType.IDispatch)] object Object, [In] bool? ReplaceExisting = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AttributeNames">AttributeNames</param>
    /// <param name="ValueTypes">ValueTypes</param>
    /// <param name="Values">Values</param>
    /// <param name="ReplaceExisting">ReplaceExisting</param>
    [PreserveSig]
    AttributesEnumerator AddAttributes([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] AttributeNames, [In] [MarshalAs(UnmanagedType.SafeArray)] ref ValueTypeEnum[] ValueTypes, [In] [MarshalAs(UnmanagedType.SafeArray)] ref object[] Values, [In] bool ReplaceExisting);
}

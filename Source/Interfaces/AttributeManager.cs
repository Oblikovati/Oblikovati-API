namespace Oblikovati.API;

/// <summary>
/// Dynamic attributes provide the ability for a programmer to add any arbitrary data to any persistent object within Autodesk Inventor.
/// </summary>
public interface AttributeManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns either the Autodesk Inventor document or the ApprenticeServerDocument.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the GUID that represents the last saved revision of this file. Works as a stamp of the contents of this file.
    /// </summary>
    string RevisionId { get; }
    /// <summary>
    /// Method that returns the Attribute objects that match the search criteria.
    /// </summary>
    /// <param name="AttributeSetName">Optional input String value that specifies the name of the owning attribute set. An asterisk can be used as a wild card in the string to match partial strings. If this value is not input it will default to "*" which will match all attribute sets. The search is not case sensitive.</param>
    /// <param name="AttributeName">Optional input String value that specifies the name of the attribute, including a compound name that contains nested sub-Attributes. An asterisk can be used as a wild card in the string to match partial strings. A dot is used as the delimiter between an attribute and its sub-attribute. If this value is not input it will default to "*" which will match all attributes. The search is not case sensitive. Thus, "Color.Green*" will match an object that has an attribute whose name is "color" with a sub-attribute, "green." The sub-attribute could also be "greenish" as well and the match would succeed. But no match is found if a 'color' object is found with no sub-attributes. On the other hand, a query with simply "Color" will match all objects which may or may not have sub-attributes, but do have the direct attribute, "color."</param>
    /// <param name="AttributeValue">Optional input Variant value that specifies the value of the attribute. In the case of attributes that contain string values, an asterisk can be used as a wild card in the string to match partial strings. For other types, exact matches must be made. For some types, the value will be ignored, i.e. arrays. If this argument is not specified it will ignore the value and match based on the AttributeSetName and AttributeName arguments.</param>
    /// <returns></returns>
    [PreserveSig]
    AttributesEnumerator FindAttributes([In] [MarshalAs(UnmanagedType.BStr)] string? AttributeSetName = "*", [In] [MarshalAs(UnmanagedType.BStr)] string? AttributeName = "*", [In] [MarshalAs(UnmanagedType.Struct)] object? AttributeValue = default);
    /// <summary>
    /// Method that returns attribute sets that have the specified names and values.
    /// </summary>
    /// <param name="AttributeSetName">Optional input String value that specifies the name of the attribute set. An asterisk can be used as a wild card in the string to match partial strings. If this value is not input it will default to "*" which will match all attribute sets. The search is not case sensitive.</param>
    /// <param name="AttributeName">Optional input String value that specifies the name of any attribute within the set, including a compound name that contains nested sub-Attributes. An asterisk can be used as a wild card in the string to match partial strings. A dot is used as the delimiter between an attribute and its sub-attribute. If this value is not input it will default to "*" which will match all attributes. The search is not case sensitive. Thus, "Color.Green*" will match an object that has an attribute whose name is "color" with a sub-attribute, "green." The sub-attribute could also be "greenish" as well and the match would succeed. But no match is found if a 'color' object is found with no sub-attributes. On the other hand, a query with simply "Color" will match all objects which may or may not have sub-attributes, but do have the direct attribute, "color."</param>
    /// <param name="AttributeValue">Optional input Variant value that specifies the value of the attribute. In the case of attributes that contain string values, an asterisk can be used as a wild card in the string to match partial strings. For other types, exact matches must be made. For some types, the value will be ignored, i.e. arrays. If this argument is not specified it will ignore the value and match based on the AttributeSetName and AttributeName arguments.</param>
    /// <returns></returns>
    [PreserveSig]
    AttributeSetsEnumerator FindAttributeSets([In] [MarshalAs(UnmanagedType.BStr)] string? AttributeSetName = "*", [In] [MarshalAs(UnmanagedType.BStr)] string? AttributeName = "*", [In] [MarshalAs(UnmanagedType.Struct)] object? AttributeValue = default);
    /// <summary>
    /// Method that returns the objects that have the specified attributes.
    /// </summary>
    /// <param name="AttributeSetName">Optional input String value that specifies the name of the attribute set. An asterisk can be used as a wild card in the string to match partial strings. If this value is not input it will default to "*" which will match all attribute sets. The search is not case sensitive.</param>
    /// <param name="AttributeName">Optional input String value that specifies the name of the attribute. An asterisk can be used as a wild card in the string to match partial strings. If this value is not input it will default to "*" which will match all attributes. The search is not case sensitive.</param>
    /// <param name="AttributeValue">Optional input Variant value that specifies the value of the attribute. In the case of attributes that contain string values, an asterisk can be used as a wild card in the string to match partial strings. For other types, exact matches must be made. For some types, the value will be ignored, i.e. arrays. If this argument is not specified it will ignore the value and match based on the AttributeSetName and AttributeName arguments.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection FindObjects([In] [MarshalAs(UnmanagedType.BStr)] string? AttributeSetName = "*", [In] [MarshalAs(UnmanagedType.BStr)] string? AttributeName = "*", [In] [MarshalAs(UnmanagedType.Struct)] object? AttributeValue = default);
    /// <summary>
    /// Method that returns the objects whose AttributeSets, if converted to XML, satisfy the specified XSL pattern.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection FindObjectsByPattern([In] [MarshalAs(UnmanagedType.BStr)] string XPath);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AttributeSetName">AttributeSetName</param>
    /// <param name="Preview">Preview</param>
    /// <param name="PreviewResult">PreviewResult</param>
    [PreserveSig]
    void PurgeAttributeSets([In] [MarshalAs(UnmanagedType.BStr)] string? AttributeSetName = "*");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AttributeSetName">AttributeSetName</param>
    /// <param name="Preview">Preview</param>
    /// <param name="PreviewResult">PreviewResult</param>
    [PreserveSig]
    void PurgeAttributeSets([In] [MarshalAs(UnmanagedType.BStr)] string AttributeSetName, [In] bool Preview, [Out] [MarshalAs(UnmanagedType.Struct)] out object PreviewResult);
    /// <summary>
    /// Finds the AttributeSet of the given name for each object in the object collection. If it does not find one, it creates a new AttributeSet. returns the in the same order as the object collection. Using this method is several times faster than accessing AttributeSets for each object individually. OpenAttributeSets works correctly even if the given collection has degenerate objects such as an edge for the apex of a cone. In such a case, OpenAttributeSets succeeds for all the valid objects, and returns NULL objects for the degenerate objects.
    /// </summary>
    /// <param name="Objects">Input ObjectCollection.</param>
    /// <param name="AttributeSetName">Input String that specifies the name of the attribute set to find or create.</param>
    /// <returns></returns>
    [PreserveSig]
    AttributeSetsEnumerator OpenAttributeSets([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects, [In] [MarshalAs(UnmanagedType.BStr)] string AttributeSetName);
}

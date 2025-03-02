namespace Oblikovati.API;

/// <summary>
/// The NameValueMap object. This object provides context-specific information, usually the context in which an event occurred. For more information, see the Event Context Information article in the overview section.
/// </summary>
public interface NameValueMap : IEnumerable
{
    /// <summary>
    /// Gets and sets the value of the item associated with the specified name.&nbsp;If the item with the specified name does not exist, it is added to the map.
    /// </summary>
    object Value { get; set; }
    /// <summary>
    /// Property that returns the count of name - value pairs in the map.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the value at the specified index number or key name.
    /// </summary>
    object Item { get; }
    /// <summary>
    /// Property that returns the name associated with the specified integer index.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Add a value associated to the specified key name.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the key.</param>
    /// <param name="Value">Input Variant value that specifies the value of the attribute.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object Value);
    /// <summary>
    /// Removes all objects from the map.
    /// </summary>
    [PreserveSig]
    void Clear();
    /// <summary>
    /// Removes the specified object from the map.
    /// </summary>
    [PreserveSig]
    void Remove([In] [MarshalAs(UnmanagedType.Struct)] object Index);
    /// <summary>
    /// Insert a name value pair into the name value map with specified location.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the key.</param>
    /// <param name="Value">Input Variant value that specifies the value of the attribute.</param>
    /// <param name="TargetIndex">Optional input an index that specifies the existing name value pair next to which the new name value pair will be inserted. This can either be a numeric value indicating the index of an existing name value pair, or it can be a string indicating the name of an existing name value pair in the NameValueMap. If this is not specified, the new name value pair will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the name value pair should be inserted before or after the target index. If not specified, a default value of True is used. This argument is ignored if the value of TargetIndex is not specified.</param>
    [PreserveSig]
    void Insert([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Struct)] object Value, [In] [MarshalAs(UnmanagedType.Struct)] object? TargetIndex = default, [In] bool? InsertBefore = true);
}

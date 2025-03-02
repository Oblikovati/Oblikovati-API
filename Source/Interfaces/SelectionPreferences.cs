namespace Oblikovati.API;

/// <summary>
/// SelectionPreferences object.
/// </summary>
public interface SelectionPreferences : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ObjectTypeEnum this[int Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Adds a type to the selection preferences.
    /// </summary>
    /// <param name="Type">Input ObjectTypeEnum to add an object type item to the collection .</param>
    /// <param name="Index">Optional input an index that specifies the location the item to be added. If not specified the item will be added at the end. If the input index is larger than the count of items the new item will be added at the end.</param>
    [PreserveSig]
    void Add([In] ObjectTypeEnum Type, [In] [MarshalAs(UnmanagedType.Struct)] object? Index = default);
    /// <summary>
    /// Remove a type from the selection preferences.
    /// </summary>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// clear all the types in the selection preferences.
    /// </summary>
    [PreserveSig]
    void Clear();
}

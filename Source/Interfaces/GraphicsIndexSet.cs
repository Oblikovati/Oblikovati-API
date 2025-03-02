namespace Oblikovati.API;

/// <summary>
/// The GraphicsIndexSet object contains a list of indices. This object can be referenced by any number of graphic primitives to use in defining the list of indices that index into a coordinate set.
/// </summary>
public interface GraphicsIndexSet
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of objects in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property returning the unique id of this GraphicsDataSet.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    int IndexValue { get; set; }
    /// <summary>
    /// Method that removes a coordinate from the set.
    /// </summary>
    /// <param name="Index">Specifies the index you want to remove from the set. All coordinates above the Index will be shifted down. The coordinate set indices are one-based.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that deletes the GraphicsDataSet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that adds a new index to the set.
    /// </summary>
    /// <param name="Index">Input Long that specifies the position you want this index to be within the set. All indices above the position will be shifted up to make room for this index. Specifying any number greater than the current count of the set will cause the index to become the last in the set. The index set indices are one-based.</param>
    /// <param name="IndexValue">Input Long that specifies the index value.</param>
    [PreserveSig]
    void Add([In] int Index, [In] int IndexValue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="IndexValues">IndexValues</param>
    [PreserveSig]
    void GetIndices([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] IndexValues);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="IndexValues">IndexValues</param>
    [PreserveSig]
    void PutIndices([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] IndexValues);
}

namespace Oblikovati.API;

/// <summary>
/// The GraphicsNormalSet object contains a list of normals. This object can be referenced by any number of graphic primitives to help define the normals to be used when rendering.
/// </summary>
public interface GraphicsNormalSet
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
    UnitVector Normal { get; set; }
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
    /// Method that adds a new normal to the set.
    /// </summary>
    /// <param name="Index">Specifies the position you want this normal to have within the set. All normals above the position will be shifted up to make room for this normal. Specifying any number greater than the current count of the set will cause the normal to become the last in the set. The normal set indices are one-based, meaning the first normal in the set has an index of one.</param>
    /// <param name="Normal">Input object that specifies the normal to add to the set.</param>
    [PreserveSig]
    void Add([In] int Index, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Normals">Normals</param>
    [PreserveSig]
    void GetNormals([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Normals);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Normals">Normals</param>
    [PreserveSig]
    void PutNormals([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Normals);
}

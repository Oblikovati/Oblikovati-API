namespace Oblikovati.API;

/// <summary>
/// The GraphicsTextureCoordinateSet object contains a list of coordinate values
/// </summary>
public interface GraphicsTextureCoordinateSet
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
    /// Read-write property that gets and sets the value of a specific coordinate within the set.
    /// </summary>
    object Coordinate { get; set; }
    /// <summary>
    /// Read-write property that defines the dimension of the texture coordinate array.
    /// </summary>
    TextureDimensionEnum TextureDimension { get; set; }
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
    /// Method that adds a single coordinate to the set.
    /// </summary>
    /// <param name="Index">Specifies the index you want this coordinate to be within the set. All coordinates above the Index will be shifted up to make room for this index. Specifying any number greater than the current count of the set will cause the coordinate to become the last in the set. The coordinate set indices are one-based.</param>
    /// <param name="Coordinate">Input Double that specifies the value of the coordinate to add. The input is currently limited to double values.</param>
    [PreserveSig]
    void Add([In] int Index, [In] [MarshalAs(UnmanagedType.Struct)] object Coordinate);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coordinates">Coordinates</param>
    [PreserveSig]
    void GetCoordinates([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coordinates">Coordinates</param>
    [PreserveSig]
    void PutCoordinates([In] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coordinates);
}

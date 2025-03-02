namespace Oblikovati.API;

/// <summary>
/// The GraphicsColorMapper object maps scalar values to colors. Use methods provided on the object to define the scalar values and colors. The same object can be used to define the mapping for multiple graphics primitives using the ColorMapper property on the primitives.
/// </summary>
public interface GraphicsColorMapper
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the color at a given index in the set.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Property that returns the number of colors defined within the set.
    /// </summary>
    int ColorCount { get; }
    /// <summary>
    /// Property that returns the color at a given value in the map. This property is informational only and need not be used when assigning a color map to a primitive.
    /// </summary>
    Color MappedColor { get; }
    /// <summary>
    /// Read-write property that gets and sets the value at a given index in the set.
    /// </summary>
    double Value { get; set; }
    /// <summary>
    /// Property that returns the number of values defined within the set.
    /// </summary>
    int ValueCount { get; }
    /// <summary>
    /// Method that deletes the GraphicsColorMapper object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Colors">Colors</param>
    [PreserveSig]
    void GetColors([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] Colors);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Values">Values</param>
    [PreserveSig]
    void GetValues([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Values);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Colors">Colors</param>
    [PreserveSig]
    void PutColors([In] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] Colors);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Values">Values</param>
    [PreserveSig]
    void PutValues([In] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Values);
}

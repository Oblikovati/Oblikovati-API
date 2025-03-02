namespace Oblikovati.API;

/// <summary>
/// The Box object is a mathematical utility object that represents a rectangular box whose faces are always parallel to the model XYZ planes. A common use of the Box object is as a means of passing the range box information of an entity and interacting with that range box.
/// </summary>
public interface Box
{
    /// <summary>
    /// Property that gets and sets the minimum corner of the box.
    /// </summary>
    Point MinPoint { get; set; }
    /// <summary>
    /// Property that gets and sets the maximum corner of the box.
    /// </summary>
    Point MaxPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MinPoint">MinPoint</param>
    /// <param name="MaxPoint">MaxPoint</param>
    [PreserveSig]
    void GetBoxData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MinPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MaxPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MinPoint">MinPoint</param>
    /// <param name="MaxPoint">MaxPoint</param>
    [PreserveSig]
    void PutBoxData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MinPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MaxPoint);
    /// <summary>
    /// Extends the Box to include the specified point.
    /// </summary>
    /// <param name="Point">Input Point object that specifies the coordinate to include in the box.</param>
    [PreserveSig]
    void Extend([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Expands the Box on all sides by the specified distance.
    /// </summary>
    /// <param name="Distance">Input Double that defines the distance by which to expand the box.</param>
    [PreserveSig]
    void Expand([In] double Distance);
    /// <summary>
    /// Determines whether the specified point is contained within this Box.
    /// </summary>
    /// <param name="Point">Input Point object that specifies the coordinate to check.</param>
    /// <returns></returns>
    [PreserveSig]
    bool Contains([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Determines whether this Box intersects the specified Box.&nbsp;A return value of True indicates that the box do not intersect.
    /// </summary>
    /// <param name="Box">Input Box object to compare.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsDisjoint([In] [MarshalAs(UnmanagedType.Interface)] Box Box);
    /// <summary>
    /// Creates a copy of this Box object.&nbsp;The result is entirely independent and can be edited without affecting the original Box object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Box Copy();
}

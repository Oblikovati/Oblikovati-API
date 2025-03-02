namespace Oblikovati.API;

/// <summary>
/// The OrientedBox object is a mathematical utility object that represents a rectangular box. Not like the Box object, the OrientedBox faces are not necessarily parallel to the model XY/XZ/YZ planes.
/// </summary>
public interface OrientedBox
{
    /// <summary>
    /// Read-write property that gets and sets the corner point for the OrientedBox object.
    /// </summary>
    Point CornerPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the vector that defines the first direction and length of the OrientedBox object. When set this value, the new vector should be parallel to the current vector, otherwise an error will occur.
    /// </summary>
    Vector DirectionOne { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the vector that defines the second direction and length of the OrientedBox object. When set this value, the new vector should be parallel to the current vector, otherwise an error will occur.
    /// </summary>
    Vector DirectionTwo { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the vector that defines the third direction and length of the OrientedBox object. When set this value, the new vector should be parallel to the current vector, otherwise an error will occur.
    /// </summary>
    Vector DirectionThree { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CornerPoint">CornerPoint</param>
    /// <param name="DirectionOne">DirectionOne</param>
    /// <param name="DirectionTwo">DirectionTwo</param>
    /// <param name="DirectionThree">DirectionThree</param>
    [PreserveSig]
    void GetOrientedBoxData([Out] [MarshalAs(UnmanagedType.Interface)] out Point CornerPoint, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector DirectionOne, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector DirectionTwo, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector DirectionThree);
    /// <summary>
    /// Method that sets the corner point and edges data that define this OrientedBox.
    /// </summary>
    /// <param name="CornerPoint">Input Point object that defines a corner point of the oriented box.</param>
    /// <param name="DirectionOne">Input Vector object that defines the first direction of the oriented box starting from the corner point.</param>
    /// <param name="DirectionTwo">Input Vector object that defines the second edge of the oriented box starting from the corner point. If this vector is not perpendicular to the DirectionOne, an error will occur.</param>
    /// <param name="DirectionThree">Input Vector object that defines the third edge of the oriented box starting from the corner point. If this vector is not perpendicular to the DirectionOne and DirectionTwo, an error will occur.</param>
    [PreserveSig]
    void PutOrientedBoxData([In] [MarshalAs(UnmanagedType.Interface)] Point CornerPoint, [In] [MarshalAs(UnmanagedType.Interface)] Vector DirectionOne, [In] [MarshalAs(UnmanagedType.Interface)] Vector DirectionTwo, [In] [MarshalAs(UnmanagedType.Interface)] Vector DirectionThree);
    /// <summary>
    /// Creates a copy of this OrientedBox object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    OrientedBox Copy();
    /// <summary>
    /// Determines whether the specified point is contained within this oriented box.
    /// </summary>
    /// <param name="Point">Input Point object that specifies the coordinate to check.</param>
    /// <returns></returns>
    [PreserveSig]
    bool Contains([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Determines whether this box does not intersect with the specified oriented box.
    /// </summary>
    /// <param name="OrientedBox">Input OrientedBox object to compare.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsDisjoint([In] [MarshalAs(UnmanagedType.Interface)] OrientedBox OrientedBox);
}

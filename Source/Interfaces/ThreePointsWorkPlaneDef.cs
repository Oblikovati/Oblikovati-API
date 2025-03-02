namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane defined by three points.
/// </summary>
public interface ThreePointsWorkPlaneDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkPlane object.
    /// </summary>
    WorkPlane Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the first point of a three point defined work plane. The first point defines the origin of the work plane. This object can be a WorkPoint, Vertex, or SketchPoint object.
    /// </summary>
    object Point1 { get; }
    /// <summary>
    /// Property that returns the second point of a three point defined work plane. The second point defines the X-axis in relation to the first point. This object can be a WorkPoint, Vertex, or SketchPoint object.
    /// </summary>
    object Point2 { get; }
    /// <summary>
    /// Property that returns the third point of a three point defined work plane. The third point defines the positive y-axis direction of the work plane. This object can be a WorkPoint, Vertex, or SketchPoint object.
    /// </summary>
    object Point3 { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point1">Point1</param>
    /// <param name="Point2">Point2</param>
    /// <param name="Point3">Point3</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point1, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point2, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point3);
}

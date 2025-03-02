namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis along a line.
/// </summary>
public interface TwoPointsWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the first point of a two point defined work axis. This object can be a WorkPoint, Vertex, or SketchPoint object. The work axis runs between the two points.
    /// </summary>
    object Point1 { get; }
    /// <summary>
    /// Property that returns the second point of a two point defined work axis. This object can be a WorkPoint, Vertex, or SketchPoint object. The work axis runs between the two points.
    /// </summary>
    object Point2 { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point1">Point1</param>
    /// <param name="Point2">Point2</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point1, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point2);
}

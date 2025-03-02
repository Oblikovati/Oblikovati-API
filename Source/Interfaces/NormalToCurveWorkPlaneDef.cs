namespace Oblikovati.API;

/// <summary>
/// The NormalToCurveWorkPlaneDef object that allows you to get and set the information that specifies a work plane defined as normal to a curve and through a point.
/// </summary>
public interface NormalToCurveWorkPlaneDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    WorkPlane Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the curve entity of a normal to curve defined work plane. This object can be an Edge, 3D Sketch entity, or 2D Sketch entity.
    /// </summary>
    object CurveEntity { get; }
    /// <summary>
    /// Property that returns the point of a normal to curve defined work plane. The point can be a WorkPoint, Vertex, SketchPoint3D or SketchPoint object. The work plane passes through the point.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CurveEntity">CurveEntity</param>
    /// <param name="Point">Point</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object CurveEntity, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point);
}

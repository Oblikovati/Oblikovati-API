namespace Oblikovati.API;

/// <summary>
/// The GeometricConstraints3D object provides access to all the geometric sketch constraints ( objects) in a 3D sketch and provides methods to create additional geometric sketch constraints.
/// </summary>
public interface GeometricConstraints3D : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified geometric sketch constraint object from the collection.
    /// </summary>
    GeometricConstraint3D Item { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Method that creates a new tangent constraint. This method will fail if the constraint overconstrains the sketch or if the two input entities do not share at least one common sketch point. In creating the constraint, the method attempts to match the existing orientation between the two curves. If the dot product of the direction vectors for the curves at the tangent point is greater than 0.0 the options for the tangent constraint is set to be outward. That means that if you look at the curves and ignore the parameterization, the curves will be going in opposite directions.
    /// </summary>
    /// <param name="EntityOne">Input sketch object.</param>
    /// <param name="EntityTwo">Input sketch or edge object.</param>
    /// <param name="ProximityPoint">Optional input object that specifies where the tangency should be applied in the case where the input entities share two sketch points.</param>
    /// <returns></returns>
    [PreserveSig]
    TangentConstraint3D AddTangent([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityPoint = default);
    /// <summary>
    /// Method that creates a new collinear constraint between the two input objects. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Object that specifies the first entity to be constrained.</param>
    /// <param name="EntityTwo">Object that specifies the second entity to be constrained.</param>
    /// <param name="Reserved1">This argument is reserved for future use and is currently ignored.</param>
    /// <param name="Reserved2">This argument is reserved for future use and is currently ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    CollinearConstraint3D AddCollinear([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] bool? Reserved1 = true, [In] bool? Reserved2 = true);
    /// <summary>
    /// Method that creates a new ground constraint on the input sketch entity. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="Entity">SketchEntity3D object that specifies the entity to ground.</param>
    /// <returns></returns>
    [PreserveSig]
    GroundConstraint3D AddGround([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity);
    /// <summary>
    /// Method that creates a new parallel constraint between the two input entities. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Object that specifies the first entity to be constrained.</param>
    /// <param name="EntityTwo">Object that specifies the second entity to be constrained.</param>
    /// <param name="Reserved1">This argument is reserved for future use and is currently ignored.</param>
    /// <param name="Reserved2">This argument is reserved for future use and is currently ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    ParallelConstraint3D AddParallel([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] bool? Reserved1 = true, [In] bool? Reserved2 = true);
    /// <summary>
    /// Method that creates a new perpendicular constraint between the two input entities. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Object that specifies the first entity to be constrained.</param>
    /// <param name="EntityTwo">Object that specifies the second entity to be constrained.</param>
    /// <param name="Reserved1">This argument is reserved for future use and is currently ignored.</param>
    /// <param name="Reserved2">This argument is reserved for future use and is currently ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    PerpendicularConstraint3D AddPerpendicular([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] bool? Reserved1 = true, [In] bool? Reserved2 = true);
    /// <summary>
    /// Method that creates a new custom constraint on the input sketch entity.
    /// </summary>
    /// <param name="Entity">SketchEntity3D object that specifies the entity to which the custom constraint needs to be applied.</param>
    /// <param name="ClientId">String that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <returns></returns>
    [PreserveSig]
    CustomConstraint3D AddCustom([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity, [In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
    /// <summary>
    /// Method that creates a new smooth (G2-continuous) constraint. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity.</param>
    /// <param name="EntityTwo">Input sketch entity.</param>
    /// <param name="ProximityPoint">Optional input Point object that specifies which ends of the curves to make smooth in case there are multiple connections.</param>
    /// <returns></returns>
    [PreserveSig]
    SmoothConstraint3D AddSmooth([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityPoint = default);
    /// <summary>
    /// Method that creates a new coincident constraint between two entities. One of the input entities must be a sketch point. The other entity can be any other type of sketch entity (but not a sketch point). Placing a coincident constraint between two points will fail. Use the ConnectTo method on the SketchPoint3D object to merge two points. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity.</param>
    /// <param name="EntityTwo">Input sketch entity.</param>
    /// <returns></returns>
    [PreserveSig]
    CoincidentConstraint3D AddCoincident([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityTwo);
    /// <summary>
    /// Method that creates a new midpoint constraint between the input point and the midpoint of the line. This causes the input sketch point to be positioned at the midpoint of the \input line. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="Point">Input SketchPoint3D object.</param>
    /// <param name="Line">Input SketchLine3D object.</param>
    /// <returns></returns>
    [PreserveSig]
    MidpointConstraint3D AddMidpoint([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint3D Point, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D Line);
    /// <summary>
    /// Creates a new parallel constraint between the input entity and X-axis.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ParallelToXAxisConstraint3D AddParallelToXAxis([In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D Line);
    /// <summary>
    /// Creates a new parallel constraint between the input entity and Y-axis.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ParallelToYAxisConstraint3D AddParallelToYAxis([In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D Line);
    /// <summary>
    /// Creates a new parallel constraint between the input entity and Z-axis.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ParallelToZAxisConstraint3D AddParallelToZAxis([In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D Line);
    /// <summary>
    /// Creates a new parallel constraint between the input entity and XY-plane.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ParallelToXYPlaneConstraint3D AddParallelToXYPlane([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity);
    /// <summary>
    /// Creates a new parallel constraint between the input entity and YZ-plane.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ParallelToYZPlaneConstraint3D AddParallelToYZPlane([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity);
    /// <summary>
    /// Creates a new parallel constraint between the input entity and XZ-plane.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ParallelToXZPlaneConstraint3D AddParallelToXZPlane([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity);
    /// <summary>
    /// Creates a new equal constraint between the input entities.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EqualConstraint3D AddEqual([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D EntityTwo);
    /// <summary>
    /// Creates a new on face constraint between the input entity and face.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    OnFaceConstraint3D AddOnFace([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity, [In] [MarshalAs(UnmanagedType.IDispatch)] object Face);
}

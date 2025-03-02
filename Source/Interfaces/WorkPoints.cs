namespace Oblikovati.API;

/// <summary>
/// Provides access to all of the <link Inventor::WorkPoint, WorkPoint> objects in the parent document and provides methods to create new work points.
/// </summary>
public interface WorkPoints : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified WorkPoint object from the collection. This is the default property of the WorkPoints collection object.
    /// </summary>
    WorkPoint Item { get; }
    /// <summary>
    /// Property returning the parent <link Inventor::ComponentDefinition, ComponentDefinition> object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new work point at the intersection of the three input planes. If the three input planes don't intersect an error will occur. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Plane1">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Plane2">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Plane3">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddByThreePlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane3, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the intersection of the two input lines. If the lines don't intersect an error will occur. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Line1">Input object that represents a line. This object can be a linear Edge, WorkAxis, or SketchLine object.</param>
    /// <param name="Line2">Input object that represents a line. This object can be a linear Edge, WorkAxis, or SketchLine object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddByTwoLines([In] [MarshalAs(UnmanagedType.IDispatch)] object Line1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Line2, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the intersection of the input curve and entity. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Curve">Input object that represents a curve. This object can be an edge or a 2d or 3d sketch entity.</param>
    /// <param name="Entity">Input object that will be intersected with the curve. This object can be a face or a work plane. There is a current limitation that this must be a planar face or work plane when anything but a line is input as the curve. Any face can be used when the curve is a line.</param>
    /// <param name="ProximityPoint">Input Point object that indicates multiple solutions to use. For example, a circle can intersect a plane twice, or a spline can intersect multiple times. If this argument is supplied, the result closest to the input point will be used. If this argument is not supplied and multiple solutions are possible, one solution will be arbitrarily chosen.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddByCurveAndEntity([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityPoint = default, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the input point. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Point">Input object that represents a point. This object can be a Vertex or SketchPoint object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddByPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the midpoint of the input edge. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Edge">Input Edge object. Any open edge is valid as input. Inputting a closed edge, (i.e. circle), will cause and error to occur.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddByMidPoint([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the position specified by the input point. When used to create a work point within an assembly the resulting work point will return an AssemblyWorkPointDef definition.
    /// </summary>
    /// <param name="Point">Input Point object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddFixed([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the center of the torus specified by the input face. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Face">Input Face object whose geometry is a torus surface. An error occurs if the geometry of the input face is not a torus surface.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddByTorusCenterPoint([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] bool? Construction = false);
    /// <summary>
    /// Creates a new work point at the center of the sphere specified by the input face. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Face">Input Face object whose geometry is a spherical surface.  An error occurs if the geometry of the input face is not a spherical surface.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not.  The default is False, which indicates to create a standard work point.  A construction work point is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddBySphereCenterPoint([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work point at the centroid of the input entities. This method is not currently supported when creating a work point within an assembly.
    /// </summary>
    /// <param name="Entities">Input object that specifies the entities. This can be an Edge, an EdgeLoop object or an EdgeCollection containing one or more edges. If an EdgeCollection is input, the collection must contain connected edges. If isolated edges appear in the collection, the method will fail.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work point as a construction point or not. The default is False, which indicates to create a standard work point. A construction work point is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPoint AddAtCentroid([In] [MarshalAs(UnmanagedType.IDispatch)] object Entities, [In] bool? Construction = false);
}

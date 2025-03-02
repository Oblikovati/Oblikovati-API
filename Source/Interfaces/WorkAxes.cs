namespace Oblikovati.API;

/// <summary>
/// The WorkAxes collection object provides access to all of the <link Inventor::WorkAxis, WorkAxis> objects in the parent document and provides methods to create new work axes.
/// </summary>
public interface WorkAxes : IEnumerable
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
    /// Returns the specified WorkAxis object from the collection. This is the default property of the WorkAxes collection object.
    /// </summary>
    WorkAxis Item { get; }
    /// <summary>
    /// Property returning the parent <link Inventor::ComponentDefinition, ComponentDefinition> object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new work axis based on the input line. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, SketchLine, or SketchLine3D object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction: * Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well. * If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByLine([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis at the intersection of the two input planes. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Plane1">First input plane object for which to find the intersection at which to create the work axis. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Plane2">Second input plane object for which to find the intersection at which to create the work axis. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis, not a construction work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction: * Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well. * If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByTwoPlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis through the two input points. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Point1">Input object that represents a point. This object can be a WorkPoint, Vertex, or SketchPoint object.</param>
    /// <param name="Point2">Input object that represents a point. This object can be a WorkPoint, Vertex, or SketchPoint object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis, not a construction work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction: * Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well. * If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByTwoPoints([In] [MarshalAs(UnmanagedType.IDispatch)] object Point1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point2, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis through the axis of a revolved face. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Face">Input Face object whose geometry is a revolved surface. Valid surface types include cylinders, cones, and toroids.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByRevolvedFace([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] bool? Construction = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    /// <param name="Plane">Plane</param>
    /// <param name="Construction">Construction</param>
    [PreserveSig]
    WorkAxis AddByPointAndPlane([In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis that is along a line defined by projecting the input line onto the input plane along the plane normal. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Line">Input line object to project along the plane. This object can be a linear Edge, WorkAxis, or SketchLine object.</param>
    /// <param name="Plane">Input plane object along which to project the line. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis, not a construction work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction: * Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well. * If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByLineAndPlane([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis that passes through the input point in the direction of the input vector. When used to create a work axis within an assembly the resulting work axis will return an AssemblyWorkAxisDef definition.
    /// </summary>
    /// <param name="Point">Input <link Inventor::Point, Point> object.</param>
    /// <param name="Axis">Input UnitVector object. that defines the X-axis vector of the work plane.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddFixed([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Axis, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis based on the input analytic edge. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Edge">Input Edge object that can be a circle, arc, or an ellipse.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByAnalyticEdge([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis that is parallel to a line and passes through the input point. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Point">Input object that represents a point. This object can be a Vertex, WorkPoint, SketchPoint, or SketchPoint3D object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False, which indicates to create a standard work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByLineAndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work axis that passes through the point and is normal to the input surface. This method is not currently supported when creating a work axis within an assembly.
    /// </summary>
    /// <param name="Surface">Input object that represents a surface entity. This object can be a Face (planar or non-planar), a WorkPlane or a PlanarSketch object.</param>
    /// <param name="Point">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work axis as a construction axis or not. The default is False which indicates to create a standard work axis, not a construction work axis. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkAxis AddByNormalToSurface([In] [MarshalAs(UnmanagedType.IDispatch)] object Surface, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] bool? Construction = false);
}

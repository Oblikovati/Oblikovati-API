namespace Oblikovati.API;

/// <summary>
/// The WorkPlanes collection object provides access to all of the <link Inventor::WorkPlane, WorkPlane> objects in the parent document and provides methods to create new work planes.
/// </summary>
public interface WorkPlanes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified WorkPlane object from the collection. This is the default property of the WorkPlanes collection object.
    /// </summary>
    WorkPlane Item { get; }
    /// <summary>
    /// Property returning the parent <link Inventor::ComponentDefinition, ComponentDefinition> object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new work plane based on the three input points. The three input points must be unique non-coincident points. Point1 to Point2 defines the positive X axis and Point3 defines the positive Y direction. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Point1">Input object that represents a point. This object can be a WorkPoint, Vertex, or SketchPoint object.</param>
    /// <param name="Point2">Input object that represents a point. This object can be a WorkPoint, Vertex, or SketchPoint object.</param>
    /// <param name="Point3">Input object that represents a point. This object can be a WorkPoint, Vertex, or SketchPoint object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByThreePoints([In] [MarshalAs(UnmanagedType.IDispatch)] object Point1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point2, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point3, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane based on the two input lines. Line1 defines the X axis. If the two lines are not in the same plane, the plane is calculated by crossing the vectors defined by Line1 and Line2. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Line1">Input object that represents a line. This object can be a linear Edge, WorkAxis, or SketchLine object.</param>
    /// <param name="Line2">Input object that represents a line. This object can be a linear Edge, WorkAxis, or SketchLine object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction: *
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByTwoLines([In] [MarshalAs(UnmanagedType.IDispatch)] object Line1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Line2, [In] bool? Construction = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Line">Line</param>
    /// <param name="Point">Point</param>
    /// <param name="Construction">Construction</param>
    [PreserveSig]
    WorkPlane AddByLineAndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane that is parallel to the input plane and passes through the input point. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Plane">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Point">Input object that represents a point. This object can be a WorkPoint, Vertex or SketchPoint object.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByPlaneAndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane through the input line at the specified angle from the input plane. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, or SketchLine object.</param>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Angle">Input Variant that defines the offset angle of the work plane from the input plane. This can be a numeric value or a string. The offset angle of a work plane is always defined by a parameter. When a new work plane is created that requires a parameter, that parameter is automatically created when the work plane is created. If a numeric value is supplied the new parameter is set to the value specified. The input value is in radians. If a string is supplied it is used as the expression for the newly created parameter and will be interpreted the same as if the user entered it in a dialog. This means if a value is specified without a unit qualifier it will default to the current document length unit. The following is a valid entry for the angle, assuming the parameter d2 already exists and defines an angle, "d2 + 10 deg." The positive angle direction is computed by crossing the axis vector with the plane normal vector.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByLinePlaneAndAngle([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane that is parallel to the input plane at a specified distance in the specified direction. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Offset">Input Variant that defines the offset distance of the Plane. This can be a numeric value or a string. The offset distance of a work plane is always defined by a parameter. When a new work plane is created that requires a parameter, that parameter is automatically created when the work plane is created. If a numeric value is supplied the new parameter is set to the value specified. The input value is in centimeters. If a string is supplied this will be used as the expression for the newly created parameter and will be interpreted the same as if the user entered it in a dialog. This means if a value is specified without a unit qualifier it will default to the current document length unit. The following is a valid entry for the offset, assuming the parameter d2 already exists and defines a length, "d2 + 3 in." The sign of the value controls which side of the plane the offset is in. A positive value will be in the positive normal side of the plane.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByPlaneAndOffset([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane through the input point and tangent to the input surface. The input point must lie on the input surface. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Point">Input object that represents a point. This object can be a Vertex, WorkPoint, SketchPoint3D, or SketchPoint object.</param>
    /// <param name="Face">Input Face object that indicates the tangent surface. This face must either be a cylinder, a cone that is positioned such that a valid tangent exists, a sphere, or a bspline surface.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByPointAndTangent([In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane through the input line and tangent to the input surface.&nbsp;This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Face">Input Face object that indicates the tangent surface. This face must either be a cylinder whose axis is parallel to the line, a cone that is positioned such that a valid tangent exists, or a sphere.</param>
    /// <param name="ProximityPoint">Input Point object that indicates which of the possible two solutions to use. For cylinders and spheres the plane can be on either side of the surface. Which solution to use will be determined by which side the proximity point is closest to. This point is only used for the initial computation. During a recompute of the model the plane will remain on the same side of the tangent surface regardless of its position relative to the originally specified point.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByLineAndTangent([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] Point ProximityPoint, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane that is parallel to the input plane and tangent to the input surface. Valid geometry for the face includes cylinders, cones, and spheres. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Face">Input Face object that indicates the tangent surface. This face must either be a cylinder whose axis is parallel to the plane, a cone that is positioned such that a valid tangent exists, or a sphere.</param>
    /// <param name="ProximityPoint">Input Point object that indicates which of the possible two solutions to use. For cylinders and spheres the plane can be on either side of the surface. Which solution to use will be determined by which side the proximity point is closest to. This point is only used for the initial computation. During a recompute the plane will remain on the same side of the tangent surface regardless of its position relative to the originally specified point.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByPlaneAndTangent([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] Point ProximityPoint, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane that passes through the point and is normal to the input curve. The point must lie on the curve, as described below. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="CurveEntity">Input object that represents a curve entity. This object can be an Edge, 3D sketch entity, or a 2D sketch entity. For an Edge or 3D sketch entity the geometry must be a Spline, Arc, Circle, EllipticalArc, or Ellipse. For a 2D sketch entity, the geometry must be a Spline2d, Arc2d, Circle2d, EllipticalArc2d, or Ellipse2d.</param>
    /// <param name="Point">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object. If the input curve is a 2D sketch entity, the point must be a SketchPoint that meets one of the following conditions: start or end point of the curve, one of the fit points of a spline, or constrained to the curve with a coincident constraint. If the input curve is a 3D curve, the point must be related to the curve. For a 3D point to be related to a 3D curve, it can be the start, mid, or end point of the curve.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByNormalToCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object CurveEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] bool? Construction = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane1">Plane1</param>
    /// <param name="Plane2">Plane2</param>
    /// <param name="Construction">Construction</param>
    [PreserveSig]
    WorkPlane _AddByTwoPlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2, [In] bool? Construction = false);
    /// <summary>
    /// Creates a new work plane that bisects the two input planes. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Plane1">Input object that represents a plane.  This object can be a planar Face, WorkPlane or PlanarSketch object.</param>
    /// <param name="Plane2">Input object that represents a plane.  This object can be a planar Face, WorkPlane or PlanarSketch object.</param>
    /// <param name="QuadrantPoint">Optional input Point to indicate which quadrant the new work plane should be created in. If the two input planes are parallel this argument will be ignored, while the two input planes are intersected then this argument is required to determine which quadrant the new work plane will be created in.</param>
    /// <param name="Construction">Optional input Boolean that specifies whether to create the work plane as a construction plane or not.  The default is False, which indicates to create a standard work plane, not a construction work plane.  A construction work plane is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByTwoPlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2, [In] [MarshalAs(UnmanagedType.Struct)] object? QuadrantPoint = default, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane at the position and orientation defined by the point and X and Y axis vectors. When used to create a work plane within an assembly the resulting work plane will return an AssemblyWorkPlaneDef definition.
    /// </summary>
    /// <param name="OriginPoint">Input Point object that defines the origin of the work plane.</param>
    /// <param name="XAxis">Input UnitVector object that defines the X-axis vector of the work plane.</param>
    /// <param name="YAxis">Input UnitVector object that defines the Y-axis vector of the work plane.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. If work features are created as construction:
    /// Deleting any downstream feature that consumes this construction work feature will have the effect of deleting this work feature as well.
    /// If there are no consumers of the construction work feature, it is the responsibility of the creator to delete them since they will never get cleaned up and are not visible to users.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddFixed([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector XAxis, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector YAxis, [In] bool? Construction = false);
    /// <summary>
    /// Method that creates a new work plane at the mid-plane of the torus specified by the input face. This method is not currently supported when creating a work plane within an assembly.
    /// </summary>
    /// <param name="Face">Input Face object that represents a torus surface.</param>
    /// <param name="Construction">Optional Input Boolean that specifies whether to create the work plane as a construction plane or not. The default is False, which indicates to create a standard work plane, not a construction work plane. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    WorkPlane AddByTorusMidPlane([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] bool? Construction = false);
}

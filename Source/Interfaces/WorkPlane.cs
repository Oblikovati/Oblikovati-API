namespace Oblikovati.API;

/// <summary>
/// Represents a work plane. See here for an overview.
/// </summary>
public interface WorkPlane
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent <link Inventor::ComponentDefinition, ComponentDefinition> object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Specifies whether the work plane is adaptive.
    /// </summary>
    bool Adaptive { get; set; }
    /// <summary>
    /// Boolean property that returns whether the work plane is a construction work plane or not. A construction work plane is hidden from the user and is not displayed graphically or listed in the browser. Some properties and methods of the WorkPlane object will behave differently for a construction work plane. These are Adaptive, Name, Visible, GetSize, and SetSize.
    /// </summary>
    bool Construction { get; }
    /// <summary>
    /// Property that returns one of the work plane definition objects. Which definition object returned will depend on how the work plane is defined. The DefinitionType property can be used to determine the type of definition the Definition property will return.
    /// </summary>
    object Definition { get; }
    /// <summary>
    /// Property that returns the type of definition that is used to define the work plane. This can be kThreePointsWorkPlane, kTwoLinesWorkPlane, kLineAndPointWorkPlane, kPlaneAndPointWorkPlane, kLinePlaneAndAngleWorkPlane, kPlaneAndOffsetWorkPlane, kLineAndTangentWorkPlane, kPlaneAndTangentWorkPlane, kSketchWorkPlane, kFixedWorkPlane, kNormalToCurveWorkPlane, kTwoPlanesWorkPlane, kTorusMidPlaneWorkPlane, or AssemblyWorkPlane.
    /// </summary>
    WorkPlaneDefinitionEnum DefinitionType { get; }
    /// <summary>
    /// Property that returns the collection of objects that have a direct dependency on the work plane.
    /// </summary>
    ObjectCollection Dependents { get; }
    /// <summary>
    /// Property that returns the collection of objects that the work plane is dependent on.
    /// </summary>
    ObjectCollection DrivenBy { get; }
    /// <summary>
    /// Gets/Sets the Boolean flag that specifies whether this work plane is grounded or not.
    /// </summary>
    bool Grounded { get; set; }
    /// <summary>
    /// Specifies the name of the work plane.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns a Plane's geometry. The Plane object returned provides information about the position and normal of the work plane.
    /// </summary>
    Plane Plane { get; }
    /// <summary>
    /// Specifies the visibility of the work plane.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns the referenced WorkPlane in the case where this work plane was created using a referenced component. An example of this is when a work plane is selected as part of a derived part. The HasReferenceComponent property indicates if this work plane is based on a referenced component or not. This property returns Nothing in the case where it is not based on a referenced component.
    /// </summary>
    WorkPlane ReferencedEntity { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Property that gets whether the work plane was created by a pattern. If so, edits and delete are not allowed.
    /// </summary>
    bool IsPatternElement { get; }
    /// <summary>
    /// Gets and sets whether the work plane is shared or not.
    /// </summary>
    bool Shared { get; set; }
    /// <summary>
    /// Gets whether the WorkPlane is consumed or not.
    /// </summary>
    bool Consumed { get; }
    /// <summary>
    /// Gets and sets whether the inputs to this feature should be nested under this feature in the browser.
    /// </summary>
    bool ConsumeInputs { get; set; }
    /// <summary>
    /// Property that indicates whether the work plane belongs to a 3d sketch.
    /// </summary>
    bool IsParentSketch { get; }
    /// <summary>
    /// Gets the parent 3d sketch if this work plane belongs to a 3d sketch, Gets Nothing otherwise.
    /// </summary>
    Sketch3D ParentSketch { get; }
    /// <summary>
    /// Gets and sets whether this work plane should be resized automatically based on the component size.
    /// </summary>
    bool AutoResize { get; set; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature. If True, the OwnedBy property returns the owning feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Read-only property that returns the client feature that owns this object.&nbsp;This property returns Nothing if the IsOwnedByFeature property returns False.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Property that returns whether the work plane belongs to a coordinate system. If so, edits and delete are not allowed.
    /// </summary>
    bool IsCoordinateSystemElement { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Method that deletes the work plane. Optionally the dependent objects will be deleted. This method will fail in the case where this object was created as a result of a derived part. The HasReferenceComponent property can be used to determine when this is the case.
    /// </summary>
    /// <param name="RetainDependents">Optional input Boolean that specifies whether any dependent objects should also be deleted. If True, no dependent objects will be deleted. This argument is ignored in the case of an assembly work plane.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependents = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point1">Point1</param>
    /// <param name="Point2">Point2</param>
    [PreserveSig]
    void GetSize([Out] [MarshalAs(UnmanagedType.Interface)] out Point Point1, [Out] [MarshalAs(UnmanagedType.Interface)] out Point Point2);
    /// <summary>
    /// Method that sets the current size of the displayed graphics for the work plane.
    /// </summary>
    /// <param name="Point1">Input object that defines the first corner of the work plane.</param>
    /// <param name="Point2">Input <link Inventor::Point, Point> object that defines the diagonal corner of the work plane.</param>
    [PreserveSig]
    void SetSize([In] [MarshalAs(UnmanagedType.Interface)] Point Point1, [In] [MarshalAs(UnmanagedType.Interface)] Point Point2);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Origin">Origin</param>
    /// <param name="XAxis">XAxis</param>
    /// <param name="YAxis">YAxis</param>
    [PreserveSig]
    void GetPosition([Out] [MarshalAs(UnmanagedType.Interface)] out Point Origin, [Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector XAxis, [Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector YAxis);
    /// <summary>
    /// Method that redefines the work plane to be based on the three input points.
    /// </summary>
    /// <param name="Point1">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    /// <param name="Point2">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    /// <param name="Point3">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    [PreserveSig]
    void SetByThreePoints([In] [MarshalAs(UnmanagedType.IDispatch)] object Point1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point2, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point3);
    /// <summary>
    /// Method that redefines the work plane to be based on the two input lines.
    /// </summary>
    /// <param name="Line1">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Line2">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    [PreserveSig]
    void SetByTwoLines([In] [MarshalAs(UnmanagedType.IDispatch)] object Line1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Line2);
    /// <summary>
    /// Method that redefines the work plane to be parallel to the input plane and passing through the input point.
    /// </summary>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Point">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    [PreserveSig]
    void SetByPlaneAndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point);
    /// <summary>
    /// Method that redefines the work plane to be through the input line at the specified angle from the input plane.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Angle">Input Variant that defines the offset angle of the work plane from the input plane. This can be a numeric value or a string. The offset angle of a work plane is always defined by a parameter. When a new work plane is created, the parameter is automatically created. If a numeric value is supplied the new parameter is set to the value specified and the value is always in radians. If a string is supplied it is used as the expression for the newly created parameter and will be interpreted the same as if the user entered it in a dialog. This means if a value is specified without a unit qualifier it will default to the current document length unit. The following is a valid entry for the angle, assuming the parameter d2 already exists and defines an angle, 'd2 + 10 deg'. The positive angle direction is computed by crossing the axis vector with the plane normal vector.</param>
    [PreserveSig]
    void SetByLinePlaneAndAngle([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Struct)] object Angle);
    /// <summary>
    /// Method that redefines the work plane to be parallel to the input plane at a specified distance in the specified direction.
    /// </summary>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object..</param>
    /// <param name="Offset">Input Variant that defines the offset distance of the Plane. This can be a numeric value or a string. The offset distance of a work plane is always defined by a parameter. When a new work plane is created that requires a parameter, that parameter is automatically created when the work plane is created. If a numeric value is supplied the new parameter is set to the value specified. The input value is in centimeters. If a string is supplied this will be used as the expression for the newly created parameter and will be interpreted the same as if the user entered it in a dialog. This means if a value is specified without a unit qualifier it will default to the current document length unit. The following is a valid entry for the offset, assuming the parameter d2 already exists and defines a length, 'd2 + 3 in'. The sign of the value controls which side of the plane the offset is in. A positive value will be in the positive normal side of the plane.</param>
    [PreserveSig]
    void SetByPlaneAndOffset([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Struct)] object Offset);
    /// <summary>
    /// Method that redefines the work plane to pass through the input point and normal to the input curve.
    /// </summary>
    /// <param name="CurveEntity">Input object that represents a curve entity. This object can be an Edge, 3D sketch entity, 2D sketch entity or a WorkAxis. For an Edge or 3D sketch entity the geometry must be a Spline, Arc, Circle, EllipticalArc, or Ellipse. For a 2D sketch entity, the geometry must be a Spline2d, Arc2d, Circle2d, EllipticalArc2d, or Ellipse2d.</param>
    /// <param name="Point">Input object that represents a point, The point must lie on the curve, as described below. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object. If the input curve is a 2D sketch entity, the point must be a SketchPoint that meets one of the following conditions: start or end point of the curve, one of the fit points of a spline, or constrained to the curve with a coincident constraint. If the input curve is a 3D curve, the point must be related to the curve. For a 3D point to be related to a 3D curve, it can be the start, mid, or end point of the curve.</param>
    [PreserveSig]
    void SetByNormalToCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object CurveEntity, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane1">Plane1</param>
    /// <param name="Plane2">Plane2</param>
    [PreserveSig]
    void _SetByTwoPlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2);
    /// <summary>
    /// Method that redefines a bisection work plane to be based on the two planes.
    /// </summary>
    /// <param name="Plane1">Input object that represents a plane.  This object can be a planar Face, WorkPlane or PlanarSketch object.</param>
    /// <param name="Plane2">Input object that represents a plane.  This object can be a planar Face, WorkPlane or PlanarSketch object.</param>
    /// <param name="QuadrantPoint">Optional input Point to indicate which quadrant the new work plane should be created in. If the two input planes are parallel this argument will be ignored, while the two input planes are intersected then this argument is required to determine which quadrant the new work plane will be created in.</param>
    [PreserveSig]
    void SetByTwoPlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2, [In] [MarshalAs(UnmanagedType.Struct)] object? QuadrantPoint = default);
    /// <summary>
    /// Method that redefines the work plane to be through the input line and tangent to the input surface.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Face">Input Face object that indicates the tangent surface. Valid geometry for the face includes cylinders, cones, and spheres. This face must either be a cylinder whose axis is parallel to the line, a cone that is positioned such that a valid tangent exists, or a sphere.</param>
    /// <param name="ProximityPoint">Input Point object that indicates which of the possible two solutions to use. For cylinders and spheres the plane can be on either side of the surface. Which solution to use will be determined by which side the proximity point is closest to. This point is only used for the initial computation. During a recompute of the model the plane will remain on the same side of the tangent surface regardless of its position relative to the originally specified point.</param>
    [PreserveSig]
    void SetByLineAndTangent([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] Point ProximityPoint);
    /// <summary>
    /// Method that redefines the work plane to be parallel to the input plane and tangent to the input surface.
    /// </summary>
    /// <param name="Plane">Input object that represents a Plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Face">Input Face object that indicates the tangent surface. This face must either be a cylinder whose axis is parallel to the line, a cone that is positioned such that a valid tangent exists, or a sphere.</param>
    /// <param name="ProximityPoint">Input Point object that indicates which of the possible two solutions to use. Valid geometry for the face includes cylinders, cones, and spheres. For cylinders and spheres the plane can be on either side of the surface. Which solution to use will be determined by which side the proximity point is closest to. This point is only used for the initial computation. During a recompute the plane will remain on the same side of the tangent surface regardless of its position relative to the originally specified point.</param>
    [PreserveSig]
    void SetByPlaneAndTangent([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] Point ProximityPoint);
    /// <summary>
    /// Method that redefines the work plane to pass through the input point and tangent to the input surface.
    /// </summary>
    /// <param name="Point">Input object that represents a point. This object can be a Vertex, WorkPoint, SketchPoint3D or SketchPoint object. The input point must lie on the input surface.</param>
    /// <param name="Face">Input Face object that indicates the tangent surface. This face must either be a cylinder, a cone that is positioned such that a valid tangent exists, a sphere or a bspline surface.</param>
    [PreserveSig]
    void SetByPointAndTangent([In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Method that redefines the work plane to be at the mid-plane of the torus specified by the input face.
    /// </summary>
    /// <param name="Face">Input Face object that represents a torus surface.</param>
    [PreserveSig]
    void SetByTorusMidPlane([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Method that redefines the work plane at the position and orientation defined by the point and X and Y axis vectors.
    /// </summary>
    /// <param name="OriginPoint">Input Point object that defines the origin of the work plane.</param>
    /// <param name="XAxis">Input UnitVector object that defines the X-axis vector of the work plane.</param>
    /// <param name="YAxis">Input UnitVector object that defines the Y-axis vector of the work plane.</param>
    [PreserveSig]
    void SetFixed([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector XAxis, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector YAxis);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that repositions the end-of-part marker relative to the object this method is called from. The argument defines if the end-of-part marker will be positioned just before or just after the object. If the object is contained within another object and is not in the top level of the browser, the positioning of the marker will be relative to the top-level object the calling object is contained within. An example of this case is a sketch that has not been shared and has been consumed by a feature. Another example is a nested work feature.
    /// </summary>
    /// <param name="Before">Input Boolean that indicates if the end of part marker should be immediately before or after this work feature. A value of True indicates before and False indicates after.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Method that reverses the normal of the work plane. The current normal direction can be determined by using the Plane object returned by Plane property of the work plane.
    /// </summary>
    [PreserveSig]
    void FlipNormal();
}

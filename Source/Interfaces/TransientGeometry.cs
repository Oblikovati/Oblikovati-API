namespace Oblikovati.API;

/// <summary>
/// Object through which all transient geometry objects are constructed. For more information, see the Transient Geometry overview.
/// </summary>
public interface TransientGeometry
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the internal tolerance used to compare whether two points are equal. For example, this is the default tolerance value used in the IsEqualTo method on the Point object.
    /// </summary>
    double PointTolerance { get; }
    /// <summary>
    /// Method that creates a new Arc2d object. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Center">Input Point2d object that specifies the center of the arc. Length units are always centimeters.</param>
    /// <param name="Radius">Input Double that specifies the radius of the arc.</param>
    /// <param name="StartAngle">Input Double that specifies the start angle of the arc. An angle of 0 is along the positive X axis of the sketch plane.</param>
    /// <param name="SweepAngle">Input Double that specifies the sweep angle of the arc. The sweep direction is always counterclockwise.</param>
    /// <returns></returns>
    [PreserveSig]
    Arc2d CreateArc2d([In] [MarshalAs(UnmanagedType.Interface)] Point2d Center, [In] double Radius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Method that creates a new Arc2d object by three points. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="PointOne">First of three points.</param>
    /// <param name="PointTwo">Second of three points.</param>
    /// <param name="PointThree">Third of three points.</param>
    /// <returns></returns>
    [PreserveSig]
    Arc2d CreateArc2dByThreePoints([In] [MarshalAs(UnmanagedType.Interface)] Point2d PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointThree);
    /// <summary>
    /// Method that creates a new Arc3d object. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Center">Input Point object that defines the center of the arc.</param>
    /// <param name="Normal">Input UnitVector that specifies the axis of the arc. The direction of this vector will also determine the direction of the start and sweep angles. Their direction is defined using the right\-hand rule relative to this vector.</param>
    /// <param name="ReferenceVector">Input UnitVector that specifies the zero angle direction the start angle is relative to. Any vector is valid except one that is parallel to the axis vector.</param>
    /// <param name="Radius">Input Double that specifies the radius of the arc.</param>
    /// <param name="StartAngle">Input Double that specifies the start angle of the arc. An angle of 0 is along the direction specified by the reference vector. The direction of the angle is defined using the right\-hand rule around the axis vector.</param>
    /// <param name="SweepAngle">Input Double that specifies the sweep angle of the arc. The sweep direction is defined using the right\-hand rule around the axis vector.</param>
    /// <returns></returns>
    [PreserveSig]
    Arc3d CreateArc3d([In] [MarshalAs(UnmanagedType.Interface)] Point Center, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector ReferenceVector, [In] double Radius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Method that creates a new Arc2d object by three points. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="PointOne">First of three points.</param>
    /// <param name="PointTwo">Second of three points.</param>
    /// <param name="PointThree">Third of three points.</param>
    /// <returns></returns>
    [PreserveSig]
    Arc3d CreateArc3dByThreePoints([In] [MarshalAs(UnmanagedType.Interface)] Point PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point PointThree);
    /// <summary>
    /// Method that creates a new EllipseFull object. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Center">Input Point object that specifies the center of the ellipse.</param>
    /// <param name="Normal">Input UnitVector object that specifies the axis of the ellipse. The axis extends out of the ellipse.</param>
    /// <param name="MajorAxisVector">Input Vector object that specifies the direction of the major axis of the ellipse.</param>
    /// <param name="MinorMajorRatio">Input Double that specifies the ratio of the minor and major axes of the ellipse.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipseFull CreateEllipseFull([In] [MarshalAs(UnmanagedType.Interface)] Point Center, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal, [In] [MarshalAs(UnmanagedType.Interface)] Vector MajorAxisVector, [In] double MinorMajorRatio);
    /// <summary>
    /// Method that creates a new EllipticalArc object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Center">Input Point object that specifies the center of the elliptical arc.</param>
    /// <param name="MajorAxis">Input UnitVector object that specifies the direction of the major axis of the elliptical arc.</param>
    /// <param name="MinorAxis">Input UnitVector object that specifies the direction of the minor axis of the elliptical arc.</param>
    /// <param name="MajorRadius">Input Double that specifies the major radius of the elliptical arc.</param>
    /// <param name="MinorRadius">Input Double that specifies the minor radius of the elliptical arc.</param>
    /// <param name="StartAngle">Input Double that specifies start angle of the elliptical arc. The start angle is measured from the major axis vector using the right\-hand rule about the axis vector.</param>
    /// <param name="SweepAngle">Input Double that specifies the sweep angle from the start angle in a direction defined using the right\-hand rule about the axis vector.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipticalArc CreateEllipticalArc([In] [MarshalAs(UnmanagedType.Interface)] Point Center, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector MajorAxis, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector MinorAxis, [In] double MajorRadius, [In] double MinorRadius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Method that creates a new EllipticalArc2d object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Center">Input Point2d object that specifies the center of the elliptical arc.</param>
    /// <param name="MajorAxis">Input UnitVector2d object that specifies the direction of the major axis of the elliptical arc.</param>
    /// <param name="MajorRadius">Input Double that specifies the major radius of the elliptical arc.</param>
    /// <param name="MinorRadius">Input Double that specifies the minor radius of the elliptical arc.</param>
    /// <param name="StartAngle">Input Double that specifies start angle of the elliptical arc. The start angle is measured from the major axis vector.</param>
    /// <param name="SweepAngle">Input Double that specifies the sweep angle from the start angle in a counterclockwise direction.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipticalArc2d CreateEllipticalArc2d([In] [MarshalAs(UnmanagedType.Interface)] Point2d Center, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d MajorAxis, [In] double MajorRadius, [In] double MinorRadius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Method that creates a new EllipseFull2d object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Center">Input Point2d object that specifies the center of the ellipse.</param>
    /// <param name="MajorAxisVector">Input Vector2d object that specifies the direction of the major axis of the ellipse.</param>
    /// <param name="MinorMajorRatio">Input Double that specifies the ratio of the minor and major axes of the ellipse.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipseFull2d CreateEllipseFull2d([In] [MarshalAs(UnmanagedType.Interface)] Point2d Center, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d MajorAxisVector, [In] double MinorMajorRatio);
    /// <summary>
    /// Method that creates a new LineSegment object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="StartPoint">Input Point object that specifies the start point of the line.</param>
    /// <param name="EndPoint">Input Point object that specifies the end point of the line.</param>
    /// <returns></returns>
    [PreserveSig]
    LineSegment CreateLineSegment([In] [MarshalAs(UnmanagedType.Interface)] Point StartPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point EndPoint);
    /// <summary>
    /// Method that creates a new LineSegment2d object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="StartPoint">Input Point2d object that specifies the start point of the line.</param>
    /// <param name="EndPoint">Input Point2d object that specifies the end point of the line.</param>
    /// <returns></returns>
    [PreserveSig]
    LineSegment2d CreateLineSegment2d([In] [MarshalAs(UnmanagedType.Interface)] Point2d StartPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point2d EndPoint);
    /// <summary>
    /// Method that creates a new 4x4 Matrix object. The matrix is initialized with an identity matrix.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Matrix CreateMatrix();
    /// <summary>
    /// Method that creates a new 3x3 Matrix object. The matrix is initialized with an identity matrix.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Matrix2d CreateMatrix2d();
    /// <summary>
    /// Method that creates a new Box object. The min and max points of the box are initialized to (0,0,0) . The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Box CreateBox();
    /// <summary>
    /// Method that creates a new Box2d object. The min and max points of the box are initialized to (0,0) . The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Box2d CreateBox2d();
    /// <summary>
    /// Method that creates a new Point object.
    /// </summary>
    /// <param name="XCoord">Input Double that specifies the point's X-coordinate.</param>
    /// <param name="YCoord">Input Double that specifies the Point's Y-coordinate.</param>
    /// <param name="ZCoord">Input Double that specifies the point's Z-coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    Point CreatePoint([In] double? XCoord = default, [In] double? YCoord = default, [In] double? ZCoord = default);
    /// <summary>
    /// Method that creates a new Point2d object.
    /// </summary>
    /// <param name="XCoord">Input Double that specifies the point's X-coordinate.</param>
    /// <param name="YCoord">Input Double that specifies the Point's Y-coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d CreatePoint2d([In] double? XCoord = default, [In] double? YCoord = default);
    /// <summary>
    /// Method that creates a new Vector object.
    /// </summary>
    /// <param name="XCoord">Input Double that specifies the Vector's X-coordinate.</param>
    /// <param name="YCoord">Input Double that specifies the Vector's Y-coordinate.</param>
    /// <param name="ZCoord">Input Double that specifies the Vector's Z-coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    Vector CreateVector([In] double? XCoord = default, [In] double? YCoord = default, [In] double? ZCoord = default);
    /// <summary>
    /// Method that creates a new Vector2d object.
    /// </summary>
    /// <param name="XCoord">Input Double that specifies the Vector's X-coordinate.</param>
    /// <param name="YCoord">Input Double that specifies the Vector's Y-coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    Vector2d CreateVector2d([In] double? XCoord = default, [In] double? YCoord = default);
    /// <summary>
    /// Method that creates a new UnitVector object.
    /// </summary>
    /// <param name="XCoord">Input Double that specifies the UnitVector's X-coordinate.</param>
    /// <param name="YCoord">Input Double that specifies the UnitVector's Y-coordinate.</param>
    /// <param name="ZCoord">Input Double that specifies the UnitVector's Z-coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    UnitVector CreateUnitVector([In] double? XCoord = default, [In] double? YCoord = default, [In] double? ZCoord = default);
    /// <summary>
    /// Method that creates a new UnitVector2d object.
    /// </summary>
    /// <param name="XCoord">Input Double that specifies the UnitVector's X-coordinate.</param>
    /// <param name="YCoord">Input Double that specifies the UnitVector's Y-coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    UnitVector2d CreateUnitVector2d([In] double? XCoord = default, [In] double? YCoord = default);
    /// <summary>
    /// Method that creates a new Line object. A Line object is infinite. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="RootPoint">Input Point object that specifies the root point of the line.</param>
    /// <param name="Direction">Input Vector object that specifies the direction of the line.</param>
    /// <returns></returns>
    [PreserveSig]
    Line CreateLine([In] [MarshalAs(UnmanagedType.Interface)] Point RootPoint, [In] [MarshalAs(UnmanagedType.Interface)] Vector Direction);
    /// <summary>
    /// Method that creates a new Line2d object. A Line2d object is infinite. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="RootPoint">Input Point2d object that specifies the root point of the line.</param>
    /// <param name="Direction">Input UnitVector2d object that specifies the direction of the line.</param>
    /// <returns></returns>
    [PreserveSig]
    Line2d CreateLine2d([In] [MarshalAs(UnmanagedType.Interface)] Point2d RootPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d Direction);
    /// <summary>
    /// Method that creates a new 3d Circle object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Center">Input Point object that specifies the center of the arc.</param>
    /// <param name="Normal">Input UnitVector that specifies the axis of the circle.</param>
    /// <param name="Radius">Input Double that specifies the radius of the circle.</param>
    /// <returns></returns>
    [PreserveSig]
    Circle CreateCircle([In] [MarshalAs(UnmanagedType.Interface)] Point Center, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal, [In] double Radius);
    /// <summary>
    /// Method that creates a new Circle object by three points. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="PointOne">First of three points.</param>
    /// <param name="PointTwo">Second of three points.</param>
    /// <param name="PointThree">Third of three points.</param>
    /// <returns></returns>
    [PreserveSig]
    Circle CreateCircleByThreePoints([In] [MarshalAs(UnmanagedType.Interface)] Point PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point PointThree);
    /// <summary>
    /// Method that creates a new Circle2d object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Center">Input Point2d object that specifies the center of the circle.</param>
    /// <param name="Radius">Input Double that specifies the radius of the circle.</param>
    /// <returns></returns>
    [PreserveSig]
    Circle2d CreateCircle2d([In] [MarshalAs(UnmanagedType.Interface)] Point2d Center, [In] double Radius);
    /// <summary>
    /// Method that creates a new Circle2D object by three points. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="PointOne">First of three points.</param>
    /// <param name="PointTwo">Second of three points.</param>
    /// <param name="PointThree">Third of three points.</param>
    /// <returns></returns>
    [PreserveSig]
    Circle2d CreateCircle2dByThreePoints([In] [MarshalAs(UnmanagedType.Interface)] Point2d PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointThree);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Order">Order</param>
    /// <param name="Poles">Poles</param>
    /// <param name="Knots">Knots</param>
    /// <param name="Weights">Weights</param>
    /// <param name="IsPeriodic">IsPeriodic</param>
    [PreserveSig]
    BSplineCurve CreateBSplineCurve([In] int Order, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Poles, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Knots, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Weights, [In] bool IsPeriodic);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Order">Order</param>
    /// <param name="Poles">Poles</param>
    /// <param name="Knots">Knots</param>
    /// <param name="Weights">Weights</param>
    /// <param name="IsPeriodic">IsPeriodic</param>
    [PreserveSig]
    BSplineCurve2d CreateBSplineCurve2d([In] int Order, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Poles, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Knots, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Weights, [In] bool IsPeriodic);
    /// <summary>
    /// Method that creates a new Plane object. A plane object is infinite. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="RootPoint">Input Point object that specifies a point on the plane.</param>
    /// <param name="Normal">Input Vector object that specifies the normal direction of the plane.</param>
    /// <returns></returns>
    [PreserveSig]
    Plane CreatePlane([In] [MarshalAs(UnmanagedType.Interface)] Point RootPoint, [In] [MarshalAs(UnmanagedType.Interface)] Vector Normal);
    /// <summary>
    /// Method that creates a new Plane object by three points. A plane object is infinite. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="PointOne">First of three points.</param>
    /// <param name="PointTwo">Second of three points.</param>
    /// <param name="PointThree">Third of three points.</param>
    /// <returns></returns>
    [PreserveSig]
    Plane CreatePlaneByThreePoints([In] [MarshalAs(UnmanagedType.Interface)] Point PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point PointThree);
    /// <summary>
    /// Method that creates a new Cylinder object. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="RootPoint">Input Point object that specifies the base of the cylinder.</param>
    /// <param name="Axis">Input UnitVector object that specifies the direction of the axis of the cylinder.</param>
    /// <param name="Radius">Input Double that specifies the radius of the cylinder.</param>
    /// <returns></returns>
    [PreserveSig]
    Cylinder CreateCylinder([In] [MarshalAs(UnmanagedType.Interface)] Point RootPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Axis, [In] double Radius);
    /// <summary>
    /// Method that creates a new EllipticalCylinder object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="BasePoint">Input Point object that specifies the base of the elliptical cylinder.</param>
    /// <param name="AxisVector">Input UnitVector object that specifies the direction of the axis of the elliptical cylinder.</param>
    /// <param name="MajorAxisVector">Input Vector object that specifies the direction of the major axis of the elliptical cylinder.</param>
    /// <param name="MinorMajorRatio">Input Double that specifies the ratio of the minor and major axes of the elliptical cylinder.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipticalCylinder CreateEllipticalCylinder([In] [MarshalAs(UnmanagedType.Interface)] Point BasePoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector AxisVector, [In] [MarshalAs(UnmanagedType.Interface)] Vector MajorAxisVector, [In] double MinorMajorRatio);
    /// <summary>
    /// Method that creates a new Cone object. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="RootPoint">Input Point object that specifies the base of the cone.</param>
    /// <param name="Axis">Input UnitVector object that specifies the direction of the axis of the cone.</param>
    /// <param name="Radius">Input Double that specifies the radius of the cone at the base point.</param>
    /// <param name="HalfAngle">Input Double that specifies the taper angle of the cone. This is the angle measured from the axis to the side of the cone.</param>
    /// <param name="IsExpanding">Input Boolean that if the taper of the cone is expanding outwards or inwards in the direction of the axis vector. If True and the HalfAngle is positive, then the cone is expanding outward along the axis vector.</param>
    /// <returns></returns>
    [PreserveSig]
    Cone CreateCone([In] [MarshalAs(UnmanagedType.Interface)] Point RootPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Axis, [In] double Radius, [In] double HalfAngle, [In] bool IsExpanding);
    /// <summary>
    /// Method that creates a new EllipticalCone object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="BasePoint">Input Point object that specifies the base of the elliptical cone.</param>
    /// <param name="AxisVector">Input UnitVector object that specifies the direction of the axis of the elliptical cone.</param>
    /// <param name="MajorAxisVector">Input Vector object that specifies the direction of the major axis of the elliptical cone.</param>
    /// <param name="MinorMajorRatio">Input Double that specifies the ratio of the minor and major axes of the elliptical cone.</param>
    /// <param name="HalfAngle">Input Double that specifies the taper angle of the elliptical cone. This is the angle measured from the axis to the side of the elliptical cone.</param>
    /// <param name="IsExpanding">Input Boolean that if the taper of the elliptical cone is expanding outwards or inwards in the direction of the axis vector. If True and the HalfAngle is positive, then the elliptical cone is expanding outward along the axis vector.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipticalCone CreateEllipticalCone([In] [MarshalAs(UnmanagedType.Interface)] Point BasePoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector AxisVector, [In] [MarshalAs(UnmanagedType.Interface)] Vector MajorAxisVector, [In] double MinorMajorRatio, [In] double HalfAngle, [In] bool IsExpanding);
    /// <summary>
    /// Method that creates a new Sphere object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="CenterPoint">Input Point object that specifies the center of the sphere.</param>
    /// <param name="Radius">Input Double value that specifies the radius of the sphere.</param>
    /// <returns></returns>
    [PreserveSig]
    Sphere CreateSphere([In] [MarshalAs(UnmanagedType.Interface)] Point CenterPoint, [In] double Radius);
    /// <summary>
    /// Method that creates a new Torus object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="CenterPoint">Input Point object that specifies the center of the torus.</param>
    /// <param name="AxisVector">Input UnitVector object that specifies the direction of the axis of the torus.</param>
    /// <param name="MajorRadius">Input Double that specifies the major radius of the torus.</param>
    /// <param name="MinorRadius">Input Double that specifies the minor radius of the torus.</param>
    /// <returns></returns>
    [PreserveSig]
    Torus CreateTorus([In] [MarshalAs(UnmanagedType.Interface)] Point CenterPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector AxisVector, [In] double MajorRadius, [In] double MinorRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Order">Order</param>
    /// <param name="Poles">Poles</param>
    /// <param name="KnotsU">KnotsU</param>
    /// <param name="KnotsV">KnotsV</param>
    /// <param name="Weights">Weights</param>
    /// <param name="IsPeriodic">IsPeriodic</param>
    [PreserveSig]
    BSplineSurface CreateBSplineSurface([In] [MarshalAs(UnmanagedType.SafeArray)] ref int[,] Order, [In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] Poles, [In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] KnotsU, [In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] KnotsV, [In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] Weights, [In] [MarshalAs(UnmanagedType.SafeArray)] ref bool[,] IsPeriodic);
    /// <summary>
    /// Method that creates a new BSplineCurve2dDefinition object. This method creates an empty object. Use the methods/properties on this object to populate it and then use it as the argument in the CreateFittedBSplineCurve2d method.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BSplineCurve2dDefinition CreateBSplineCurve2dDefinition();
    /// <summary>
    /// Method that creates a new object using fit points. The definition of the curve is supplied using the input definition object. If an invalid curve is defined the method will fail. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Definition">Input BSplineCurve2dDefinition object that defines the 2d BSpline curve.</param>
    /// <returns></returns>
    [PreserveSig]
    BSplineCurve2d CreateFittedBSplineCurve2d([In] [MarshalAs(UnmanagedType.Interface)] BSplineCurve2dDefinition Definition);
    /// <summary>
    /// Method that creates a new BSplineCurveDefinition object. This method creates an empty object. Use the methods/properties on this object to populate it and then use it as the argument in the CreateFittedBSplineCurve method.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BSplineCurveDefinition CreateBSplineCurveDefinition();
    /// <summary>
    /// Method that creates a new object using fit points. The definition of the curve is supplied using the input definition object. If an invalid curve is defined the method will fail. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Definition">Input BSplineCurveDefinition object that defines the BSpline curve.</param>
    /// <returns></returns>
    [PreserveSig]
    BSplineCurve CreateFittedBSplineCurve([In] [MarshalAs(UnmanagedType.Interface)] BSplineCurveDefinition Definition);
    /// <summary>
    /// Method that creates a new Polyline3d object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Points">Input Variant that defines the coordinates of the polyline. Valid input for this argument is an ObjectCollection of Point objects or an array of Double values that contains the X, Y, Z values of each coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    Polyline3d CreatePolyline3d([In] [MarshalAs(UnmanagedType.Struct)] object Points);
    /// <summary>
    /// Method that creates a new Polyline3d object by approximating the input curve within the specified tolerance. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Curve">Input transient geometry curve that will be approximated. Valid input for this argument is an Arc3d, BSplineCurve, Circle, EllipseFull, EllipticalArc, and LineSegment.</param>
    /// <param name="Tolerance">Input Double defining the approximation tolerance. This value is in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    Polyline3d CreatePolyline3dFromCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] double Tolerance);
    /// <summary>
    /// Method that creates a new Polyline2d object. The object created is a transient mathematical object and is not displayed graphically
    /// </summary>
    /// <param name="Points">Input Variant that defines the coordinates of the 2d polyline. Valid input for this argument is an ObjectCollection of Point2d objects or an array of Double values that contains the X, Y values of each coordinate.</param>
    /// <returns></returns>
    [PreserveSig]
    Polyline2d CreatePolyline2d([In] [MarshalAs(UnmanagedType.Struct)] object Points);
    /// <summary>
    /// Method that creates a new Polyline2d object by approximating the input curve within the specified tolerance. The object created is a transient mathematical object and is not displayed graphically.
    /// </summary>
    /// <param name="Curve">Input transient geometry curve that will be approximated. Valid input for this argument is an Arc2d, BSplineCurve2d, Circle2d, EllipseFull2d, EllipticalArc2d, and LineSegment2d.</param>
    /// <param name="Tolerance">Input Double defining the approximation tolerance. This value is in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    Polyline2d CreatePolyline2dFromCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] double Tolerance);
    /// <summary>
    /// Gets the intersection between the input curves.
    /// </summary>
    /// <param name="CurveOne">Input object that specifies the first curve for the intersection.  The input can be any of the transient 3D curve objects (Line, LineSegment, Arc3d, EllipticalArc, Circle, EllipseFull, or a BSplineCurve).</param>
    /// <param name="CurveTwo">Input object that specifies the second curve for the intersection. The input can be any of the transient 3D curve objects (Line, LineSegment, Arc3d, EllipticalArc, Circle, EllipseFull, or a BSplineCurve).</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator CurveCurveIntersection([In] [MarshalAs(UnmanagedType.IDispatch)] object CurveOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object CurveTwo, [In] double? Tolerance = default);
    /// <summary>
    /// Gets the intersection between the input curve and the input surface.
    /// </summary>
    /// <param name="Curve">Input object that specifies the curve for the intersection.  The input can be any of the transient 3D curve objects (Line, LineSegment, Arc3d, EllipticalArc, Circle, EllipseFull, or a BSplineCurve).</param>
    /// <param name="Surface">Input object that specifies the surface for the intersection. The input can be any of the transient surface objects (Plane, Cone, Cylinder, EllipticalCone, EllipticalCylinder, Sphere, Torus or a BSplineSurface).</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator CurveSurfaceIntersection([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] [MarshalAs(UnmanagedType.IDispatch)] object Surface, [In] double? Tolerance = default);
    /// <summary>
    /// Gets the intersection between the input surfaces.
    /// </summary>
    /// <param name="SurfaceOne">Input object that specifies the first surface for the intersection. The input can be any of the transient surface objects (Plane, Cone, Cylinder, EllipticalCone, EllipticalCylinder, Sphere, Torus or a BSplineSurface).</param>
    /// <param name="SurfaceTwo">Input object that specifies the second surface for the intersection. The input can be any of the transient surface objects (Plane, Cone, Cylinder, EllipticalCone, EllipticalCylinder, Sphere, Torus or a BSplineSurface).</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator SurfaceSurfaceIntersection([In] [MarshalAs(UnmanagedType.IDispatch)] object SurfaceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object SurfaceTwo, [In] double? Tolerance = default);
    /// <summary>
    /// Gets the farmost point along the direction.
    /// </summary>
    /// <param name="Entity">Input the entity object from which to get the farmost point along specified direction.
    /// Valid entity can be Edge, Face and SurfaceBody.</param>
    /// <param name="Direction">Input the UnitVector object to specify the direction.</param>
    /// <returns></returns>
    [PreserveSig]
    Point GetFarmostPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Direction);
    /// <summary>
    /// Method that creates a new oriented box object.
    /// </summary>
    /// <param name="CornerPoint">Optional input Point object that defines a corner point of the oriented box. The below DirectionOne/ DirectionTwo/DirectionThree arguments define the oriented box directions with this corner point as starting point. If not specified the origin point will be used.</param>
    /// <param name="DirectionOne">Optional input Vector object that specifies the first direction and length. If not specified a default vector(1,0,0) will be used.</param>
    /// <param name="DirectionTwo">Optional input Vector object that specifies the second direction and length. If not specified a default vector(0,1,0) will be used. If this vector is not perpendicular to the DirectionOne, an error will occur.</param>
    /// <param name="DirectionThree">Optional input Vector object that specifies the third direction and length. If not specified
    /// (Vector(0,0,1) a default vector(0,0,1) will be used. If this vector is not perpendicular to the DirectionOne and DirectionTwo, an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    OrientedBox CreateOrientedBox([In] [MarshalAs(UnmanagedType.Struct)] object? CornerPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DirectionOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DirectionTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DirectionThree = default);
}

namespace Oblikovati.API;

/// <summary>
/// The GeneralDimensions collection object provides access to all of the general dimensions ( objects) on the sheet.
/// </summary>
public interface GeneralDimensions : IEnumerable
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
    /// Method that returns the specified dimension object from the collection.
    /// </summary>
    GeneralDimension Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewOrSketch">ViewOrSketch</param>
    /// <param name="DimensionsToRetrieve">DimensionsToRetrieve</param>
    [PreserveSig]
    GeneralDimensionsEnumerator Retrieve([In] [MarshalAs(UnmanagedType.IDispatch)] object ViewOrSketch, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionsToRetrieve = default);
    /// <summary>
    /// Method that creates a linear dimension. Valid intent combinations are: Two points, Two curves, Point and a curve, One linear curve, One arc curve (with DimensionType set to kAlignedDimensionType for chord length and kArcLengthDimensionType for arc length).
    /// </summary>
    /// <param name="TextOrigin">Object that specifies the position of the dimension text on sheet.</param>
    /// <param name="IntentOne">Object that specifies the first geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentTwo">Object that specifies the second geometry to dimension. This argument must be specified if the first geometry intent is a point. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="DimensionType">Specifies the linear dimension type. Valid values (based on the input intents) are kAlignedDimensionType, kHorizontalDimensionType, kVerticalDimensionType, kArcLengthDimensionType, kSymmetricDimensionType and kDiametricDimensionType. If not specified, the argument defaults to kAlignedDimensionType. An error will occur if the specified type is invalid for the input intents. For instance, kHorizontalDimensionType is invalid for a vertical dimension and kSymmetricDimensionType & kDiametricDimensionType are invalid if only the first intent (an edge) is specified. kArcLengthDimensionType is only valid if two intents are supplied and they represent end points of an arc or a single intent is supplied and it represents an arc.</param>
    /// <param name="ArrowheadsInside">Indicates whether to place the dimension line arrows inside or outside. If not specified, this argument defaults to True indicating that arrowheads will be place inside (if possible).</param>
    /// <param name="DimensionStyle">Object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearGeneralDimension AddLinear([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentTwo = default, [In] DimensionTypeEnum? DimensionType = DimensionTypeEnum.kAlignedDimensionType, [In] bool? ArrowheadsInside = true, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates an angular dimension. Valid intent combinations are Three points, Two non-parallel linear curves, One arc curve.
    /// </summary>
    /// <param name="TextOrigin">Object that specifies the position of the dimension text on sheet.</param>
    /// <param name="IntentOne">Object that specifies the first geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentTwo">Object that specifies the second geometry to dimension. If three point intents are provided, this input indicates the apex point of the angle. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentThree">Object that specifies the third geometry to dimension. This argument must be specified if the first and second geometry intents are points. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="ArrowheadsInside">Indicates whether to place the dimension line arrows inside or outside. If not specified, this argument defaults to True indicating that arrowheads will be place inside (if possible).</param>
    /// <param name="UseQuadrant">Optional input Boolean that indicates whether to use the quadrant in which the input text point lies to decide which angle to dimension. If not specified, the argument defaults to True. If a single (arc) intent is provided as input, this argument is ignored and assumed to be False.</param>
    /// <param name="OppositeAngle">Indicates whether to dimension the opposite angle. If not specified, the argument defaults to False.</param>
    /// <param name="DimensionStyle">Object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    AngularGeneralDimension AddAngular([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentThree = default, [In] bool? ArrowheadsInside = true, [In] bool? UseQuadrant = true, [In] bool? OppositeAngle = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a radius dimension.
    /// </summary>
    /// <param name="TextOrigin">Specifies the position of the dimension text on sheet.</param>
    /// <param name="Intent">Specifies the arc or circle to dimension. A parameter along the curve should be specified in the intent. If not, a default is assumed. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="ArrowheadsInside">Indicates whether to place the dimension line arrows inside or outside. If not specified, this argument defaults to False indicating that arrowheads will be place outside.</param>
    /// <param name="LeaderFromCenter">Indicates whether the leader starts from the center of the arc or the circle. If not specified, the argument defaults to False indicating that the leader will not start from the center. This argument is ignored and defaulted to True if the ArrowheadsInside argument is specified to be True.</param>
    /// <param name="Jogged">Indicates whether the dimension is jogged. If not specified, the argument defaults to False.</param>
    /// <param name="DimensionStyle">Specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    RadiusGeneralDimension AddRadius([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] bool? ArrowheadsInside = false, [In] bool? LeaderFromCenter = false, [In] bool? Jogged = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a diameter dimension.
    /// </summary>
    /// <param name="TextOrigin">Specifies the position of the dimension text on sheet.</param>
    /// <param name="Intent">Specifies the arc or circle to dimension. A parameter along the curve should be specified in the intent. If not, a default is assumed. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="ArrowheadsInside">Indicates whether to place the dimension line arrows inside or outside. If not specified, this argument defaults to False indicating that arrowheads will be place outside.</param>
    /// <param name="LeaderFromCenter">Indicates whether the leader starts from the center of the arc or the circle. If not specified, the argument defaults to False indicating that the leader will not start from the center.</param>
    /// <param name="SingleDimensionLine">Indicates whether to use a single dimension line. If not specified, the argument defaults to True indicating a single dimension line will be used.</param>
    /// <param name="DimensionStyle">Specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    DiameterGeneralDimension AddDiameter([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] bool? ArrowheadsInside = false, [In] bool? LeaderFromCenter = false, [In] bool? SingleDimensionLine = true, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="View">View</param>
    /// <param name="ModelObject">ModelObject</param>
    [PreserveSig]
    ObjectCollection GetRetrievableDimensions([In] [MarshalAs(UnmanagedType.Interface)] DrawingView View, [In] [MarshalAs(UnmanagedType.Struct)] object? ModelObject = default);
    /// <summary>
    /// Creates a linear foreshortened dimension on the drawing sheet.
    /// </summary>
    /// <param name="TextOrigin">Input Point2d object that specifies the position of the dimension text on sheet.</param>
    /// <param name="IntentOne">Input GeometryIntent object that specifies the first geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentTwo">Input GeometryIntent object that specifies the second geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="HideSecondArrowhead">Optional input Boolean that specifies whether hide the second arrowhead of the dimension.</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearGeneralDimension AddLinearForeshortened([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentTwo, [In] bool? HideSecondArrowhead = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Creates an arc length foreshortened dimension on the drawing sheet.
    /// </summary>
    /// <param name="TextOrigin">Input Point2d object that specifies the position of the dimension text on sheet.</param>
    /// <param name="IntentOne">Input GeometryIntent object that specifies the first geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentTwo">Optional input GeometryIntent object that specifies the second geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentThree">Optional input GeometryIntent object that specifies the third geometry to dimension. This argument must be specified if the first and second geometry intents are points.The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="VirtualArcPosition">Optional input GeometryIntent object that specifies the virtual arc’s position for dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="HideSecondArrowhead">Optional input Boolean that specifies whether hide the second arrowhead of the dimension.</param>
    /// <param name="UseQuadrant">Optional input Boolean that indicates whether to use the quadrant in which the input text point lies to decide which angle to dimension.  If not specified, the argument defaults to True.  If a single (arc) intent is provided as input, this argument is ignored and assumed to be False.</param>
    /// <param name="OppositeAngle">Optional input Boolean that indicates whether to dimension the opposite angle.  If not specified, the argument defaults to False.</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearGeneralDimension AddArcLengthForeshortened([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentThree = default, [In] [MarshalAs(UnmanagedType.Struct)] object? VirtualArcPosition = default, [In] bool? HideSecondArrowhead = false, [In] bool? UseQuadrant = true, [In] bool? OppositeAngle = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Creates an angular foreshortened dimension on the drawing sheet.
    /// </summary>
    /// <param name="TextOrigin">Input Point2d object that specifies the position of the dimension text on sheet.</param>
    /// <param name="IntentOne">Input GeometryIntent object that specifies the first geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentTwo">Optional input GeometryIntent object that specifies the second geometry to dimension. If three point intents are provided, this input indicates the apex point of the angle.  The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentThree">Optional input GeometryIntent object that specifies the third geometry to dimension. This argument must be specified if the first and second geometry intents are points.The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="HideSecondArrowhead">Optional input Boolean that specifies whether hide the second arrowhead of the dimension.</param>
    /// <param name="UseQuadrant">Optional input Boolean that indicates whether to use the quadrant in which the input text point lies to decide which angle to dimension.  If not specified, the argument defaults to True.  If a single (arc) intent is provided as input, this argument is ignored and assumed to be False.</param>
    /// <param name="OppositeAngle">Optional input Boolean that indicates whether to dimension the opposite angle.  If not specified, the argument defaults to False.</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    AngularGeneralDimension AddAngularForeshortened([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentThree = default, [In] bool? HideSecondArrowhead = false, [In] bool? UseQuadrant = true, [In] bool? OppositeAngle = false, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Creates a linear dimension on the drawing sheet.
    /// </summary>
    /// <param name="TextOrigin">Input Point2d object that specifies the position of the dimension text on sheet.</param>
    /// <param name="IntentOne">Input GeometryIntent object that specifies the first geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="IntentTwo">Optional input GeometryIntent object that specifies the second geometry to dimension. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="DimensionType">Optional input DimensionTypeEnum that specifies the linear dimension type.  Valid values (based on the input intents) are kAlignedDimensionType, kHorizontalDimensionType, kVerticalDimensionType, kArcLengthDimensionType, kSymmetricDimensionType, kDiametricDimensionType, kAlignedToCurveDimensionType and kNormalToCurveDimensionType.  If not specified, the argument defaults to kAlignedDimensionType.  An error will occur if the specified type is invalid for the input intents.  For instance, kHorizontalDimensionType is invalid for a vertical dimension and kSymmetricDimensionType & kDiametricDimensionType are invalid if only the first intent (an edge) is specified.  kArcLengthDimensionType is only valid if two intents are supplied and they represent end points of an arc or a single intent is supplied and it represents an arc.</param>
    /// <param name="AlignmentGeometry">Optional input linear geometry object to align the dimension. Valid objects are DrawingCurve and SketchLine in the same DrawingView as the dimension. This is only applicable if the DimensionType is set to kAlignedToCurveDimensionType or kNormalToCurveDimensionType.</param>
    /// <param name="ArrowheadsInside">Optional input Boolean that indicates whether to place the dimension line arrows inside or outside.  If not specified, this argument defaults to True indicating that arrowheads will be place inside (if possible).</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearGeneralDimension AddLinear2([In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentTwo = default, [In] DimensionTypeEnum? DimensionType = DimensionTypeEnum.kAlignedDimensionType, [In] [MarshalAs(UnmanagedType.Struct)] object? AlignmentGeometry = default, [In] bool? ArrowheadsInside = true, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}

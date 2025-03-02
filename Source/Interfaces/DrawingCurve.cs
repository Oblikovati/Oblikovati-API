namespace Oblikovati.API;

/// <summary>
/// The DrawingCurve object represents a curve within a drawing view that resulted from a model (including sketch entities).
/// </summary>
public interface DrawingCurve
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
    /// Property that returns the parent drawing view of the curve.
    /// </summary>
    DrawingView Parent { get; }
    /// <summary>
    /// Property that returns the corresponding geometry from the model. This property returns Nothing in the case the model is not available.
    /// </summary>
    object ModelGeometry { get; }
    /// <summary>
    /// Property that returns the type of the underlying curve geometry that this curve is defined by.
    /// </summary>
    CurveTypeEnum CurveType { get; }
    /// <summary>
    /// Property that returns the Curve2dEvaluator object for this curve in sheet space.
    /// </summary>
    Curve2dEvaluator Evaluator2D { get; }
    /// <summary>
    /// Property that returns the CurveEvaluator object for this curve in 3d model view space.
    /// </summary>
    CurveEvaluator Evaluator3D { get; }
    /// <summary>
    /// Property that returns the start point of the curve in sheet space. This property returns Nothing for circular curves.
    /// </summary>
    Point2d StartPoint { get; }
    /// <summary>
    /// Property that returns the end point of the curve in sheet space. This property returns Nothing for circular curves.
    /// </summary>
    Point2d EndPoint { get; }
    /// <summary>
    /// Property that returns the center point of the curve in sheet space. This property returns the center for arcs and circles and Nothing if the curve does not have a center.
    /// </summary>
    Point2d CenterPoint { get; }
    /// <summary>
    /// Property that returns the mid point of the curve in sheet space. This property returns the mid point for linear curves and arcs.
    /// </summary>
    Point2d MidPoint { get; }
    /// <summary>
    /// Property that returns the collection of the selectable segments representing this curve.
    /// </summary>
    DrawingCurveSegments Segments { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Color OverrideColor { get; set; }
    /// <summary>
    /// Gets and sets the color for the curve.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and sets the line weight override for the curve.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the line type override for the curve.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Property that returns the curve type of the drawing curve projected onto the sheet. For instance, if a circular drawing curve shows up as a linear curve on the sheet, this property returns kLineSegmentCurve2d.
    /// </summary>
    Curve2dTypeEnum ProjectedCurveType { get; }
    /// <summary>
    /// Property that returns the edge type of this curve. Possible return values are kThreadEdge, kBendUpEdge, kBendDownEdge, kBendExtentEdge, kPunchDownEdge, kPunchUpEdge, kTangentEdge, kContourRollEdge, and kUnknownEdge.
    /// </summary>
    DrawingEdgeTypeEnum EdgeType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}

namespace Oblikovati.API;

/// <summary>
/// The SurfaceEvaluator object. See the article in the overviews section.
/// </summary>
public interface SurfaceEvaluator
{
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that returns a that defines the parameter range for this surface.
    /// </summary>
    Box2d ParamRangeRect { get; }
    /// <summary>
    /// Determines if the parameter is on the face.
    /// </summary>
    bool IsParamOnFace { get; }
    /// <summary>
    /// Property that returns the area of the entity.
    /// </summary>
    double Area { get; }
    /// <summary>
    /// Gets the level of continuity of the curve. The continuity is the largest order of continuity maintained for the entire curve.
    /// </summary>
    int Continuity { get; }
    /// <summary>
    /// Read-only property that returns whether the surface resulted from an extrusion.
    /// </summary>
    bool IsExtrudedShape { get; }
    /// <summary>
    /// Read-only property that returns whether the surface resulted from a revolution.
    /// </summary>
    bool IsRevolvedShape { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Points">Points</param>
    /// <param name="GuessParams">GuessParams</param>
    /// <param name="MaxDeviations">MaxDeviations</param>
    /// <param name="Params">Params</param>
    /// <param name="SolutionNatures">SolutionNatures</param>
    [PreserveSig]
    void GetParamAtPoint([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Points, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] GuessParams, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MaxDeviations, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out SolutionNatureEnum[,] SolutionNatures);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="Points">Points</param>
    [PreserveSig]
    void GetPointAtParam([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Points);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="Normals">Normals</param>
    [PreserveSig]
    void GetNormal([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Normals);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="UTangents">UTangents</param>
    /// <param name="VTangents">VTangents</param>
    [PreserveSig]
    void GetTangents([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] UTangents, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VTangents);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="MaxTangents">MaxTangents</param>
    /// <param name="MaxCurvatures">MaxCurvatures</param>
    /// <param name="MinCurvatures">MinCurvatures</param>
    [PreserveSig]
    void GetCurvatures([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MaxTangents, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MaxCurvatures, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MinCurvatures);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="UPartials">UPartials</param>
    /// <param name="VPartials">VPartials</param>
    [PreserveSig]
    void GetFirstDerivatives([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] UPartials, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VPartials);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="UUPartials">UUPartials</param>
    /// <param name="UVPartials">UVPartials</param>
    /// <param name="VVPartials">VVPartials</param>
    [PreserveSig]
    void GetSecondDerivatives([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] UUPartials, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] UVPartials, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VVPartials);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="UUUPartials">UUUPartials</param>
    /// <param name="VVVPartials">VVVPartials</param>
    [PreserveSig]
    void GetThirdDerivatives([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] UUUPartials, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VVVPartials);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PeriodicityU">PeriodicityU</param>
    /// <param name="PeriodicityV">PeriodicityV</param>
    /// <param name="NumEndSingularitiesU">NumEndSingularitiesU</param>
    /// <param name="SingularitiesU">SingularitiesU</param>
    /// <param name="NumEndSingularitiesV">NumEndSingularitiesV</param>
    /// <param name="SingularitiesV">SingularitiesV</param>
    /// <param name="UnboundedParams">UnboundedParams</param>
    [PreserveSig]
    void GetParamAnomaly([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] PeriodicityU, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] PeriodicityV, [Out] out int NumEndSingularitiesU, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] SingularitiesU, [Out] out int NumEndSingularitiesV, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] SingularitiesV, [Out] [MarshalAs(UnmanagedType.SafeArray)] out bool[,] UnboundedParams);
    /// <summary>
    /// Function that calculates the equivalent 3D curve for a 2D curve defined in the parametric space of the surface associated with the evaluator.&nbsp;The resulting transient geometry 3D curve is returned.&nbsp;The type of curve(s) returned is dependent on the shape of the input curve and the surface.
    /// </summary>
    /// <param name="Curve2d">Input 2d transient geometry entity that defines geometry in the parametric space of the surface associated with the evaluator.</param>
    /// <returns></returns>
    [PreserveSig]
    object Get3dCurveFrom2dCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve2d);
    /// <summary>
    /// Function that extracts a curve from the surface that follows a constant u or v parameter along the surface.&nbsp;It will have the same properties of the surface in the direction of the extraction.&nbsp;For example, if a curve is extracted from a periodic surface in the direction where it is periodic, the extracted curve will also be periodic.&nbsp;The type of curve returned is dependent on the shape the surface.
    /// </summary>
    /// <param name="Parameter">Input Double that specifies the parameter value to indicate where the curve should be extracted.  It can be either a U or V parameter depending on the value of the next argument.</param>
    /// <param name="UDirection">Input Boolean indicating if the parameter value is a U or V parameter value.  If True, then the parameter value is a V parameter indicating that the position of the U iso curve.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection GetIsoCurve([In] double Parameter, [In] bool UDirection);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Points">Points</param>
    /// <param name="Normals">Normals</param>
    [PreserveSig]
    void GetNormalAtPoint([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Points, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Normals);
}

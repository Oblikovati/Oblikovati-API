namespace Oblikovati.API;

/// <summary>
/// The Curve2dEvaluator object. See the article in the overviews section.
/// </summary>
public interface Curve2dEvaluator
{
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets the level of continuity of the curve. The continuity is the largest order of continuity maintained for the entire curve.
    /// </summary>
    int Continuity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartPoint">StartPoint</param>
    /// <param name="EndPoint">EndPoint</param>
    [PreserveSig]
    void GetEndPoints([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] StartPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] EndPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MinParam">MinParam</param>
    /// <param name="MaxParam">MaxParam</param>
    [PreserveSig]
    void GetParamExtents([Out] out double MinParam, [Out] out double MaxParam);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Points">Points</param>
    /// <param name="GuessParams">GuessParams</param>
    /// <param name="MaxDeviations">MaxDeviations</param>
    /// <param name="Params">Params</param>
    /// <param name="SolTypes">SolTypes</param>
    [PreserveSig]
    void GetParamAtPoint([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Points, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] GuessParams, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MaxDeviations, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out SolutionNatureEnum[,] SolTypes);
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
    /// <param name="Tangents">Tangents</param>
    [PreserveSig]
    void GetTangent([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Tangents);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="Directions">Directions</param>
    /// <param name="Curvatures">Curvatures</param>
    [PreserveSig]
    void GetCurvature([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Directions, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Curvatures);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="FirstDerivs">FirstDerivs</param>
    [PreserveSig]
    void GetFirstDerivatives([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] FirstDerivs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="SecondDerivs">SecondDerivs</param>
    [PreserveSig]
    void GetSecondDerivatives([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] SecondDerivs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Params">Params</param>
    /// <param name="ThirdDerivs">ThirdDerivs</param>
    [PreserveSig]
    void GetThirdDerivatives([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Params, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] ThirdDerivs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromParam">FromParam</param>
    /// <param name="Length">Length</param>
    /// <param name="Param">Param</param>
    [PreserveSig]
    void GetParamAtLength([In] double FromParam, [In] double Length, [Out] out double Param);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromParam">FromParam</param>
    /// <param name="ToParam">ToParam</param>
    /// <param name="Length">Length</param>
    [PreserveSig]
    void GetLengthAtParam([In] double FromParam, [In] double ToParam, [Out] out double Length);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Periodicity">Periodicity</param>
    /// <param name="IsSingular">IsSingular</param>
    /// <param name="UnboundedParam">UnboundedParam</param>
    [PreserveSig]
    void GetParamAnomaly([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Periodicity, [Out] out bool IsSingular, [Out] out bool UnboundedParam);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromParam">FromParam</param>
    /// <param name="ToParam">ToParam</param>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    [PreserveSig]
    void GetStrokes([In] double FromParam, [In] double ToParam, [In] double Tolerance, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates);
}

namespace Oblikovati.API;

public interface IRxCurveEvaluator
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox RangeBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    uint Continuity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pStartPoint">pStartPoint</param>
    /// <param name="pEndPoint">pEndPoint</param>
    void GetEndPoints([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pStartPoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pEndPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pMinParam">pMinParam</param>
    /// <param name="pMaxParam">pMaxParam</param>
    void GetParamExtents([Out] out double pMinParam, [Out] out double pMaxParam);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nPoints">nPoints</param>
    /// <param name="pPoints">pPoints</param>
    /// <param name="pGuessParams">pGuessParams</param>
    /// <param name="pMaxDeviations">pMaxDeviations</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pSolTypes">pSolTypes</param>
    void GetParamAtPoint([In] uint nPoints, [In] ref double pPoints, [In] [Out] ref double pGuessParams, [In] [Out] ref double pMaxDeviations, [In] [Out] ref double pParams, [In] [Out] ref SolutionNatureEnum pSolTypes);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pPoints">pPoints</param>
    void GetPointAtParam([In] uint nParams, [In] ref double pParams, [Out] out double pPoints);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pTangents">pTangents</param>
    void GetTangent([In] uint nParams, [In] ref double pParams, [Out] out double pTangents);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pDirections">pDirections</param>
    /// <param name="pCurvatures">pCurvatures</param>
    void GetCurvature([In] uint nParams, [In] ref double pParams, [In] [Out] ref double pDirections, [In] [Out] ref double pCurvatures);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pFirstDerivs">pFirstDerivs</param>
    /// <param name="pSecondDerivs">pSecondDerivs</param>
    /// <param name="pThirdDerivs">pThirdDerivs</param>
    void GetDerivatives([In] uint nParams, [In] ref double pParams, [In] [Out] ref double pFirstDerivs, [In] [Out] ref double pSecondDerivs, [In] [Out] ref double pThirdDerivs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromParam">FromParam</param>
    /// <param name="Length">Length</param>
    /// <param name="pParam">pParam</param>
    void GetParamAtLength([In] double FromParam, [In] double Length, [Out] out double pParam);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromParam">FromParam</param>
    /// <param name="ToParam">ToParam</param>
    /// <param name="pLength">pLength</param>
    void GetLengthAtParam([In] double FromParam, [In] double ToParam, [Out] out double pLength);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pPeriodicity">pPeriodicity</param>
    /// <param name="pIsSingular">pIsSingular</param>
    /// <param name="pUnboundedParam">pUnboundedParam</param>
    void GetParamAnomaly([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pPeriodicity, [Out] out sbyte pIsSingular, [Out] out sbyte pUnboundedParam);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromParam">FromParam</param>
    /// <param name="ToParam">ToParam</param>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="nVertexCount">nVertexCount</param>
    /// <param name="ppVertexCoordinates">ppVertexCoordinates</param>
    void GetStrokes([In] double FromParam, [In] double ToParam, [In] double Tolerance, [Out] out uint nVertexCount, [Out] out IntPtr ppVertexCoordinates);
}

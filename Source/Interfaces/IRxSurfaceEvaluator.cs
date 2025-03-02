namespace Oblikovati.API;

public interface IRxSurfaceEvaluator
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox RangeBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox2d ParamRangeRect { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsParamOnFace { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Area { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    uint Continuity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsExtrudedShape { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsRevolvedShape { get; }
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
    /// <param name="pNormals">pNormals</param>
    void GetNormal([In] uint nParams, [In] ref double pParams, [Out] out double pNormals);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pUTangents">pUTangents</param>
    /// <param name="pVTangents">pVTangents</param>
    void GetTangents([In] uint nParams, [In] ref double pParams, [Out] out double pUTangents, [Out] out double pVTangents);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pMaxTangents">pMaxTangents</param>
    /// <param name="pMaxCurvatures">pMaxCurvatures</param>
    /// <param name="pMinCurvatures">pMinCurvatures</param>
    void GetCurvatures([In] uint nParams, [In] ref double pParams, [In] [Out] ref double pMaxTangents, [In] [Out] ref double pMaxCurvatures, [In] [Out] ref double pMinCurvatures);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nParams">nParams</param>
    /// <param name="pParams">pParams</param>
    /// <param name="pUPartials">pUPartials</param>
    /// <param name="pVPartials">pVPartials</param>
    /// <param name="pUUPartials">pUUPartials</param>
    /// <param name="pUVPartials">pUVPartials</param>
    /// <param name="pVVPartials">pVVPartials</param>
    /// <param name="pUUUPartials">pUUUPartials</param>
    /// <param name="pVVVPartials">pVVVPartials</param>
    void GetDerivatives([In] uint nParams, [In] ref double pParams, [In] [Out] ref double pUPartials, [In] [Out] ref double pVPartials, [In] [Out] ref double pUUPartials, [In] [Out] ref double pUVPartials, [In] [Out] ref double pVVPartials, [In] [Out] ref double pUUUPartials, [In] [Out] ref double pVVVPartials);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pPeriodicityU">pPeriodicityU</param>
    /// <param name="pPeriodicityV">pPeriodicityV</param>
    /// <param name="pnEndSingularityU">pnEndSingularityU</param>
    /// <param name="pSingularityU">pSingularityU</param>
    /// <param name="pnEndSingularityV">pnEndSingularityV</param>
    /// <param name="pSingularityV">pSingularityV</param>
    /// <param name="pUnboundedParam">pUnboundedParam</param>
    void GetParamAnomaly([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pPeriodicityU, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pPeriodicityV, [Out] out uint pnEndSingularityU, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pSingularityU, [Out] out uint pnEndSingularityV, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pSingularityV, [Out] [MarshalAs(UnmanagedType.LPArray)] out SByte[] pUnboundedParam);
}

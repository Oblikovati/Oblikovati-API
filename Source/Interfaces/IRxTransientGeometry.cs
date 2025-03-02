namespace Oblikovati.API;

public interface IRxTransientGeometry
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxMatrix CreateMatrix();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxMatrix2d CreateMatrix2d();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox CreateBox();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxBox2d CreateBox2d();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XCoord">XCoord</param>
    /// <param name="YCoord">YCoord</param>
    /// <param name="ZCoord">ZCoord</param>
    IRxPoint CreatePoint([In] double? XCoord = default, [In] double? YCoord = default, [In] double? ZCoord = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XCoord">XCoord</param>
    /// <param name="YCoord">YCoord</param>
    IRxPoint2d CreatePoint2d([In] double? XCoord = default, [In] double? YCoord = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XCoord">XCoord</param>
    /// <param name="YCoord">YCoord</param>
    /// <param name="ZCoord">ZCoord</param>
    IRxVector CreateVector([In] double? XCoord = default, [In] double? YCoord = default, [In] double? ZCoord = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XCoord">XCoord</param>
    /// <param name="YCoord">YCoord</param>
    IRxVector2d CreateVector2d([In] double? XCoord = default, [In] double? YCoord = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XCoord">XCoord</param>
    /// <param name="YCoord">YCoord</param>
    /// <param name="ZCoord">ZCoord</param>
    IRxUnitVector CreateUnitVector([In] double? XCoord = default, [In] double? YCoord = default, [In] double? ZCoord = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XCoord">XCoord</param>
    /// <param name="YCoord">YCoord</param>
    IRxUnitVector2d CreateUnitVector2d([In] double? XCoord = default, [In] double? YCoord = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxLine CreateLine();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxLine2d CreateLine2d();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCircle CreateCircle();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCircle2d CreateCircle2d();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nOrder">nOrder</param>
    /// <param name="nPoles">nPoles</param>
    /// <param name="nKnots">nKnots</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="bIsPeriodic">bIsPeriodic</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnots">pKnots</param>
    /// <param name="pWeights">pWeights</param>
    IRxBSplineCurve CreateBSplineCurve([In] uint nOrder, [In] uint nPoles, [In] uint nKnots, [In] uint nWeights, [In] sbyte bIsPeriodic, [In] ref double pPoles, [In] ref double pKnots, [Out] out double pWeights);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nOrder">nOrder</param>
    /// <param name="nPoles">nPoles</param>
    /// <param name="nKnots">nKnots</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="bIsPeriodic">bIsPeriodic</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnots">pKnots</param>
    /// <param name="pWeights">pWeights</param>
    IRxBSplineCurve2d CreateBSplineCurve2d([In] uint nOrder, [In] uint nPoles, [In] uint nKnots, [In] uint nWeights, [In] sbyte bIsPeriodic, [Out] out double pPoles, [Out] out double pKnots, [Out] out double pWeights);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPlane CreatePlane();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCylinder CreateCylinder();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEllipticalCylinder CreateEllipticalCylinder();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCone CreateCone();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEllipticalCone CreateEllipticalCone();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSphere CreateSphere();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxTorus CreateTorus();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnOrder">pnOrder</param>
    /// <param name="nNumPolesUXV">nNumPolesUXV</param>
    /// <param name="nKnotsU">nKnotsU</param>
    /// <param name="nKnotsV">nKnotsV</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="pbIsPeriodic">pbIsPeriodic</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnotsU">pKnotsU</param>
    /// <param name="pKnotsV">pKnotsV</param>
    /// <param name="pWeights">pWeights</param>
    IRxBSplineSurface CreateBSplineSurface([In] [MarshalAs(UnmanagedType.LPArray)] uint[,] pnOrder, [In] uint nNumPolesUXV, [In] uint nKnotsU, [In] uint nKnotsV, [In] uint nWeights, [In] [MarshalAs(UnmanagedType.LPArray)] sbyte[,] pbIsPeriodic, [In] ref double pPoles, [In] ref double pKnotsU, [In] ref double pKnotsV, [Out] out double pWeights);
}

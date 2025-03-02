namespace Oblikovati.API;

/// <summary>
/// Face Offset Preview.
/// </summary>
public interface FaceOffsetPreview
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InputFaces">InputFaces</param>
    /// <param name="Distance">Distance</param>
    /// <param name="reverse">reverse</param>
    /// <param name="autoFaceChain">autoFaceChain</param>
    /// <param name="IsOptimized">IsOptimized</param>
    /// <param name="ApproxTol">ApproxTol</param>
    /// <param name="approxType">approxType</param>
    /// <param name="pBodies">pBodies</param>
    [PreserveSig]
    void _Preview([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection InputFaces, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] bool reverse, [In] bool autoFaceChain, [In] bool IsOptimized, [In] [MarshalAs(UnmanagedType.Struct)] object ApproxTol, [In] FeatureApproximationTypeEnum approxType, [Out] [MarshalAs(UnmanagedType.Interface)] out SurfaceBodies pBodies);
}

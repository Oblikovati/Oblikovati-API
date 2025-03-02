namespace Oblikovati.API;

public interface IRxEnumFaces
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nBodies">nBodies</param>
    /// <param name="ppBodies">ppBodies</param>
    /// <param name="pnBodiesFetched">pnBodiesFetched</param>
    void Next([In] uint nBodies, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxFace ppBodies, [Out] out uint pnBodiesFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCurves">nCurves</param>
    void Skip([In] uint nCurves);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppEnum">ppEnum</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumFaces ppEnum);
}

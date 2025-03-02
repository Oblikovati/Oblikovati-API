namespace Oblikovati.API;

public interface IRxStrokes : IRxStrokesOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pdwNumTols">pdwNumTols</param>
    /// <param name="ppTols">ppTols</param>
    void GetExistingTolerances([In] [Out] ref uint pdwNumTols, [Out] out IntPtr ppTols);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="pdwNumPolyLines">pdwNumPolyLines</param>
    /// <param name="ppPolyLineLengths">ppPolyLineLengths</param>
    void GetExistingStrokes([In] double ChordalHeightTol, [In] [Out] ref uint pdwNumVertices, [Out] out IntPtr ppVertices, [In] [Out] ref uint pdwNumPolyLines, [Out] out IntPtr ppPolyLineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    void CalculateStrokesWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] [Out] ref uint VertexCount, [Out] out IntPtr VertexCoordinates, [In] [Out] ref uint PolylineCount, [Out] out IntPtr PolylineLengths);
}

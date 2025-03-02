namespace Oblikovati.API;

public interface IRxStrokes : IRxStrokesOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pdwNumTols">pdwNumTols</param>
    /// <param name="ppTols">ppTols</param>
    void GetExistingTolerances([Out] out uint pdwNumTols, [Out] out IntPtr ppTols);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="pdwNumPolyLines">pdwNumPolyLines</param>
    /// <param name="ppPolyLineLengths">ppPolyLineLengths</param>
    void GetExistingStrokes([In] double ChordalHeightTol, [Out] out uint pdwNumVertices, [Out] out IntPtr ppVertices, [Out] out uint pdwNumPolyLines, [Out] out IntPtr ppPolyLineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    void CalculateStrokesWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out uint VertexCount, [Out] out IntPtr VertexCoordinates, [Out] out uint PolylineCount, [Out] out IntPtr PolylineLengths);
}

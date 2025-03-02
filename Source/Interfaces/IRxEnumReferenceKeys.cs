namespace Oblikovati.API;

public interface IRxEnumReferenceKeys
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="dwNumElems">dwNumElems</param>
    /// <param name="ppElems">ppElems</param>
    /// <param name="pdwNumElemsFetched">pdwNumElemsFetched</param>
    void Next([In] uint dwNumElems, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxReferenceKey ppElems, [Out] out uint pdwNumElemsFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="dwNumElems">dwNumElems</param>
    void Skip([In] uint dwNumElems);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppEnum">ppEnum</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumReferenceKeys ppEnum);
}

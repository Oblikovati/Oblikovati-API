namespace Oblikovati.API;

public interface IRxEnumReferencedFileDescriptors
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nElems">nElems</param>
    /// <param name="ppElems">ppElems</param>
    /// <param name="pnElemsFetched">pnElemsFetched</param>
    void Next([In] uint nElems, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxReferencedFileDescriptor ppElems, [Out] out uint pnElemsFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nElems">nElems</param>
    void Skip([In] uint nElems);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppEnum">ppEnum</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumReferencedFileDescriptors ppEnum);
}

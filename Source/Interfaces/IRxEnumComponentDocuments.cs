namespace Oblikovati.API;

public interface IRxEnumComponentDocuments
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCompDefDocs">nCompDefDocs</param>
    /// <param name="ppCompDefDocs">ppCompDefDocs</param>
    /// <param name="pnCompDefDocsFetched">pnCompDefDocsFetched</param>
    void Next([In] uint nCompDefDocs, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxComponentDocument ppCompDefDocs, [Out] out uint pnCompDefDocsFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCompDefs">nCompDefs</param>
    void Skip([In] uint nCompDefs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppResult">ppResult</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumComponentDocuments ppResult);
}

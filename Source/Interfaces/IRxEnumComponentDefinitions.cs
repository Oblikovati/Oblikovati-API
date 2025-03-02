namespace Oblikovati.API;

public interface IRxEnumComponentDefinitions
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCompDefs">nCompDefs</param>
    /// <param name="ppCompDefs">ppCompDefs</param>
    /// <param name="pnCompDefsFetched">pnCompDefsFetched</param>
    void Next([In] uint nCompDefs, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxComponentDefinition ppCompDefs, [Out] out uint pnCompDefsFetched);
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
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumComponentDefinitions ppResult);
}

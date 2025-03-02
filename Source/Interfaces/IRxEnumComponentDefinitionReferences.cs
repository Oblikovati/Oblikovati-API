namespace Oblikovati.API;

public interface IRxEnumComponentDefinitionReferences
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCompDefDescrs">nCompDefDescrs</param>
    /// <param name="ppCompDefDescrs">ppCompDefDescrs</param>
    /// <param name="pnCompDefDescrsFetched">pnCompDefDescrsFetched</param>
    void Next([In] uint nCompDefDescrs, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxComponentDefinitionReference ppCompDefDescrs, [Out] out uint pnCompDefDescrsFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nDescrs">nDescrs</param>
    void Skip([In] uint nDescrs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppResult">ppResult</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumComponentDefinitionReferences ppResult);
}

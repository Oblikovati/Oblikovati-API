namespace Oblikovati.API;

public interface IRxEnumComponentOccurrences
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCompOccs">nCompOccs</param>
    /// <param name="ppCompOccs">ppCompOccs</param>
    /// <param name="pnCompOccsFetched">pnCompOccsFetched</param>
    void Next([In] uint nCompOccs, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxComponentOccurrence ppCompOccs, [Out] out uint pnCompOccsFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nCompOccs">nCompOccs</param>
    void Skip([In] uint nCompOccs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppResult">ppResult</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IRxEnumComponentOccurrences ppResult);
}

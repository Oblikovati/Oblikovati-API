namespace Oblikovati.API;

public interface SearchBoxEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnStartSearch([Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SearchResult">SearchResult</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnEndSearch([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap SearchResult, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SearchResult">SearchResult</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnStopSearch([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap SearchResult, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnClearSearch([Out] out HandlingCodeEnum HandlingCode);
}

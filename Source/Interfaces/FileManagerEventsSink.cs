namespace Oblikovati.API;

public interface FileManagerEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileDelete([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SourceFullFileName">SourceFullFileName</param>
    /// <param name="DestinationFullFileName">DestinationFullFileName</param>
    /// <param name="Copy">Copy</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileCopy([In] [MarshalAs(UnmanagedType.BStr)] string SourceFullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string DestinationFullFileName, [In] bool Copy, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

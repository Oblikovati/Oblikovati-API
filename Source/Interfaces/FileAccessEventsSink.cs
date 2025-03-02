namespace Oblikovati.API;

public interface FileAccessEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="CustomLogicalName">CustomLogicalName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileResolution([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] CustomLogicalName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] [MarshalAs(UnmanagedType.BStr)] out string FullFileName, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="CustomLogicalName">CustomLogicalName</param>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFileDirty([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] CustomLogicalName, [In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

namespace Oblikovati.API;

public interface IRxFileAccessEvents
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="CustomLogicalName">CustomLogicalName</param>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileResolution([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [In] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] CustomLogicalName, [Out] [MarshalAs(UnmanagedType.BStr)] out string FullFileName, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RelativeFileName">RelativeFileName</param>
    /// <param name="LibraryName">LibraryName</param>
    /// <param name="CustomLogicalName">CustomLogicalName</param>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnFileDirty([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [In] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] CustomLogicalName, [In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [Out] out HandlingCodeEnum HandlingCode);
}

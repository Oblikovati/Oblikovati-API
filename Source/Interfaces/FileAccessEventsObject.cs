namespace Oblikovati.API;

public interface FileAccessEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
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
    void FireOnFileResolution([In] [MarshalAs(UnmanagedType.BStr)] string RelativeFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LibraryName, [Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] CustomLogicalName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] [MarshalAs(UnmanagedType.BStr)] out string FullFileName, [Out] out HandlingCodeEnum HandlingCode);
}

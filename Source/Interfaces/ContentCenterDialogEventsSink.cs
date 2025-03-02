namespace Oblikovati.API;

public interface ContentCenterDialogEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="Options">Options</param>
    /// <param name="ResultXML">ResultXML</param>
    [PreserveSig]
    void OnSelect([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] [MarshalAs(UnmanagedType.BStr)] out string ResultXML);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="Options">Options</param>
    /// <param name="ResultXML">ResultXML</param>
    [PreserveSig]
    void OnSelectionCommit([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] [MarshalAs(UnmanagedType.BStr)] out string ResultXML);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cancelled">Cancelled</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnTerminate([In] bool Cancelled, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
}

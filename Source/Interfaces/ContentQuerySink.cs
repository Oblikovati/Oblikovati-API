namespace Oblikovati.API;

public interface ContentQuerySink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void OnCancel();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ResultXML">ResultXML</param>
    [PreserveSig]
    void OnDone([In] [MarshalAs(UnmanagedType.BStr)] string ResultXML);
}

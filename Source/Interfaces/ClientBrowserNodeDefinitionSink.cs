namespace Oblikovati.API;

public interface ClientBrowserNodeDefinitionSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnActivate([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Objects">Objects</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnGetDisplayObjects([Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection Objects, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NewLabel">NewLabel</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnLabelEdit([In] [MarshalAs(UnmanagedType.BStr)] string NewLabel, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

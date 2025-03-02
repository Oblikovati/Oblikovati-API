namespace Oblikovati.API;

public interface BrowserNodeDefinitionSink
{
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

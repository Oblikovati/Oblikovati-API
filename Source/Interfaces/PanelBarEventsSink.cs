namespace Oblikovati.API;

public interface PanelBarEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandBarObject">CommandBarObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnCommandBarSelection([In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBarObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

namespace Oblikovati.API;

public interface DrawingViewEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="ReasonsForChange">ReasonsForChange</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnViewUpdate([In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] CommandTypesEnum ReasonsForChange, [Out] out HandlingCodeEnum HandlingCode);
}

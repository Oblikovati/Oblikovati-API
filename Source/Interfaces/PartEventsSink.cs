namespace Oblikovati.API;

public interface PartEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnSurfaceBodyChanged([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
}

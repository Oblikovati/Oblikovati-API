namespace Oblikovati.API;

public interface ClientOperationEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="OperationName">OperationName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnClientOperation([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string OperationName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

namespace Oblikovati.API;

public interface ClientOperationEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ClientId">ClientId</param>
    /// <param name="OperationName">OperationName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void FireOnClientOperation([In] [MarshalAs(UnmanagedType.BStr)] string ClientId, [In] [MarshalAs(UnmanagedType.BStr)] string OperationName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

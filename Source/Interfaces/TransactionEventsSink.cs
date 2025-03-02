namespace Oblikovati.API;

public interface TransactionEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnCommit([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnUndo([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnRedo([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    [PreserveSig]
    void OnAbort([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    [PreserveSig]
    void OnDelete([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter);
}

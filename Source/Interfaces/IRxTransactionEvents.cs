namespace Oblikovati.API;

public interface IRxTransactionEvents
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnCommit([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnUndo([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    void OnRedo([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    void OnAbort([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] EventTimingEnum BeforeOrAfter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionObject">TransactionObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    void OnDelete([In] [MarshalAs(UnmanagedType.Interface)] Transaction TransactionObject, [In] EventTimingEnum BeforeOrAfter);
}

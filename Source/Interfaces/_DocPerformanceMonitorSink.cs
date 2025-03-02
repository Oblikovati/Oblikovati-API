namespace Oblikovati.API;

public interface _DocPerformanceMonitorSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SegmentName">SegmentName</param>
    void OnSegmentLoad([In] [MarshalAs(UnmanagedType.BStr)] string SegmentName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void OnDatabaseClose();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="OpenedWithFlags">OpenedWithFlags</param>
    void OnIStorageOpen([In] int OpenedWithFlags);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void OnIStorageClose();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    void OnViewUpdate([In] [MarshalAs(UnmanagedType.IDispatch)] object ViewObject, [In] int BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    void OnIdle([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
}

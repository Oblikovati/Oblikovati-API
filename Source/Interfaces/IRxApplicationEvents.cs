namespace Oblikovati.API;

public interface IRxApplicationEvents
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    void OnNewDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    void OnOpenDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    void OnSaveDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    void OnCloseDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    void OnActivateDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    void OnDeactivateDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    void OnNewView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    void OnCloseView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    void OnActivateView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    void OnDeactivateView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void OnQuit();
}

namespace Oblikovati.API;

public interface IRxDocumentEvents
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    void OnSave([In] EventTimingEnum BeforeOrAfter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    void OnClose([In] EventTimingEnum BeforeOrAfter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void OnActivate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void OnDeactivate();
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
}

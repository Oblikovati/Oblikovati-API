namespace Oblikovati.API;

public interface ManipulatorEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedManipulatorElement">SelectedManipulatorElement</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnManipulatorElementSelectionChange([In] ManipulatorElementEnum SelectedManipulatorElement, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedManipulatorElement">SelectedManipulatorElement</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnStartDrag([In] ManipulatorElementEnum SelectedManipulatorElement, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedManipulatorElement">SelectedManipulatorElement</param>
    /// <param name="DragValue">DragValue</param>
    /// <param name="ManipulatorTransform">ManipulatorTransform</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnEndDrag([In] ManipulatorElementEnum SelectedManipulatorElement, [In] [MarshalAs(UnmanagedType.Struct)] object DragValue, [In] [MarshalAs(UnmanagedType.Interface)] Matrix ManipulatorTransform, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedManipulatorElement">SelectedManipulatorElement</param>
    /// <param name="DragValue">DragValue</param>
    /// <param name="ManipulatorTransform">ManipulatorTransform</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDrag([In] ManipulatorElementEnum SelectedManipulatorElement, [In] [MarshalAs(UnmanagedType.Struct)] object DragValue, [In] [MarshalAs(UnmanagedType.Interface)] Matrix ManipulatorTransform, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

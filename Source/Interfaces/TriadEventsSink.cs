namespace Oblikovati.API;

public interface TriadEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivate([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedTriadSegment">SelectedTriadSegment</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="CoordinateSystem">CoordinateSystem</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnEndMove([In] TriadSegmentEnum SelectedTriadSegment, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedTriadSegment">SelectedTriadSegment</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="CoordinateSystem">CoordinateSystem</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMove([In] TriadSegmentEnum SelectedTriadSegment, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cancelled">Cancelled</param>
    /// <param name="CoordinateSystem">CoordinateSystem</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnEndSequence([In] bool Cancelled, [In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CoordinateSystem">CoordinateSystem</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnStartSequence([In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MoveTriadOnly">MoveTriadOnly</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMoveTriadOnlyToggle([In] bool MoveTriadOnly, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedTriadSegment">SelectedTriadSegment</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="CoordinateSystem">CoordinateSystem</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnStartMove([In] TriadSegmentEnum SelectedTriadSegment, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cancelled">Cancelled</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnTerminate([In] bool Cancelled, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedTriadSegment">SelectedTriadSegment</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnSegmentSelectionChange([In] TriadSegmentEnum SelectedTriadSegment, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cancelled">Cancelled</param>
    /// <param name="CoordinateSystem">CoordinateSystem</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnEndSequence2([In] ref bool Cancelled, [In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cancelled">Cancelled</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnTerminate2([In] ref bool Cancelled, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MoveTriadOnly">MoveTriadOnly</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMoveTriadOnlyToggle2([In] ref bool MoveTriadOnly, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

namespace Oblikovati.API;

public interface UserInterfaceEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Environments">Environments</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnResetEnvironments([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator Environments, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandBars">CommandBars</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnResetCommandBars([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator CommandBars, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Environment">Environment</param>
    /// <param name="EnvironmentState">EnvironmentState</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnEnvironmentChange([In] [MarshalAs(UnmanagedType.Interface)] Environment Environment, [In] EnvironmentStateEnum EnvironmentState, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnResetShortcuts([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnResetRibbonInterface([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MarkingMenuInternalName">MarkingMenuInternalName</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnResetMarkingMenu([In] [MarshalAs(UnmanagedType.BStr)] string MarkingMenuInternalName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnResetInventorLayout([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
}

namespace Oblikovati.API;

public interface RepresentationEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Entity">Entity</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDelete([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewDesignViewRepresentation([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] DesignViewRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivateDesignViewRepresentation([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] DesignViewRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewDesignView([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] DesignViewRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivateDesignView([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] DesignViewRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewPositionalRepresentation([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] PositionalRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivatePositionalRepresentation([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] PositionalRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewLevelOfDetailRepresentation([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] LevelOfDetailRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivateLevelOfDetailRepresentation([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] LevelOfDetailRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Representation">Representation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewSectionView([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] DesignViewRepresentation Representation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

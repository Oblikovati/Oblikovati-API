namespace Oblikovati.API;

public interface ModelingEventsSink
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
    /// <param name="Feature">Feature</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewFeature([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] PartFeature Feature, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Feature">Feature</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnFeatureChange([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] PartFeature Feature, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Parameter">Parameter</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewParameter([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Parameter Parameter, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Parameter">Parameter</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnParameterChange([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Parameter Parameter, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Feature">Feature</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnClientFeatureDoubleClick([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] ClientFeature Feature, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Feature">Feature</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnClientFeatureSolve([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] ClientFeature Feature, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FactoryDocumentObject">FactoryDocumentObject</param>
    /// <param name="MemberName">MemberName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnGenerateMember([In] [MarshalAs(UnmanagedType.Interface)] _Document FactoryDocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string MemberName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FactoryDocumentObject">FactoryDocumentObject</param>
    /// <param name="MemberName">MemberName</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnPreGenerateMember([In] [MarshalAs(UnmanagedType.Interface)] _Document FactoryDocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string MemberName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Annotations">Annotations</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnModelAnnotationsSolve([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotations Annotations, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Annotation">Annotation</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnGeneralSurfaceProfileGDTSolve([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] ModelAnnotation Annotation, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnModelAnnotationsScaleChange([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FactoryDocumentObject">FactoryDocumentObject</param>
    /// <param name="MemberName">MemberName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnGenerateModelStateMember([In] [MarshalAs(UnmanagedType.Interface)] _Document FactoryDocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string MemberName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

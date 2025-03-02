namespace Oblikovati.API;

public interface PresentationEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="PublicationObj">PublicationObj</param>
    /// <param name="PublicationMarkedViewObj">PublicationMarkedViewObj</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewPublicationMarkedView([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Publication PublicationObj, [In] [MarshalAs(UnmanagedType.Interface)] PublicationMarkedView PublicationMarkedViewObj, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="PublicationObj">PublicationObj</param>
    /// <param name="pEntity">pEntity</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDelete([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Publication PublicationObj, [In] [MarshalAs(UnmanagedType.IDispatch)] object pEntity, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PublicationObj">PublicationObj</param>
    /// <param name="StoryboardObj">StoryboardObj</param>
    /// <param name="ReasonsForChange">ReasonsForChange</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnStoryboardChange([In] [MarshalAs(UnmanagedType.Interface)] Publication PublicationObj, [In] [MarshalAs(UnmanagedType.Interface)] Storyboard StoryboardObj, [In] CommandTypesEnum ReasonsForChange, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="PublicationObj">PublicationObj</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnPublicationDesignViewChange([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Publication PublicationObj, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="PublicationComponent">PublicationComponent</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnPublicationComponentChange([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] PublicationComponent PublicationComponent, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="PublicationObject">PublicationObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewPublication([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Publication PublicationObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Publication">Publication</param>
    /// <param name="ReasonsForChange">ReasonsForChange</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnPublicationModelingDataUpdate([In] [MarshalAs(UnmanagedType.Interface)] Publication Publication, [In] CommandTypesEnum ReasonsForChange, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="PublicationObj">PublicationObj</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnPublicationNameChange([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Publication PublicationObj, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

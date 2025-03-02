namespace Oblikovati.API;

public interface PublicationEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Publication">Publication</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnModelingDataUpdate([In] [MarshalAs(UnmanagedType.Interface)] _PresentationDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] Publication Publication, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
}

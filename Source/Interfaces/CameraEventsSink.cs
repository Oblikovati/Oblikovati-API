namespace Oblikovati.API;

public interface CameraEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="View">View</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnCameraChange([In] [MarshalAs(UnmanagedType.Interface)] View View, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
}

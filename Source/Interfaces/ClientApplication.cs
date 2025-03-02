namespace Oblikovati.API;

/// <summary>
/// ClientApplication object. Reserved - for future use.
/// </summary>
public interface ClientApplication
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentName">DocumentName</param>
    /// <param name="ControlData">ControlData</param>
    /// <param name="OutputData">OutputData</param>
    /// <param name="Status">Status</param>
    [PreserveSig]
    void GetXMLData([In] [MarshalAs(UnmanagedType.Struct)] object DocumentName, [In] [MarshalAs(UnmanagedType.BStr)] string ControlData, [Out] [MarshalAs(UnmanagedType.BStr)] out string OutputData, [Out] [MarshalAs(UnmanagedType.BStr)] out string Status);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentName">DocumentName</param>
    /// <param name="ControlData">ControlData</param>
    /// <param name="InputData">InputData</param>
    /// <param name="Status">Status</param>
    [PreserveSig]
    void PutXMLData([In] [MarshalAs(UnmanagedType.Struct)] object DocumentName, [In] [MarshalAs(UnmanagedType.BStr)] string ControlData, [In] [MarshalAs(UnmanagedType.BStr)] string InputData, [Out] [MarshalAs(UnmanagedType.BStr)] out string Status);
}

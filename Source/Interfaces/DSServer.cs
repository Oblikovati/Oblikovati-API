namespace Oblikovati.API;

/// <summary>
/// DSServer object.
/// </summary>
public interface DSServer
{
    /// <summary>
    /// Returns the DynamicSimulations associated with the provided Oblikovati part or assembly component definition.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DynamicSimulations GetDynamicSimulations([In] [MarshalAs(UnmanagedType.Interface)] ComponentDefinition ComponentDefinition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentName">DocumentName</param>
    /// <param name="ControlData">ControlData</param>
    /// <param name="OutputData">OutputData</param>
    /// <param name="Status">Status</param>
    [PreserveSig]
    void GetXMLData([In] [MarshalAs(UnmanagedType.Struct)] object DocumentName, [In] [MarshalAs(UnmanagedType.BStr)] string ControlData, [Out] [MarshalAs(UnmanagedType.BStr)] out string OutputData, [Out] [MarshalAs(UnmanagedType.BStr)] out string Status);
}

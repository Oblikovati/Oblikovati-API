namespace Oblikovati.API;

public interface CustomDataEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="CustomData">CustomData</param>
    [PreserveSig]
    void OnRequestCustomData([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap CustomData);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="CustomData">CustomData</param>
    [PreserveSig]
    void OnExecuteCustomAction([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap CustomData);
}

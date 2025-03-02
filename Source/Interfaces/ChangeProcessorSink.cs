namespace Oblikovati.API;

public interface ChangeProcessorSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="Context">Context</param>
    /// <param name="Succeeded">Succeeded</param>
    [PreserveSig]
    void OnExecute([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] [Out] ref bool Succeeded);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="Inputs">Inputs</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnReadFromScript([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.BStr)] string Inputs, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="Context">Context</param>
    /// <param name="ResultInputs">ResultInputs</param>
    [PreserveSig]
    void OnWriteToScript([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] [MarshalAs(UnmanagedType.BStr)] out string ResultInputs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void OnTerminate();
}

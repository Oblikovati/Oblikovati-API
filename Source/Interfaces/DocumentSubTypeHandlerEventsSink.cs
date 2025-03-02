namespace Oblikovati.API;

public interface DocumentSubTypeHandlerEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ConvertToSubType">ConvertToSubType</param>
    /// <param name="Document">Document</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnChangeType([In] bool ConvertToSubType, [In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

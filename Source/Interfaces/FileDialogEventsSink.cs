namespace Oblikovati.API;

public interface FileDialogEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnOptions([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}

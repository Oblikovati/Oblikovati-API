namespace Oblikovati.API;

public interface ProjectOptionsButtonSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnClick([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
}

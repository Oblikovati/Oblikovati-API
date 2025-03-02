namespace Oblikovati.API;

public interface BalloonTipSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnClick([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cancel">Cancel</param>
    [PreserveSig]
    void OnDisplay([Out] out bool Cancel);
}

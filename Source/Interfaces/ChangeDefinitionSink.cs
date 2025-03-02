namespace Oblikovati.API;

public interface ChangeDefinitionSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="ResultProcessor">ResultProcessor</param>
    [PreserveSig]
    void OnReplay([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] [MarshalAs(UnmanagedType.Interface)] out ChangeProcessor ResultProcessor);
}

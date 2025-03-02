namespace Oblikovati.API;

public interface _AssemblySolverNodeSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    [PreserveSig]
    void OnSolve([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter);
}

namespace Oblikovati.API;

public interface DebugInstrumentationObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ObjectDescription { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Object { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ObjectReferenceCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ObjectInstanceNumber { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DebugWatchType ObjectWatchType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookies">Cookies</param>
    [PreserveSig]
    void GetLiveObjects([Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] Cookies);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Object">Object</param>
    [PreserveSig]
    int GetObjectCookie([In] [MarshalAs(UnmanagedType.IUnknown)] object Object);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Enable">Enable</param>
    /// <param name="TraceFilename">TraceFilename</param>
    [PreserveSig]
    void SetTrace([In] bool? Enable = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TraceFilename = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Enabled">Enabled</param>
    /// <param name="TraceFilename">TraceFilename</param>
    [PreserveSig]
    void GetTraceInfo([Out] out bool Enabled, [Out] [MarshalAs(UnmanagedType.BStr)] out string TraceFilename);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Enable">Enable</param>
    /// <param name="WriteToFileOnStop">WriteToFileOnStop</param>
    /// <param name="FileName">FileName</param>
    [PreserveSig]
    void SetProfileInfo([In] bool Enable, [In] bool? WriteToFileOnStop = true, [In] [MarshalAs(UnmanagedType.BStr)] string? FileName = "");
}

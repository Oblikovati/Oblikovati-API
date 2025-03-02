namespace Oblikovati.API;

public interface _DocPerformanceMonitorObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int SegmentCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _SegPerformanceMonitor SegmentItem { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int NodeCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ASMHistoryMemory { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool LeakDetected { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NumberOfLODs">NumberOfLODs</param>
    /// <param name="LODTolerances">LODTolerances</param>
    [PreserveSig]
    void GetGraphicsLOD([Out] out int NumberOfLODs, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] LODTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NumberOfLODs">NumberOfLODs</param>
    [PreserveSig]
    void SetGraphicsLOD([In] int NumberOfLODs);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Committed">Committed</param>
    /// <param name="Reserved">Reserved</param>
    /// <param name="InActiveUse">InActiveUse</param>
    [PreserveSig]
    void GetMemoryInUse([Out] out int Committed, [Out] out int Reserved, [Out] out int InActiveUse);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="detect">detect</param>
    [PreserveSig]
    void SetDetectLeaks([In] bool detect);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="dontSave">dontSave</param>
    [PreserveSig]
    void DontSaveIdentifiedMTLeaks([In] bool dontSave);
}

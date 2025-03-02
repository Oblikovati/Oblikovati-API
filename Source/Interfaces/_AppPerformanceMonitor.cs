namespace Oblikovati.API;

public interface _AppPerformanceMonitor
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AllMemoryInUse { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ASMActiveEntityMemory { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ASMHistoryMemory { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool StatsActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Committed">Committed</param>
    /// <param name="Reserved">Reserved</param>
    [PreserveSig]
    void GetMemoryInUse([Out] out int Committed, [Out] out int Reserved);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LODTolerances">LODTolerances</param>
    [PreserveSig]
    void SetGraphicsLOD([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] LODTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Allocations">Allocations</param>
    /// <param name="DeAllocations">DeAllocations</param>
    /// <param name="BytesAllocated">BytesAllocated</param>
    /// <param name="HighWaterMark">HighWaterMark</param>
    [PreserveSig]
    void GetASMMemoryTotals([Out] out long Allocations, [Out] out long DeAllocations, [Out] out int BytesAllocated, [Out] out int HighWaterMark);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Blocks">Blocks</param>
    /// <param name="EmptyBlocks">EmptyBlocks</param>
    /// <param name="TotalBytes">TotalBytes</param>
    /// <param name="AllocatedBytes">AllocatedBytes</param>
    [PreserveSig]
    void GetASMFreeListMemory([Out] out int Blocks, [Out] out int EmptyBlocks, [Out] out int TotalBytes, [Out] out int AllocatedBytes);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Gross">Gross</param>
    /// <param name="Capacity">Capacity</param>
    /// <param name="Theoretical">Theoretical</param>
    [PreserveSig]
    void GetASMMemoryUtilizationRatios([Out] out double Gross, [Out] out double Capacity, [Out] out double Theoretical);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void InitStats();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TimerName">TimerName</param>
    [PreserveSig]
    void StartTimer([In] [MarshalAs(UnmanagedType.BStr)] string TimerName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TimerName">TimerName</param>
    [PreserveSig]
    void LogElapsedTime([In] [MarshalAs(UnmanagedType.BStr)] string TimerName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MemStatName">MemStatName</param>
    [PreserveSig]
    void LogMemoryStatistics([In] [MarshalAs(UnmanagedType.BStr)] string MemStatName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    string OutputMetrics();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TimerName">TimerName</param>
    /// <param name="ElapsedTime">ElapsedTime</param>
    [PreserveSig]
    void OutputElapsedTime([In] [MarshalAs(UnmanagedType.BStr)] string TimerName, [Out] out int ElapsedTime);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntryName">EntryName</param>
    /// <param name="CommittedMem">CommittedMem</param>
    /// <param name="ReservedMem">ReservedMem</param>
    /// <param name="WastedMem">WastedMem</param>
    [PreserveSig]
    void OutputMemoryStatistics([In] [MarshalAs(UnmanagedType.BStr)] string EntryName, [Out] [MarshalAs(UnmanagedType.BStr)] out string CommittedMem, [Out] [MarshalAs(UnmanagedType.BStr)] out string ReservedMem, [Out] [MarshalAs(UnmanagedType.BStr)] out string WastedMem);
}

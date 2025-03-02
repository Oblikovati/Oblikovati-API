namespace Oblikovati.API;

public interface _SegPerformanceMonitor
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _SegmentLoadState State { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Committed">Committed</param>
    /// <param name="Reserved">Reserved</param>
    /// <param name="RSeManagement">RSeManagement</param>
    [PreserveSig]
    void GetMemoryInUse([Out] out int Committed, [Out] out int Reserved, [Out] out int RSeManagement);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Committed">Committed</param>
    /// <param name="Reserved">Reserved</param>
    /// <param name="RSeManagement">RSeManagement</param>
    [PreserveSig]
    void GetMemoryInUseFor64Bit([Out] out long Committed, [Out] out long Reserved, [Out] out long RSeManagement);
}

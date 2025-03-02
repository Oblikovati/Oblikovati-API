namespace Oblikovati.API;

public interface TriadEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InteractionEvents Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    TriadSegmentEnum DegreesOfFreedom { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Matrix GlobalTransform { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MoveTriadOnly { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MoveTriadOnlyEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Repeat { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsInRedefineMode { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TriadSegment">TriadSegment</param>
    /// <param name="AlignWith">AlignWith</param>
    [PreserveSig]
    void Reposition([In] TriadSegmentEnum TriadSegment, [In] [MarshalAs(UnmanagedType.IDispatch)] object AlignWith);
}

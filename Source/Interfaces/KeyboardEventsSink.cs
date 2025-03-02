namespace Oblikovati.API;

public interface KeyboardEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Key">Key</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    [PreserveSig]
    void OnKeyDown([In] int Key, [In] ShiftStateEnum ShiftKeys);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Key">Key</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    [PreserveSig]
    void OnKeyUp([In] int Key, [In] ShiftStateEnum ShiftKeys);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="KeyASCII">KeyASCII</param>
    [PreserveSig]
    void OnKeyPress([In] int KeyASCII);
}

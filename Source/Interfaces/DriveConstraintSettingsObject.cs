namespace Oblikovati.API;

public interface DriveConstraintSettingsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CollisionDetection { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DriveAdaptivity { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string EndValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int FrameRate { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AssemblyConstraint Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double PauseDelay { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int RepetitionCount { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool RepetitionStartEndStart { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string StartValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsInitialized { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="IncrementType">IncrementType</param>
    /// <param name="Increment">Increment</param>
    [PreserveSig]
    void GetIncrement([Out] out ConstraintIncrementTypeEnum IncrementType, [Out] [MarshalAs(UnmanagedType.BStr)] out string Increment);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void GoToStart();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void GoToEnd();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void PlayForward();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void PlayReverse();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="IncrementType">IncrementType</param>
    /// <param name="Increment">Increment</param>
    [PreserveSig]
    void SetIncrement([In] ConstraintIncrementTypeEnum IncrementType, [In] [MarshalAs(UnmanagedType.BStr)] string Increment);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="Compressor">Compressor</param>
    /// <param name="CompressionQuality">CompressionQuality</param>
    /// <param name="MoreOptions">MoreOptions</param>
    [PreserveSig]
    void StartAVIRecording([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string? Compressor = "", [In] int? CompressionQuality = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MoreOptions = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="NetworkBandwidth">NetworkBandwidth</param>
    /// <param name="ImageWidth">ImageWidth</param>
    /// <param name="ImageHeight">ImageHeight</param>
    /// <param name="AddMarkers">AddMarkers</param>
    /// <param name="MoreOptions">MoreOptions</param>
    [PreserveSig]
    void StartWMVRecording([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] int? NetworkBandwidth = default, [In] int? ImageWidth = default, [In] int? ImageHeight = default, [In] bool? AddMarkers = false, [In] [MarshalAs(UnmanagedType.Struct)] object? MoreOptions = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void StepForward();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void StepReverse();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void StopRecording();
}

namespace Oblikovati.API;

/// <summary>
/// MoldSplitResult Object.
/// </summary>
public interface MoldSplitResult
{
    /// <summary>
    /// Gets the status of the mold analysis.
    /// </summary>
    int Status { get; }
    /// <summary>
    /// Gets the number of notes associated with this result.
    /// </summary>
    int NoteCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NoteIndex">NoteIndex</param>
    /// <param name="NoteType">NoteType</param>
    /// <param name="Entities">Entities</param>
    [PreserveSig]
    void _GetNote([In] int NoteIndex, [Out] out int NoteType, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator Entities);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NoteIndex">NoteIndex</param>
    /// <param name="NoteType">NoteType</param>
    /// <param name="Entities">Entities</param>
    /// <param name="Value">Value</param>
    /// <param name="ErrorMessage">ErrorMessage</param>
    [PreserveSig]
    void GetNote([In] int NoteIndex, [Out] out int NoteType, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator Entities, [Out] out double Value, [Out] [MarshalAs(UnmanagedType.BStr)] out string ErrorMessage);
}

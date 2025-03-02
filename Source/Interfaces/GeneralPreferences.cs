namespace Oblikovati.API;

/// <summary>
/// The GeneralPreferences object provides the ability to store information about users' preferences, such as what template directory to use when creating new files, whether the Multi-User facility is on or off, etc.
/// </summary>
public interface GeneralPreferences
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MultiUsersEnabled { get; set; }
    /// <summary>
    /// Property that indicates the directory from which Autodesk Inventor will present the templates for use in its File New command.
    /// </summary>
    string TemplateDir { get; set; }
    /// <summary>
    /// Property that indicates the Boolean flag indicating whether to defer update or not.
    /// </summary>
    bool DeferUpdate { get; set; }
    /// <summary>
    /// Property that indicates a constant indicating the Multi-User mode.
    /// </summary>
    MultiUserModeEnum MultiUserMode { get; set; }
    /// <summary>
    /// Property that indicates the Boolean flag indicating whether Multi-User facility is managed by Autodesk Inventor or not.
    /// </summary>
    bool MultiUserExternallyManaged { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _NumberOfVersionsKept { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="NumVersionsToKeep">NumVersionsToKeep</param>
    [PreserveSig]
    void _MinimizeFileSize([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] int NumVersionsToKeep);
}

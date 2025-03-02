namespace Oblikovati.API;

/// <summary>
/// LibraryManager Object.
/// </summary>
public interface LibraryManager
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="EnumerationOnly">EnumerationOnly</param>
    [PreserveSig]
    string GetServerLibraries([In] [MarshalAs(UnmanagedType.BStr)] string? LibraryId = "", [In] bool? EnumerationOnly = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LibraryId">LibraryId</param>
    /// <param name="Language">Language</param>
    /// <param name="EnumerationOnly">EnumerationOnly</param>
    [PreserveSig]
    string GetLibraryStrings([In] [MarshalAs(UnmanagedType.BStr)] string LibraryId, [In] [MarshalAs(UnmanagedType.BStr)] string? Language = "", [In] bool? EnumerationOnly = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LibraryIds">LibraryIds</param>
    [PreserveSig]
    string[,] GetLibraryIcons([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] LibraryIds);
}

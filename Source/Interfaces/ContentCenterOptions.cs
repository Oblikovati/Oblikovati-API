namespace Oblikovati.API;

/// <summary>
/// The ContentCenterOptions object provides access to properties that provide read and write access of the content center related application options.
/// </summary>
public interface ContentCenterOptions
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets/sets whether to automatically refresh out of date standard parts during placement.
    /// </summary>
    bool RefreshOutOfDateStandardParts { get; set; }
    /// <summary>
    /// Gets/sets whether to place Family with custom's columns As Standard or As Custom.
    /// </summary>
    bool CustomFamilyAsStandard { get; set; }
    /// <summary>
    /// Gets/sets how to handle linked families - check/do not check for parent version.
    /// </summary>
    bool CheckFamiliesUpdates { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ContentCenterDecimalMarkerOptionEnum FilenameDecimalMarker { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AccessOption">AccessOption</param>
    /// <param name="LibrariesLocation">LibrariesLocation</param>
    [PreserveSig]
    void GetAccessOption([Out] out ContentCenterAccessOptionEnum AccessOption, [Out] [MarshalAs(UnmanagedType.BStr)] out string LibrariesLocation);
    /// <summary>
    /// Method that sets the access option for content center (Oblikovati Desktop or Vault/Productstream).
    /// </summary>
    /// <param name="AccessOption">Input ContentCenterAccessOptionEnum value that specifies the access option for content center. This can either be kInventorDesktopAccess or kVaultOrProductstreamServerAccess. If kInventorDesktopAccess is input, the LibrariesLocation argument must be specified.</param>
    /// <param name="LibrariesLocation">Optional input String that specifies the location of the libraries if the access option is kInventorDesktopAccess. The argument must be specified for kInventorDesktopAccess, and can be ignored for kVaultOrProductstreamServerAccess.</param>
    [PreserveSig]
    void SetAccessOption([In] ContentCenterAccessOptionEnum AccessOption, [In] [MarshalAs(UnmanagedType.BStr)] string? LibrariesLocation = "");
}

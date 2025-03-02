namespace Oblikovati.API;

/// <summary>
/// The BOM object represents the Bill Of Materials (BOM) data of a document.
/// </summary>
public interface BOM
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
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the GUID that represents the last saved revision of this BOM.
    /// </summary>
    string RevisionId { get; }
    /// <summary>
    /// Property that gets the BOMViews collection object.
    /// </summary>
    BOMViews BOMViews { get; }
    /// <summary>
    /// Gets and sets whether the parts only BOM view is enabled.
    /// </summary>
    bool PartsOnlyViewEnabled { get; set; }
    /// <summary>
    /// Determines whether the BOM requires an update.
    /// </summary>
    bool RequiresUpdate { get; }
    /// <summary>
    /// Gets and sets whether the structured BOM view is enabled.
    /// </summary>
    bool StructuredViewEnabled { get; set; }
    /// <summary>
    /// Gets and sets whether the structured view is an 'all-level' or a 'first level only' view.
    /// </summary>
    bool StructuredViewFirstLevelOnly { get; set; }
    /// <summary>
    /// Gets and sets the delimiter to use for numbering.&nbsp;This property applies only for an all-level structured view.
    /// </summary>
    string StructuredViewDelimiter { get; set; }
    /// <summary>
    /// Gets and sets the minimum number of digits displayed in a 'first level only' structured view.
    /// </summary>
    int StructuredViewMinimumDigits { get; set; }
    /// <summary>
    /// gets and sets the numbering scheme for a 'Parts Only' view.
    /// </summary>
    NumberingSchemeEnum PartsOnlyViewNumberingScheme { get; set; }
    /// <summary>
    /// Gets and sets the minimum number of digits displayed in a parts only view with the PartsOnlyViewNumberingScheme set to kNumericNumbering.
    /// </summary>
    int PartsOnlyViewMinimumDigits { get; set; }
    /// <summary>
    /// Gets and sets whether to hide the suppressed components in BOM.
    /// </summary>
    bool HideSuppressedComponentsInBOM { get; set; }
    /// <summary>
    /// Gets and sets whether to renumber the items sequentially or not.
    /// </summary>
    bool RenumberItemsSequentially { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MergeEnabled">MergeEnabled</param>
    /// <param name="MergeExcludeList">MergeExcludeList</param>
    [PreserveSig]
    void GetPartNumberMergeSettings([Out] out bool MergeEnabled, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] MergeExcludeList);
    /// <summary>
    /// Method that sets the part number row merge settings for the BOM.
    /// </summary>
    /// <param name="MergeEnabled">Boolean that indicates whether the row merging based on part number match is enabled.</param>
    /// <param name="MergeKeys">Optional input array that contains the strings to exclude when merging based on part number match. If supplied, this array should contain a minimum of one string ('').</param>
    [PreserveSig]
    void SetPartNumberMergeSettings([In] bool MergeEnabled, [In] [MarshalAs(UnmanagedType.Struct)] object? MergeKeys = default);
    /// <summary>
    /// Import BOM column customization as XML file.
    /// </summary>
    /// <param name="FileName">Input String that defines the name of an existing xml file that contains BOM customization information.</param>
    [PreserveSig]
    void ImportBOMCustomization([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Export BOM column customization as XML file.
    /// </summary>
    /// <param name="FileName">Input String that defines the name of the xml file to write the BOM customization information to.</param>
    [PreserveSig]
    void ExportBOMCustomization([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MergeEnabled">MergeEnabled</param>
    /// <param name="MergeExcludeList">MergeExcludeList</param>
    /// <param name="MergeInstanceRows">MergeInstanceRows</param>
    [PreserveSig]
    void GetPartNumberMergeSettings2([Out] out bool MergeEnabled, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] MergeExcludeList, [Out] out bool MergeInstanceRows);
    /// <summary>
    /// Sets the part number row merge settings for the BOM.
    /// </summary>
    /// <param name="MergeEnabled">Input Boolean that indicates whether the row merging based on part number match is enabled.</param>
    /// <param name="MergeKeys">Optional input array that contains the strings to exclude when merging based on part number match.  If supplied, this array should contain a minimum of one string (“<BLANK>”).</param>
    /// <param name="MergeInstanceRows">Output Boolean that indicates whether the merge instance rows is enabled or not.</param>
    [PreserveSig]
    void SetPartNumberMergeSettings2([In] bool MergeEnabled, [In] [MarshalAs(UnmanagedType.Struct)] object? MergeKeys = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MergeInstanceRows = default);
}

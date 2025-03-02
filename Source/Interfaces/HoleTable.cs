namespace Oblikovati.API;

/// <summary>
/// A hole table contains information for some or all holes in a drawing view. A hole tag is associated with each hole and a corresponding row in the table. If an existing hole is changed, the hole table is updated when the drawing updates.
/// </summary>
public interface HoleTable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object of this HoleTable.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/Sets the title of the HoleTable.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets/Sets the placement position of the HoleTable heading.
    /// </summary>
    HeadingPlacementEnum HeadingPlacement { get; set; }
    /// <summary>
    /// Gets/Sets the position of the HoleTable on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that returns the HoleTableColumns collection object.
    /// </summary>
    HoleTableColumns HoleTableColumns { get; }
    /// <summary>
    /// Property that returns the HoleTableRows collection object.
    /// </summary>
    HoleTableRows HoleTableRows { get; }
    /// <summary>
    /// Gets and sets the layer used by the HoleTable.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns the type of the hole table.
    /// </summary>
    HoleTableTypeEnum HoleTableType { get; }
    /// <summary>
    /// Property that returns the drawing view that this table is associated with.
    /// </summary>
    DrawingView ParentView { get; }
    /// <summary>
    /// Gets/Sets the associated HoleTableStyle object.
    /// </summary>
    HoleTableStyle Style { get; set; }
    /// <summary>
    /// Gets/Sets the text style used for the title of the table.
    /// </summary>
    TextStyle TitleTextStyle { get; set; }
    /// <summary>
    /// Gets/Sets the text style used for the column titles (headers).
    /// </summary>
    TextStyle ColumnHeaderTextStyle { get; set; }
    /// <summary>
    /// Gets/Sets the text style used for the contents of the table.
    /// </summary>
    TextStyle DataTextStyle { get; set; }
    /// <summary>
    /// Gets/Sets whether to preserve the hole tags assigned when the table is created.
    /// </summary>
    bool PreserveTagging { get; set; }
    /// <summary>
    /// Gets/Sets whether to group and tag holes by type.
    /// </summary>
    bool GroupHoleTypes { get; set; }
    /// <summary>
    /// Gets/Sets whether to tags holes relative to their position on the selected view or by their relative size.
    /// </summary>
    bool ArrangeByPosition { get; set; }
    /// <summary>
    /// Gets/Sets the row merge option for the hole table.
    /// </summary>
    RowMergeTypeEnum RowMergeType { get; set; }
    /// <summary>
    /// Gets/Sets whether to re-index the hole tags and resort contents when a Match Custom Hole operation is done.
    /// </summary>
    bool ReformatOnCustomHoleMatch { get; set; }
    /// <summary>
    /// Gets/Sets whether to replace the alphanumeric hole tags with sequential numbering of the holes in the hole table.
    /// </summary>
    bool SequentialNumbering { get; set; }
    /// <summary>
    /// Gets/Sets whether to delete tags except for the first in a series of hole tags when the row merge type is kRollupRowMerge.
    /// </summary>
    bool DeleteTagsOnRollup { get; set; }
    /// <summary>
    /// Gets/Sets whether to include a secondary numeric tag when the row merge type is kRollupRowMerge.
    /// </summary>
    bool SecondaryTagModifierOnRollup { get; set; }
    /// <summary>
    /// Gets/Sets whether to include hole features.
    /// </summary>
    bool IncludeHoleFeatures { get; set; }
    /// <summary>
    /// Gets/Sets whether to include extruded cuts.
    /// </summary>
    bool IncludeCircularCuts { get; set; }
    /// <summary>
    /// Gets/Sets whether to include center marks.
    /// </summary>
    bool IncludeCentermarks { get; set; }
    /// <summary>
    /// Gets/Sets whether to include recovered punch center marks.
    /// </summary>
    bool IncludeRecoveredPunchCenters { get; set; }
    /// <summary>
    /// Gets/Sets whether to include drilled hole features.
    /// </summary>
    bool IncludeDrilledHoleFeatures { get; set; }
    /// <summary>
    /// Gets/Sets whether to include counterbored hole features.
    /// </summary>
    bool IncludeCounterBoreHoleFeatures { get; set; }
    /// <summary>
    /// Gets/Sets whether to include countersunk hole features.
    /// </summary>
    bool IncludeCounterSinkHoleFeatures { get; set; }
    /// <summary>
    /// Gets/Sets whether to include threaded hole features.
    /// </summary>
    bool IncludeThreadedHoleFeatures { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets and sets whether to show the title of the hole table.
    /// </summary>
    bool ShowTitle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the HoleTable.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Property that indicates whether to show or hide all the hole tags associated with this table.
    /// </summary>
    /// <param name="Value">When set to True, show all the hole tags associated with this table.</param>
    [PreserveSig]
    void ShowTags([In] bool Value);
    /// <summary>
    /// Method that specifies two or more custom holes (designated with center marks) to be the same.
    /// </summary>
    /// <param name="HoleTags">Input ObjectCollection containing HoleTag objects that represent center marks. All the hole tags are matched to the first hole tag in the collection. The method returns an error if any of the input hole tags do not represent a center mark.</param>
    [PreserveSig]
    void MatchCustomHoles([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection HoleTags);
    /// <summary>
    /// Method that saves the custom table to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the table to. The valid file extension for this file are .csv and .txt.</param>
    /// <param name="FileFormat">Input FileFormatEnum to specify the file format to export. Valid values for export hole tables are:kTextFileCommaDelimitedFormat, kTextFileTabDelimitedFormat, kUnicodeTextFileCommaDelimitedFormat and kUnicodeTextFileTabDelimitedFormat.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export. See Remarks for valid inputs:</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}

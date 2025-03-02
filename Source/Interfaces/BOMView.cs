namespace Oblikovati.API;

/// <summary>
/// The BOMView object represents a view (or an ordering scheme) of the BOM.
/// </summary>
public interface BOMView
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
    /// Property that returns the parent BOM object.
    /// </summary>
    BOM Parent { get; }
    /// <summary>
    /// Property that returns the GUID that represents the last saved revision of this BOMView.
    /// </summary>
    string RevisionId { get; }
    /// <summary>
    /// Property that gets the name of the BOMView.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Property that gets the BOMRows enumerator object containing the top level BOM rows.
    /// </summary>
    BOMRowsEnumerator BOMRows { get; }
    /// <summary>
    /// Property that returns the BOM View type. Possible return values are kModelDataBOMViewType (for the 'raw' view), kStructuredBOMViewType (for the structured view) and kPartsOnlyBOMViewType (for the parts-only view).
    /// </summary>
    BOMViewTypeEnum ViewType { get; }
    /// <summary>
    /// Gets and sets the name of the iAssembly member that the BOM view is based on.
    /// </summary>
    string iAssemblyMemberName { get; set; }
    /// <summary>
    /// Gets the name of the model state member that the BOM view is based on.
    /// </summary>
    string ModelStateMemberName { get; }
    /// <summary>
    /// Method that saves the BOM as viewed in this BOM view to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the BOM to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input String that specifies the 'Table Name' for kMicrosoftExcel file formats. This is the name of the Excel sheet. If not provided, the name of the file is used as the sheet name. For other formats, this argument is ignored.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Method that renumbers all rows in the BOM view. If the BOMRowsToRenumber argument is provided, only those rows are renumbered. Applies only to structured and parts only views. This method returns a failure for the model data BOM view.
    /// </summary>
    /// <param name="StartValue">Optional input long that specifies the start value for renumbering. If not specified, this value defaults to 1.</param>
    /// <param name="Increment">Optional input long that specifies the increment to use for renumbering. If not specified, this value defaults to 1.</param>
    /// <param name="BOMRowsToRenumber">Optional input ObjectCollection of BOMRow objects. If not supplied, all rows in the BOMView are renumbered. If provided, only the input rows are renumbered.</param>
    [PreserveSig]
    void Renumber([In] int? StartValue = default, [In] int? Increment = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BOMRowsToRenumber = default);
    /// <summary>
    /// Method that changes the sort order of items in the BOM view. Applies only to structured and parts only views. This method returns a failure for the model data BOM view.
    /// </summary>
    /// <param name="PrimaryColumnTitle">Input string that specifies the primary column to use for the sorting. If the name of a non-existing column is provided, an error occurs.</param>
    /// <param name="PrimaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="SecondaryColumnTitle">Optional input string that specifies the secondary column to use for the sorting. If the name of a non-existing column or the primary column is provided, an error occurs.</param>
    /// <param name="SecondaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="TertiaryColumnTitle">Optional input string that specifies the tertiary column to use for the sorting. If the name of a non-existing column, the primary column or the secondary column is provided, an error occurs.</param>
    /// <param name="TertiaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    [PreserveSig]
    void Sort([In] [MarshalAs(UnmanagedType.BStr)] string PrimaryColumnTitle, [In] bool? PrimaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? SecondaryColumnTitle = "", [In] bool? SecondaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TertiaryColumnTitle = "", [In] bool? TertiaryColumnAscending = true);
    /// <summary>
    /// Method that changes the sort order of items in the BOM view. Applies only to structured and parts only views. This method returns a failure for the model data BOM view.
    /// </summary>
    /// <param name="PrimaryColumnTitle">Input string that specifies the primary column to use for the sorting. If the name of a non-existing column is provided, an error occurs.</param>
    /// <param name="PrimaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="SecondaryColumnTitle">Optional input string that specifies the secondary column to use for the sorting. If the name of a non-existing column or the primary column is provided, an error occurs.</param>
    /// <param name="SecondaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="TertiaryColumnTitle">Optional input string that specifies the tertiary column to use for the sorting. If the name of a non-existing column, the primary column or the secondary column is provided, an error occurs.</param>
    /// <param name="TertiaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="SortByString">Optional input Boolean that specifies whether to sort the columns by string. This defaults to False to indicate the columns are sorted numerically.</param>
    [PreserveSig]
    void Sort2([In] [MarshalAs(UnmanagedType.BStr)] string PrimaryColumnTitle, [In] bool? PrimaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? SecondaryColumnTitle = "", [In] bool? SecondaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TertiaryColumnTitle = "", [In] bool? TertiaryColumnAscending = true, [In] bool? SortByString = true);
}

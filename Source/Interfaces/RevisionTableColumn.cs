namespace Oblikovati.API;

/// <summary>
/// This object represent a column in the revision table.
/// </summary>
public interface RevisionTableColumn
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
    /// Property that returns the parent RevisionTable.
    /// </summary>
    RevisionTable Parent { get; }
    /// <summary>
    /// Specifies the title of the column.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Specifies the width of the column.
    /// </summary>
    double Width { get; set; }
    /// <summary>
    /// Specifies the horizontal justification of the column title.
    /// </summary>
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    /// <summary>
    /// Specifies the horizontal justification of the column values.
    /// </summary>
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    /// <summary>
    /// Read-only property that returns the name of the custom property associated with this column.
    /// </summary>
    string CustomPropertyName { get; }
    /// <summary>
    /// Read-only property that returns the property type associated with this column.
    /// </summary>
    RevisionTablePropertyEnum PropertyType { get; }
    /// <summary>
    /// Method that deletes the RevisionTable.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropertySetId">PropertySetId</param>
    /// <param name="PropId">PropId</param>
    [PreserveSig]
    void GetFilePropertyId([Out] [MarshalAs(UnmanagedType.BStr)] out string PropertySetId, [Out] out int PropId);
    /// <summary>
    /// Method that repositions the column within the revision table.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing column next to which the column will be inserted.  The valid range of values is 0 to the number of existing columns in the table.  The position remains unchanged if the index of the column being moved is specified.  A value of 0 will put the column at the end.  If not specified, a default value of 0 is used, indicating that the column will be moved to the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the column should be inserted before or after the target index.  If not specified, a default value of True is used indicating that the column will be inserted before the target index.  This argument is ignored if the value of TargetIndex is 0.</param>
    [PreserveSig]
    void Reposition([In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}

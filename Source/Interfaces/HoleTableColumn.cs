namespace Oblikovati.API;

/// <summary>
/// The HoleTableColumn object defines a column within the hole table, including the column width.
/// </summary>
public interface HoleTableColumn
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
    /// Property that returns the parent HoleTable.
    /// </summary>
    HoleTable Parent { get; }
    /// <summary>
    /// Specifies the title of the HoleTable column.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets/Sets the width of the HoleTable column.
    /// </summary>
    double Width { get; set; }
    /// <summary>
    /// Property that returns the property type associated with this column.
    /// </summary>
    HolePropertyEnum PropertyType { get; }
    /// <summary>
    /// Property that returns the name of the custom property associated with this column.
    /// </summary>
    string CustomPropertyName { get; }
    /// <summary>
    /// Gets the units formatting of the column.
    /// </summary>
    UnitsFormatting UnitsFormatting { get; }
    /// <summary>
    /// Method that deletes the column from the table.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that repositions the column within the table.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing column next to which the column will be inserted. The valid range of values is 0 to the number of existing columns in the table. The position remains unchanged if the index of the column being moved is specified. A value of 0 will put the column at the end. If not specified, a default value of 0 is used, indicating that the column will be moved to the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the column should be inserted before or after the target index. If not specified, a default value of True is used indicating that the column will be inserted before the target index. This argument is ignored if the value of TargetIndex is 0.</param>
    [PreserveSig]
    void Reposition([In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}

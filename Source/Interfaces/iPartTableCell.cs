namespace Oblikovati.API;

/// <summary>
/// The iPartTableCell object represents an individual cell in the iPart factory table.
/// </summary>
public interface iPartTableCell
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
    /// Property that returns the parent iPartTableRow object.
    /// </summary>
    iPartFactory Parent { get; }
    /// <summary>
    /// Gets and sets the value of the cell.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Property that returns the index of this cell within the parent iPartTableRow.
    /// </summary>
    int Row { get; }
    /// <summary>
    /// Property that returns the index of this cell within the parent iPartTableColumn.
    /// </summary>
    int Column { get; }
    /// <summary>
    /// Property that returns whether a formula (equation) was input into this cell via Excel. Such cells show with a red background in the user interface and are not editable.
    /// </summary>
    bool HasFormula { get; }
    /// <summary>
    /// Property that returns whether the contents of this cell are valid. Invalid cells show with a yellow background in the user interface.
    /// </summary>
    bool IsValid { get; }
    /// <summary>
    /// Gets and sets whether this is a custom parameter cell.
    /// </summary>
    bool CustomCell { get; set; }
    /// <summary>
    /// Gets and sets the increment value for custom parameter cell.
    /// </summary>
    string CustomIncrement { get; set; }
    /// <summary>
    /// Gets and sets the maximum value for a custom parameter.
    /// </summary>
    string CustomRangeMaximum { get; set; }
    /// <summary>
    /// Gets and sets the minimum value for a custom parameter.
    /// </summary>
    string CustomRangeMinimum { get; set; }
}

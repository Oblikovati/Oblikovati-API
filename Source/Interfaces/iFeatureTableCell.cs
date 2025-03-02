namespace Oblikovati.API;

/// <summary>
/// The iFeatureTableCell object represents a single cell within a table associated with a table driven iFeature.
/// </summary>
public interface iFeatureTableCell
{
    /// <summary>
    /// Property that returns the parent iFeatureTable.
    /// </summary>
    iFeatureTable Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the column this cell is within.
    /// </summary>
    iFeatureTableColumn Column { get; }
    /// <summary>
    /// Property that returns the row this cell is within.
    /// </summary>
    iFeatureTableRow Row { get; }
    /// <summary>
    /// Gets and sets the value of the cell.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Gets whether a formula (equation) was input into this cell via Excel.
    /// </summary>
    bool HasFormula { get; }
    /// <summary>
    /// Gets whether the contents of this cell are valid.
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
    /// Gets and sets the maximum value for a custom parameter cell.
    /// </summary>
    string CustomRangeMaximum { get; set; }
    /// <summary>
    /// Gets and sets the minimum value for a custom parameter cell.
    /// </summary>
    string CustomRangeMinimum { get; set; }
}

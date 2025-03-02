namespace Oblikovati.API;

/// <summary>
/// The ModelStateTableCell Object.
/// </summary>
public interface ModelStateTableCell
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelStateTable Parent { get; }
    /// <summary>
    /// Read-only property that returns the index of this cell within the parent ModelStatesTableColumn.
    /// </summary>
    int Column { get; }
    /// <summary>
    /// Read-only property that returns the index of this cell within the parent ModelStatesTableRow.
    /// </summary>
    int Row { get; }
    /// <summary>
    /// Read-only property that returns whether a formula(equation) was input into this cell via Excel.
    /// </summary>
    bool HasFormula { get; }
    /// <summary>
    /// Read-only property that returns whether the contents of this cell are valid or not.
    /// </summary>
    bool IsValid { get; }
    /// <summary>
    /// Read-write property that gets and sets the value of the cell.
    /// </summary>
    string Value { get; set; }
}

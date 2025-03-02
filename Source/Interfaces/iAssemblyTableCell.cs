namespace Oblikovati.API;

/// <summary>
/// The iAssemblyTableCell object represents an individual cell in the iAssembly factory table.
/// </summary>
public interface iAssemblyTableCell
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
    /// Property that returns the parent iAssemblyFactory object.
    /// </summary>
    iAssemblyFactory Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the value of the cell.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Property that returns the index of this cell within the parent iAssemblyTableRow.
    /// </summary>
    int Row { get; }
    /// <summary>
    /// Property that returns the index of this cell within the parent iAssemblyTableColumn.
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
}

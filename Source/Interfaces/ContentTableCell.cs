namespace Oblikovati.API;

/// <summary>
/// The ContentTableCell object represents a specific cell with a content center family table.
/// </summary>
public interface ContentTableCell
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the column index of this cell within the parent ContentFamily.
    /// </summary>
    int Column { get; set; }
    /// <summary>
    /// Property that returns the parent ContentFamily object.
    /// </summary>
    ContentFamily Parent { get; }
    /// <summary>
    /// Returns the row index of this cell within the parent ContentFamily.
    /// </summary>
    int Row { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets/Sets the value of the cell.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Property that indicates if the value of this sell has been overwritten from its original value.
    /// </summary>
    bool IsOverridden { get; }
}

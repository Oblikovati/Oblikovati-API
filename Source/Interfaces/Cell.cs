namespace Oblikovati.API;

/// <summary>
/// The Cell object represents an individual cell in the table. A cell is the intersection between a column and a row. See the Custom Tables article in the overviews section for more information.
/// </summary>
public interface Cell
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
    /// Property that returns the parent Table object.
    /// </summary>
    CustomTable Parent { get; }
    /// <summary>
    /// Specifies the value of the cell.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Gets and sets whether or not the contents of this cell are static.
    /// </summary>
    bool Static { get; set; }
}

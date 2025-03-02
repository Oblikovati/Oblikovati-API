namespace Oblikovati.API;

/// <summary>
/// The DrawingBOMCell object represents a cell within the drawing BOM.
/// </summary>
public interface DrawingBOMCell
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent DrawingBOM object.
    /// </summary>
    DrawingBOM Parent { get; }
    /// <summary>
    /// Property that returns whether or not the contents of this cell are static.
    /// </summary>
    bool Static { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the value of the cell.
    /// </summary>
    string Value { get; }
}

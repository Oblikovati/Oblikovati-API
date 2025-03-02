namespace Oblikovati.API;

/// <summary>
/// The TableFormat object contains values for the various overrides of the table's appearance.
/// </summary>
public interface TableFormat
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
    /// Gets and sets the color of the inside lines.
    /// </summary>
    Color InsideLineColor { get; set; }
    /// <summary>
    /// Gets and sets the weight of the inside lines.
    /// </summary>
    double InsideLineWeight { get; set; }
    /// <summary>
    /// Gets and sets the color of the outside lines.
    /// </summary>
    Color OutsideLineColor { get; set; }
    /// <summary>
    /// Gets and sets the weight of the outside lines.
    /// </summary>
    double OutsideLineWeight { get; set; }
    /// <summary>
    /// Gets and sets the text style.
    /// </summary>
    TextStyle TextStyle { get; set; }
}

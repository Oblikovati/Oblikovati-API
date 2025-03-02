namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface HeadsUpDisplayOptions
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
    /// Property that returns the parent SketchOptions object.
    /// </summary>
    SketchOptions Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CreateDimensionsOnValueInput { get; set; }
    /// <summary>
    /// Gets and sets whether to enable dimension input where possible.
    /// </summary>
    bool DimensionInputEnabled { get; set; }
    /// <summary>
    /// Gets and sets whether dimension input is in Cartesian or Polar coordinates.&nbsp;If set to False, input is in Polar coordinates.
    /// </summary>
    bool DimensionInputInCartesianCoordinates { get; set; }
    /// <summary>
    /// Gets and sets whether heads-up display is enabled for sketches.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Gets and sets whether pointer input is enabled for sketches.
    /// </summary>
    bool PointerInputEnabled { get; set; }
    /// <summary>
    /// Gets and sets whether pointer input is in Cartesian or Polar coordinates.&nbsp;If set to False, input is in Polar coordinates.
    /// </summary>
    bool PointerInputInCartesianCoordinates { get; set; }
}

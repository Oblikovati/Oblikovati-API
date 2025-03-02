namespace Oblikovati.API;

/// <summary>
/// The WidthOffsetWidthExtent is used by sheet metal features when the position of a width defined feature is relative to another entity.
/// </summary>
public interface WidthOffsetWidthExtent
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
    /// Property that returns the parent PartFeature of the definition.
    /// </summary>
    PartFeature Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Property that returns the parameter controlling the width of the flange.
    /// </summary>
    Parameter Width { get; }
    /// <summary>
    /// Property that returns the parameter controlling the distance of the flange from the offset entity.
    /// </summary>
    Parameter OffsetDistance { get; }
    /// <summary>
    /// Property that gets and sets the entity the width is measured relative to.
    /// </summary>
    object OffsetEntity { get; }
    /// <summary>
    /// Property that specifies the side of the offset entity the flange is on.
    /// </summary>
    bool PositiveDirection { get; }
}

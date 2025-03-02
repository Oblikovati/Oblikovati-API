namespace Oblikovati.API;

/// <summary>
/// The OffsetWidthExtent is used by sheet metal features when the width of the feature is defined with respect to two entities.
/// </summary>
public interface OffsetWidthExtent
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
    /// Property that returns the parameter controlling the distance of the feature from this offset entity.
    /// </summary>
    Parameter OffsetDistanceOne { get; }
    /// <summary>
    /// Property that returns the parameter controlling the distance of the feature from this offset entity.
    /// </summary>
    Parameter OffsetDistanceTwo { get; }
    /// <summary>
    /// Property that gets and set the entity the width is measured relative to.
    /// </summary>
    object OffsetEntityOne { get; }
    /// <summary>
    /// Property that gets and set the entity the width is measured relative to.
    /// </summary>
    object OffsetEntityTwo { get; }
}

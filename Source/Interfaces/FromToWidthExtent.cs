namespace Oblikovati.API;

/// <summary>
/// The FromToWidthExtent is used by sheet metal features when the width of the feature is defined from one entity to another entity.
/// </summary>
public interface FromToWidthExtent
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
    /// Property that gets and set the entity that defines the 'from' extents of the feature.
    /// </summary>
    object FromEntity { get; }
    /// <summary>
    /// Property that gets and set the entity that defines the 'to' extents of the feature.
    /// </summary>
    object ToEntity { get; }
}

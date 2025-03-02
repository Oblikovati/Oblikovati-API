namespace Oblikovati.API;

/// <summary>
/// The CenteredWidthExtent is used by sheet metal features when the width of the feature is defined using an explicit width and the width is centered along the selected edge.
/// </summary>
public interface CenteredWidthExtent
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
}

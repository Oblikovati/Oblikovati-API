namespace Oblikovati.API;

/// <summary>
/// The ToHeightExtent is used by the FlangeFeature object when the height extent type is defined as a 'To' extent.
/// </summary>
public interface ToHeightExtent
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
    /// Property that returns the parameter controlling the offset distance of the flange relative to the 'To' point.
    /// </summary>
    Parameter Offset { get; }
    /// <summary>
    /// Property that gets and sets the entity defining the 'To' extent.
    /// </summary>
    object ToEntity { get; }
}

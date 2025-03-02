namespace Oblikovati.API;

/// <summary>
/// The PointHolePlacementDefinition object defines the placement of a hole feature using a work point.
/// </summary>
public interface PointHolePlacementDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent PartFeature of the definition. This property returns Nothing in the case where the definition object is created using one of the Create methods on the HoleFeatures object.
    /// </summary>
    HoleFeature Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that indicates the point that defines the hole center. This can only be a WorkPoint.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Property that indicates the entity that defines the hole axis direction. This can be a planar Face object or a WorkPlane object with which the axis of the hole is perpendicular, or an Edge or WorkAxis object with which the axis of the hole is parallel.
    /// </summary>
    object Direction { get; }
}

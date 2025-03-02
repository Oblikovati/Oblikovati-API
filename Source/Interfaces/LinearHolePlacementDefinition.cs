namespace Oblikovati.API;

/// <summary>
/// The LinearHolePlacementDefinition object defines the placement of a hole feature with respect to two linear entities.
/// </summary>
public interface LinearHolePlacementDefinition
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
    /// Property that indicates the plane on which the hole feature is placed. This can be a planar Face object or a WorkPlane object.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Property that indicates the first entity referenced for dimensioning the placement of the hole. This can only be a linear Edge.
    /// </summary>
    object ReferenceEntityOne { get; }
    /// <summary>
    /// Property that returns the parameter controlling the distance of the hole center from the first reference entity.
    /// </summary>
    Parameter DistanceOne { get; }
    /// <summary>
    /// Gets and sets whether the direction of the hole placement with respect to the first reference entity is reversed.
    /// </summary>
    bool DirectionOneReversed { get; set; }
    /// <summary>
    /// Property that indicates the second entity referenced for dimensioning the placement of the hole. This can only be a linear Edge.
    /// </summary>
    object ReferenceEntityTwo { get; }
    /// <summary>
    /// Property that returns the parameter controlling the distance of the hole center from the second reference entity.
    /// </summary>
    Parameter DistanceTwo { get; }
    /// <summary>
    /// Gets and sets whether the direction of the hole placement with respect to the second reference entity is reversed.
    /// </summary>
    bool DirectionTwoReversed { get; set; }
}

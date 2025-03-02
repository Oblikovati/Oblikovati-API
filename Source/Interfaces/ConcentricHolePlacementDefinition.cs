namespace Oblikovati.API;

/// <summary>
/// The ConcentricHolePlacementDefinition object defines the placement of a hole feature with a circular edge or a cylindrical face.
/// </summary>
public interface ConcentricHolePlacementDefinition
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
    /// Property that indicates the Face or WorkPlane on which the hole feature is placed.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Property that indicates the circular Edge or the cylindrical Face which forms the reference for the hole placement.
    /// </summary>
    object ConcentricReference { get; }
}

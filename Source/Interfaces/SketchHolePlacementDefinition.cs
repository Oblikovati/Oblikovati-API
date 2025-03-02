namespace Oblikovati.API;

/// <summary>
/// The SketchHolePlacementDefinition object defines the placement of a hole feature using sketch points.
/// </summary>
public interface SketchHolePlacementDefinition
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
    /// Gets and sets the set of sketch points that define the centers of the holes of this feature.
    /// </summary>
    ObjectCollection HoleCenterPoints { get; set; }
}

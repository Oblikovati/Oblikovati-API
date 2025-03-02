namespace Oblikovati.API;

/// <summary>
/// The ChamferDefinition object is the base class that defines the variables for chamfer features
/// </summary>
public interface ChamferDefinition
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
    /// Property that returns the parent ChamferFeature of the definition.
    /// </summary>
    PartFeature Parent { get; }
    /// <summary>
    /// Gets the type of the definition object used to hold data for chamfer feature.
    /// </summary>
    ChamferDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Gets the collection of edges that are chamfered by this feature.
    /// </summary>
    EdgeCollection ChamferedEdges { get; set; }
    /// <summary>
    /// Gets whether or not to use all tangentially connected edges.
    /// </summary>
    bool AutomaticEdgeChain { get; }
    /// <summary>
    /// Gets whether or not to preserve all features.
    /// </summary>
    bool PreserveAllFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether a setback is to be applied to the chamfer feature.
    /// </summary>
    bool CornerSetback { get; set; }
    /// <summary>
    /// Returns the face used to define the chamfer feature created using a distance and an angle or two distances.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Returns the parameter that controls the distance used for the chamfer feature. This is applicable when the DefinitionType is kDistance.
    /// </summary>
    Parameter Distance { get; }
    /// <summary>
    /// Returns the parameter that controls the angle used for the chamfer feature. This is applicable when the DefinitionType is kDistanceAndAngle.
    /// </summary>
    Parameter Angle { get; }
    /// <summary>
    /// Returns the parameter that controls the first distance used for the chamfer feature. This is applicable when the DefinitionType is kTwoDistances.
    /// </summary>
    Parameter DistanceOne { get; }
    /// <summary>
    /// Returns the parameter that controls the second distance used for the chamfer feature. This is applicable when the DefinitionType is kTwoDistances.
    /// </summary>
    Parameter DistanceTwo { get; }
    /// <summary>
    /// Gets and sets the PartialChamferEdges collection object which defines the partially chamfered edges info.
    /// </summary>
    PartialChamferEdges PartialChamferEdges { get; set; }
    /// <summary>
    /// Create a new transient PartialChamferEdges collection object which can be used to define the partially chamfered edges info.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PartialChamferEdges CreatePartialChamferEdges();
}

namespace Oblikovati.API;

/// <summary>
/// The DistanceChamferDef object provides access to the information that defines the variables for a chamfer feature created using a distance.
/// </summary>
public interface DistanceChamferDef
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ChamferDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    EdgeCollection ChamferedEdges { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AutomaticEdgeChain { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool PreserveAllFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether a setback is to be applied to the chamfer feature.
    /// </summary>
    bool CornerSetback { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Returns the parameter that controls the distance used for the chamfer feature. This is applicable when the DefinitionType is kDistance.
    /// </summary>
    Parameter Distance { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Parameter Angle { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Parameter DistanceOne { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Parameter DistanceTwo { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PartialChamferEdges PartialChamferEdges { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    PartialChamferEdges CreatePartialChamferEdges();
}

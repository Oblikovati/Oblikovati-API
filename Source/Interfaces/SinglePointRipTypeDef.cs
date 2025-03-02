namespace Oblikovati.API;

/// <summary>
/// The SinglePointRipTypeDef object defines the inputs unique to a single point rip feature.
/// </summary>
public interface SinglePointRipTypeDef
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent rip definition feature.
    /// </summary>
    RipDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the point that defines the location of the rip.
    /// </summary>
    object Point { get; set; }
    /// <summary>
    /// Property that returns the parameter controlling the width of the gap. When creating a new rip feature and the RipDefinition object is not associated with an actual feature, this property will return Nothing. You can use the SetSinglePointRipType method of the RipDefinition to set this value in that case. When this object is obtained from an existing rip feature you can edit the rip feature by modifying the parameter this property returns.
    /// </summary>
    Parameter GapSize { get; }
    /// <summary>
    /// Gets and sets the value that indicates the position of the gap.
    /// </summary>
    PartFeatureExtentDirectionEnum GapSide { get; set; }
}

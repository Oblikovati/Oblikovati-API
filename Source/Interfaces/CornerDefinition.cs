namespace Oblikovati.API;

/// <summary>
/// The CornerDefinition object represents all of the information that defines a corner feature.
/// </summary>
public interface CornerDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent CornerFeature object of this CornerDefinition object.
    /// </summary>
    CornerFeature Parent { get; }
    /// <summary>
    /// Gets the width of the gap of a sheet metal corner feature.
    /// </summary>
    object GapWidth { get; set; }
    /// <summary>
    /// Gets the EdgeCollection object that specifies either the two edges that represent the two faces to create the seam between or the set of the create a ripped edge seam on.
    /// </summary>
    EdgeCollection Edges { get; set; }
    /// <summary>
    /// Gets if this corner is a seam or ripped corner.
    /// </summary>
    bool IsRippedCorner { get; set; }
    /// <summary>
    /// Gets how the corner seam or miter is defined.
    /// </summary>
    CornerTypeEnum CornerType { get; set; }
    /// <summary>
    /// Gets and sets the BendOptions object that defines the bend options for this bend feature.
    /// </summary>
    BendOptions BendOptions { get; set; }
    /// <summary>
    /// Gets and sets the CornerDefinition object that defines how the corners are modeled.
    /// </summary>
    CornerOptions CornerOptions { get; set; }
    /// <summary>
    /// Gets and sets how the corner is extened.
    /// </summary>
    bool AlignedCornerExtension { get; set; }
    /// <summary>
    /// Property that specifies the overlap as a percentage of the flange thickness.
    /// </summary>
    double PercentOverlap { get; set; }
    /// <summary>
    /// Property that specifies the geometry that is used to measure the corner seam or miter gap.
    /// </summary>
    CornerDefinitionTypeEnum CornerDefinitionType { get; set; }
    /// <summary>
    /// Function that creates a copy of this CornerDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CornerDefinition Copy();
}

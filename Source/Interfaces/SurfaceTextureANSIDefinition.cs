namespace Oblikovati.API;

/// <summary>
/// SurfaceTextureANSIDefinition Object.
/// </summary>
public interface SurfaceTextureANSIDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Gets and sets whether to add the all-around indicator to the symbol.
    /// </summary>
    bool AllAroundSymbol { get; set; }
    /// <summary>
    /// Gets and sets whether to add a tail to the symbol.
    /// </summary>
    bool IsForceTailShown { get; set; }
    /// <summary>
    /// Gets and sets whether this symbol specifies the standard surface characteristics for the drawing.
    /// </summary>
    bool IsMajority { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DraftingStandardEnum StandardReferenceType { get; }
    /// <summary>
    /// Gets and sets the surface type for the symbol.
    /// </summary>
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    /// <summary>
    /// Returns the standard reference type.
    /// </summary>
    SurfaceTextureStandardReferenceTypeEnum StandardReference { get; }
    /// <summary>
    /// Gets and sets the other maximum roughness value for the surface.
    /// </summary>
    string AdditionalMaxRoughness { get; set; }
    /// <summary>
    /// Gets and sets the other minimum roughness value.
    /// </summary>
    string AdditionalMinRoughness { get; set; }
    /// <summary>
    /// Gets and sets the cutoff value for the surface.
    /// </summary>
    string Cutoff { get; set; }
    /// <summary>
    /// Gets and sets the direction of lay.
    /// </summary>
    LayDirectionTypeEnum LayDirection { get; set; }
    /// <summary>
    /// Gets and sets the process requirements for the surface.
    /// </summary>
    string ProcessNote { get; set; }
    /// <summary>
    /// Gets and sets the machining allowance.
    /// </summary>
    string MachiningAllowance { get; set; }
    /// <summary>
    /// Gets and sets the maximum roughness average value.
    /// </summary>
    string MaximumRoughness { get; set; }
    /// <summary>
    /// Gets and sets the minimum roughness value.
    /// </summary>
    string MinimumRoughness { get; set; }
    /// <summary>
    /// Gets and sets the sampling length for roughness value.
    /// </summary>
    string SamplingLength { get; set; }
}

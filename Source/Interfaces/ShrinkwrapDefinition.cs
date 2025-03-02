namespace Oblikovati.API;

/// <summary>
/// Shrinkwrap Definition Object.
/// </summary>
public interface ShrinkwrapDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets or Sets the name of the active Design View Representation for the shrinkwrap component.
    /// </summary>
    string ActiveDesignViewRepresentation { get; set; }
    /// <summary>
    /// Gets or Sets if there is an associative link to the specified design view.
    /// </summary>
    bool IsAssociativeDesignView { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActiveLevelOfDetailRepresentation { get; set; }
    /// <summary>
    /// Gets or Sets the name of active Positional Representation for the shrinkwrap component.
    /// </summary>
    string ActivePositionalRepresentation { get; set; }
    /// <summary>
    /// Gets or Sets the occurrences being included for the shrinkwrap.
    /// </summary>
    ObjectCollection AdditionalIncludedOccurrences { get; set; }
    /// <summary>
    /// Gets or Sets the occurrences being excluded for the shrinkwrap.
    /// </summary>
    ObjectCollection AdditionalExcludedOccurrences { get; set; }
    /// <summary>
    /// Gets or Sets whether break link to the source assembly or not.
    /// </summary>
    bool BreakLink { get; set; }
    /// <summary>
    /// Gets or Sets whether multi-body part is created when a Boolean operation fails on a single solid body style option.
    /// </summary>
    bool CreateIndependentBodiesOnFailedBoolean { get; set; }
    /// <summary>
    /// Gets or Sets how bodies are derived.
    /// </summary>
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UseColorOverrideFromSourceComponent { get; set; }
    /// <summary>
    /// Gets the full filename of the shrinkwrapped document.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Gets or Sets whether remove all the internal voids or not.
    /// </summary>
    bool RemoveAllInternalVoids { get; set; }
    /// <summary>
    /// Gets or Sets whether rename the component or not.
    /// </summary>
    bool RenameComponent { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool RemovePartsByVisibility { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double RemovePartsVisibilityRatio { get; }
    /// <summary>
    /// Gets or Sets whether remove parts by size or not.
    /// </summary>
    bool RemovePartsBySize { get; set; }
    /// <summary>
    /// Gets or Sets the bounding box diagonal length in centimeters of the parts being removed.
    /// </summary>
    double RemovePartsSize { get; set; }
    /// <summary>
    /// Gets or Sets the style to remove holes for the shrinkwrap.
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemoveHolesStyle { get; set; }
    /// <summary>
    /// Gets or Sets the diameter of holes in centimeters to remove for the shrinkwrap.
    /// </summary>
    double RemoveHolesDiameterRange { get; set; }
    /// <summary>
    /// Gets or Sets the style to remove chamfers for the shrinkwrap.
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemoveChamfersStyle { get; set; }
    /// <summary>
    /// Gets or Sets the distance of chamfers in centimeters to remove for the shrinkwrap.
    /// </summary>
    double RemoveChamfersDistanceRange { get; set; }
    /// <summary>
    /// Gets or Sets the style to remove fillets for the shrinkwrap.
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemoveFilletsStyle { get; set; }
    /// <summary>
    /// Gets or Sets the radius of fillets in centimeters to remove for the shrinkwrap.
    /// </summary>
    double RemoveFilletsRadiusRange { get; set; }
    /// <summary>
    /// Gets or Sets the style to remove chamfers for the shrinkwrap.
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemovePocketsStyle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double RemovePocketsMaxFaceLoopRange { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ShrinkwrapComponent Parent { get; }
    /// <summary>
    /// Gets or Sets the features to preserve from remove.
    /// </summary>
    ObjectCollection PreservedFeatures { get; set; }
    /// <summary>
    /// Read-only property returning kShrinkwrapComponentDefinitionObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets or Sets whether remove internal parts or not.
    /// </summary>
    bool RemoveInternalParts { get; set; }
    /// <summary>
    /// Gets or Sets the max depth of pockets.
    /// </summary>
    double RemovePocketsMaxDepthRange { get; set; }
    /// <summary>
    /// Gets or Sets the max depth of pockets.
    /// </summary>
    double RemoveEmbossMaxHeightRange { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemoveEmbossStyle { get; set; }
    /// <summary>
    /// Gets or Sets the style to remove emboss for the shrinkwrap.
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemoveEmbossesStyle { get; set; }
    /// <summary>
    /// Gets or Sets the style to remove voids for the shrinkwrap.
    /// </summary>
    ShrinkwrapRemoveStyleEnum RemoveTunnelsStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets envelopes replace style. When a new definition is created, this defaults to kNoneReplaceStyle.
    /// </summary>
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; }
    /// <summary>
    /// Read-write property that gets or sets the name of active model state for the shrinkwrap component.
    /// </summary>
    string ActiveModelState { get; set; }
    /// <summary>
    /// Gets or Sets whether use the color override from source component.
    /// </summary>
    bool LinkFaceColorFromSource { get; set; }
    /// <summary>
    /// Method that creates a copy of this ShrinkwrapComponentDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ShrinkwrapDefinition Copy();
}

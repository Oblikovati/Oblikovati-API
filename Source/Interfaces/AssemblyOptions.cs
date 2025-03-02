namespace Oblikovati.API;

/// <summary>
/// The AssemblyOptions object provides access to properties that provide read and write access of the assembly related application options. This is somewhat equivalent to the Assembly tab of the Application Options dialog.
/// </summary>
public interface AssemblyOptions
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
    /// Gets/Sets Opaqueness of Active Component.
    /// </summary>
    bool OnlyActiveComponentIsOpaque { get; set; }
    /// <summary>
    /// Gets/Sets the default adaptive behavior when new features are created.
    /// </summary>
    bool PartFeaturesInitiallyAdaptive { get; set; }
    /// <summary>
    /// Enables or Disables updating assemblies.
    /// </summary>
    bool DeferUpdate { get; set; }
    /// <summary>
    /// Gets/Sets the behavior when deleting pattern elements.
    /// </summary>
    bool DeleteComponentPatternSources { get; set; }
    /// <summary>
    /// Gets/Sets analysis of all assembly components for adaptivity adjustments.
    /// </summary>
    bool EnableConstraintRedundancyAnalysis { get; set; }
    /// <summary>
    /// Enables or Disables sectioning of all parts including standard parts in an assembly.
    /// </summary>
    bool SectionAllParts { get; set; }
    /// <summary>
    /// Enables or Disables automatically creating the feature to the desired size and mating it to the plane.
    /// </summary>
    bool FromToExtentsMatePlane { get; set; }
    /// <summary>
    /// Enables or Disables automatically adapting the in-place feature size or position.
    /// </summary>
    bool FromToExtentsAdaptFeature { get; set; }
    /// <summary>
    /// Enables or disables associative edge/loop geometry projection during in-place modeling.
    /// </summary>
    bool EnableCrossPartEdgeLoopProjection { get; set; }
    /// <summary>
    /// Gets/Sets the default zoom behavior for the graphics window when placing components with iMates.
    /// </summary>
    ZoomTargetComponentWithiMateEnum ZoomTargetComponentWithiMate { get; set; }
    /// <summary>
    /// Enables or Disables audio notifications when creating constraints.
    /// </summary>
    bool ConstraintAudioNotification { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UseiMate { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableRelatedConstraintFailureAnalysis { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LevelOfDetailEnum DefaultLevelOfDetail { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DesignViewTypeEnum DefaultDesignView { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DefaultDesignViewIsAssociative { get; set; }
    /// <summary>
    /// Gets and sets whether the last used orientation should be applied when placing components interactively.
    /// </summary>
    bool UseLastOccurrenceOrientationForPlacement { get; set; }
    /// <summary>
    /// Gets and sets whether component names should be suffixed to constraint names.
    /// </summary>
    bool DisplayComponentNamesInConstraints { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SkipAllUnresolvedFiles { get; set; }
    /// <summary>
    /// Enables or disables associative sketch geometry projection during in-place modeling.
    /// </summary>
    bool EnableCrossPartSketchGeometryProjection { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableAssemblyLite { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AssemblyLiteMinimumUniqueDocument { get; set; }
    /// <summary>
    /// Enables or disables assembly Express workflows.
    /// </summary>
    bool EnableAssemblyExpress { get; set; }
    /// <summary>
    /// Gets and sets the minimum number of unique documents to open in assembly Express mode by default.
    /// </summary>
    int AssemblyExpressMinimumUniqueDocument { get; set; }
    /// <summary>
    /// Place and ground first component at origin.
    /// </summary>
    bool PlaceAndGroundFirstComponentAtOrigin { get; set; }
}

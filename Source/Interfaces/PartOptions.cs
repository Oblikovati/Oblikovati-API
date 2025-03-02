namespace Oblikovati.API;

/// <summary>
/// The PartOptions object provides access to properties that provide read and write access of the part related application options. This is somewhat equivalent to the Part tab of the Application Options dialog.
/// </summary>
public interface PartOptions
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
    /// Enables/disables the behavior of automatically hiding an in-line work feature.
    /// </summary>
    bool AutoHideInLineWorkFeatures { get; set; }
    /// <summary>
    /// Enables/disables whether construction surfaces are displayed opaque or translucent.
    /// </summary>
    bool OpaqueConstructionSurfaces { get; set; }
    /// <summary>
    /// Gets and sets the preference for creating a sketch when a new part file is created.
    /// </summary>
    SketchCreationOnNewPartEnum SketchCreationOnNewPart { get; set; }
    /// <summary>
    /// Gets and Sets the preference for relaxing dimension constraints during 3D grip edit.
    /// </summary>
    DimensionConstraintsRelaxationEnum DimensionConstraintsRelaxation { get; set; }
    /// <summary>
    /// Gets and Sets the preference for breaking geometric constraints during 3D grip edit.
    /// </summary>
    GeometricConstraintsBreakageEnum GeometricConstraintsBreakage { get; set; }
    /// <summary>
    /// Enables/disables automatically consuming work and surface features when they are used as inputs for creating other features.
    /// </summary>
    bool AutoConsumeWorkAndSurfaceFeatures { get; set; }
    /// <summary>
    /// Enables/disables access to 3D grips.
    /// </summary>
    bool Enable3DGrips { get; set; }
    /// <summary>
    /// Enables/disables display of glyphs for 3D grips when faces are selected.
    /// </summary>
    bool DisplayGripsOnSelection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether command to edit base solids in parts launches Inventor Fusion or the legacy Solid Edit environment. This property cannot be set to True if Inventor Fusion is not installed.
    /// </summary>
    bool EditBaseSolidsUsingFusion { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SkipAllUnresolvedFiles { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the default design view representation to use when opening part documents.
    /// </summary>
    DesignViewTypeEnum DefaultDesignView { get; set; }
    /// <summary>
    /// Read-write Boolean property that gets and sets whether the default design view representation is associative.
    /// </summary>
    bool DefaultDesignViewIsAssociative { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to display extended information after the feature name in the browser.
    /// </summary>
    bool DisplayExtendedName { get; set; }
    /// <summary>
    /// Enable/Disable Construction Environment.
    /// </summary>
    bool EnableConstructionEnvironment { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DerivedPartColorOverride { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies whether to link face color from source component or not.
    /// </summary>
    bool LinkFaceColorFromSource { get; set; }
    /// <summary>
    /// Read-write Boolean property that specifies whether to link sketch formatting from source component or not.
    /// </summary>
    bool LinkSketchFormattingFromSource { get; set; }
}

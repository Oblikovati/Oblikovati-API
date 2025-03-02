namespace Oblikovati.API;

/// <summary>
/// The ModelingSettings object provides access to properties that provide read and write access of the various modeling related document specific settings. This is somewhat equivalent to the Modeling tab of the Document Settings dialog.
/// </summary>
public interface ModelingSettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent Document object.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the indicator that part is user adaptive in an assembly.
    /// </summary>
    bool AdaptivelyUsedInAssembly { get; set; }
    /// <summary>
    /// Gets and sets whether the rollback history should be purged when a document is saved.
    /// </summary>
    bool CompactModelHistory { get; set; }
    /// <summary>
    /// Gets and sets the snap angle used in 3D.
    /// </summary>
    string Snap3DAngle { get; set; }
    /// <summary>
    /// Gets and sets the snap distance value in 3D.
    /// </summary>
    string Snap3DDistance { get; set; }
    /// <summary>
    /// Gets and sets the tapped hole diameter.
    /// </summary>
    ModelDiameterFromThreadEnum TappedHoleDiameter { get; set; }
    /// <summary>
    /// Gets and sets the update legacy holes setting.
    /// </summary>
    bool UpdateLegacyHoles { get; set; }
    /// <summary>
    /// Gets and sets the advanced feature validation setting.
    /// </summary>
    bool AdvancedFeatureValidation { get; set; }
    /// <summary>
    /// Gets and sets whether to find errors automatically after manual repair.
    /// </summary>
    bool AutoFindErrorsAfterManualRepair { get; set; }
    /// <summary>
    /// Gets and sets whether sectioning through part is allowed.
    /// </summary>
    bool AllowSectioningThruPart { get; set; }
    /// <summary>
    /// Gets and sets the type of components to use for interactive contact analysis.
    /// </summary>
    InteractiveContactAnalysisEnum InteractiveContactAnalysis { get; set; }
    /// <summary>
    /// Gets and sets the type of surfaces to use for interactive contact analysis.
    /// </summary>
    InteractiveContactSurfacesEnum InteractiveContactSurfaces { get; set; }
    /// <summary>
    /// Gets and sets whether to save enhanced graphics mesh data with the document.
    /// </summary>
    bool MaintainEnhancedGraphicsDetail { get; set; }
    /// <summary>
    /// Gets and sets the naming prefix for solid bodies.
    /// </summary>
    string SolidBodyNamePrefix { get; set; }
    /// <summary>
    /// Gets and sets the naming prefix for surface bodies.
    /// </summary>
    string SurfaceBodyNamePrefix { get; set; }
    /// <summary>
    /// Property that returns the UserCoordinateSystemSettings object. The UserCoordinateSystemSettings object provides access to various UCS related document level settings.
    /// </summary>
    UserCoordinateSystemSettings UserCoordinateSystemSettings { get; }
    /// <summary>
    /// Gets and sets the initial view height (in centimeters) to use when creating a drawing view from this model.
    /// </summary>
    double InitialDrawingViewHeight { get; set; }
    /// <summary>
    /// Gets and sets the initial view width (in centimeters) to use when creating a drawing view from this model.
    /// </summary>
    double InitialDrawingViewWidth { get; set; }
    /// <summary>
    /// Gets and sets whether to show the constraint state in browser.
    /// </summary>
    bool ShowConstraintStateInBrowser { get; set; }
}

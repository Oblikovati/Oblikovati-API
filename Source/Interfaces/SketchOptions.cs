namespace Oblikovati.API;

/// <summary>
/// The SketchOptions object provides access to properties that provide read and write access of the 2D sketch related application options. This is somewhat equivalent to the 2D Sketch portion on the Sketch tab of the Application Options dialog.
/// </summary>
public interface SketchOptions
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
    /// Property that returns the HeadsUpDisplayOptions object. The HeadsUpDisplayOptions object provides access to various heads-up display related application level options for sketches.
    /// </summary>
    HeadsUpDisplayOptions HeadsUpDisplayOptions { get; }
    /// <summary>
    /// Gets/sets the capability to select and project existing geometry to the current sketch by rubbing existing lines.
    /// </summary>
    bool AutoProjectEdges { get; set; }
    /// <summary>
    /// Gets/sets the capability to automatically project edges of the selected face onto the sketch plane as reference geometry, when creating a new sketch.
    /// </summary>
    bool AutomaticReferenceEdges { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ConstraintPriorityEnum ConstraintPriority { get; set; }
    /// <summary>
    /// Enables/disables the display of the sketch plane axes.
    /// </summary>
    bool DisplayAxes { get; set; }
    /// <summary>
    /// Enables/disables the display of the sketch plane coordinate system indicator (triad).
    /// </summary>
    bool DisplayCoordinateSystemIndicator { get; set; }
    /// <summary>
    /// Enables/disables the display of the sketch plane grid lines.
    /// </summary>
    bool DisplayGridLines { get; set; }
    /// <summary>
    /// Enables/disables the display of minor sketch plane grid lines.
    /// </summary>
    bool DisplayMinorGridLines { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EditDimensionWhenCreated { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    OverConstrainedDimensionBehaviorEnum OverConstrainedDimensionBehavior { get; set; }
    /// <summary>
    /// Enables/disables the snap behavior for sketching tasks.
    /// </summary>
    bool SnapToGrid { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ParallelViewOnSketchCreation { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _DeferUpdates { get; set; }
    /// <summary>
    /// Enables/disables&nbsp;projecting the part origin onto a sketch when the sketch is created.
    /// </summary>
    bool AutoProjectPartOrigin { get; set; }
    /// <summary>
    /// Enables/disables whether project objects as construction geometry.
    /// </summary>
    bool ProjectObjectsAsConstructionGeometry { get; set; }
    /// <summary>
    /// Enables/disables whether to auto scale sketch geometries on initial dimension.
    /// </summary>
    bool AutoScaleSketchGeometriesOnInitialDimension { get; set; }
    /// <summary>
    /// Gets/sets the scale for the size of the constraint toolbars with respect to the graphics window.
    /// </summary>
    double ConstraintToolbarScale { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool DisplayCoincidentConstraintsOnCreation { get; set; }
    /// <summary>
    /// Gets/sets whether to infer alignment between endpoints of newly created geometry and points of existing geometry.
    /// </summary>
    bool PointAlignment { get; set; }
    /// <summary>
    /// Gets/sets the default tension for splines in 2d sketches.
    /// </summary>
    int SplineDefaultTension { get; set; }
    /// <summary>
    /// Gets/sets the default fit method for splines in 2d sketches.
    /// </summary>
    SplineFitMethodEnum SplineFitMethod { get; set; }
    /// <summary>
    /// Returns the SketchConstraintSettings object.
    /// </summary>
    SketchConstraintSettings SketchConstraintSettings { get; }
    /// <summary>
    /// Gets/sets the default option for LINK when attaching image.
    /// </summary>
    bool ImageInsertionLINKOptionCheckedAsDefault { get; set; }
    /// <summary>
    /// Enables/disables whether the view is automatically reoriented to be planar to the screen in part environment.
    /// </summary>
    bool ParallelViewOnSketchCreationInPart { get; set; }
    /// <summary>
    /// Enables/disables whether the view is automatically reoriented to be planar to the screen in assembly environment.
    /// </summary>
    bool ParallelViewOnSketchCreationInAssembly { get; set; }
}

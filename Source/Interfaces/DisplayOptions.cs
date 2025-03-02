namespace Oblikovati.API;

/// <summary>
/// The DisplayOptions object provides access to properties that provide read and write access of the display related application options. This is somewhat equivalent to the Display tab of the Application Options dialog.
/// </summary>
public interface DisplayOptions
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
    /// Gets/sets the dimming factor (expressed as a percentage) applied to the display of hidden lines in the model.
    /// </summary>
    int HiddenLineDimmingPercent { get; set; }
    /// <summary>
    /// Gets/sets the number of frames to display for the model during interactive viewing operations like Rotate, Pan and Zoom.
    /// </summary>
    double MinimumFrameRate { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ShadedDisplayOptions ShadedDisplayOptions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    WireframeDisplayOptions WireframeDisplayOptions { get; }
    /// <summary>
    /// Gets/sets the time taken to transition between views of a model.
    /// </summary>
    double ViewTransitionTime { get; set; }
    /// <summary>
    /// Specifies the resolution quality to apply to the display of the model.
    /// </summary>
    DisplayQualityEnum DisplayQuality { get; set; }
    /// <summary>
    /// Gets/sets the zoom direction with respect to the movement of the mouse cursor or mouse wheel.
    /// </summary>
    bool ReverseZoomDirection { get; set; }
    /// <summary>
    /// Gets/sets whether the hidden model edges should be displayed as solid lines.
    /// </summary>
    bool SolidLinesForHiddenEdges { get; set; }
    /// <summary>
    /// Gets/sets whether the cursor position is the focus point for the zoom operation.
    /// </summary>
    bool ZoomToCursor { get; set; }
    /// <summary>
    /// Gets/sets the default behavior for the orbit command.
    /// </summary>
    OrbitTypeEnum DefaultOrbitType { get; set; }
    /// <summary>
    /// Gets/sets the default display mode for new windows.
    /// </summary>
    DisplayModeEnum NewWindowDisplayMode { get; set; }
    /// <summary>
    /// Gets/sets the default projection type for new windows.
    /// </summary>
    ProjectionTypeEnum NewWindowProjectionType { get; set; }
    /// <summary>
    /// Read-write property that enables or disables the depth dimming effect that displays entities that are nearer with a brighter light to better convey the depth of the model. Setting this property to True enables the depth dimming effect.
    /// </summary>
    bool DepthDimming { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to display silhouette edges for active components.
    /// </summary>
    bool DisplaySilhouettes { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the color for the edge display (including silhouettes) for active components.
    /// </summary>
    Color EdgeColor { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the color for the edge display (including silhouettes) for inactive components.
    /// </summary>
    Color InactiveComponentsEdgeColor { get; set; }
    /// <summary>
    /// Read-write property that specifies whether edges should be displayed for inactive components.
    /// </summary>
    bool InactiveComponentsEdgeDisplay { get; set; }
    /// <summary>
    /// Read-write property that enables or disables contrasting shading for the display of inactive components.
    /// </summary>
    bool InactiveComponentsShaded { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the opacity level (expressed as a percentage) for the shading of inactive components.
    /// </summary>
    int InactiveComponentsShadeOpacity { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to display ground planes for new windows.
    /// </summary>
    bool NewWindowShowGroundPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to display ground plane reflections for new windows.
    /// </summary>
    bool NewWindowShowGroundReflections { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to use the display appearance settings defined in the document.&nbsp;If set to False, the application level display settings are used.
    /// </summary>
    bool UseDocumentDisplaySettings { get; set; }
    /// <summary>
    /// Gets and sets whether to display ambient shadows (occlusions) for new windows.
    /// </summary>
    bool NewWindowShowAmbientShadows { get; set; }
    /// <summary>
    /// Gets and sets whether to display ground shadows for new windows.
    /// </summary>
    bool NewWindowShowGroundShadows { get; set; }
    /// <summary>
    /// Gets and sets whether to display object shadows for new windows.
    /// </summary>
    bool NewWindowShowObjectShadows { get; set; }
    /// <summary>
    /// Show/Hide 3D indicator.
    /// </summary>
    bool Show3DIndicator { get; set; }
    /// <summary>
    /// Gets and sets whether to show axis labels for the 3D indicator (triad).
    /// </summary>
    bool ShowXYZAxisLabels { get; set; }
    /// <summary>
    /// Gets and sets whether to enable ray tracing in realistic visual styles for new windows.
    /// </summary>
    bool UseRayTracingForRealisticDisplay { get; set; }
    /// <summary>
    /// Gets and sets the quality used when ray tracing is enabled.
    /// </summary>
    RayTracingQualityEnum RayTracingQuality { get; set; }
    /// <summary>
    /// Gets and sets whether to turn textures on.
    /// </summary>
    bool AreTexturesOn { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool TrackSelection { get; set; }
    /// <summary>
    /// Enable/Disable automatically update referring documents.
    /// </summary>
    bool AutoUpdateReferringDocuments { get; set; }
    /// <summary>
    /// Gets/sets whether to use the nearest model point to the mouse position as orbit pivot.
    /// </summary>
    bool UseNearestModelPointForOrbit { get; set; }
    /// <summary>
    /// Gets/sets whether to use the smooth sketch line.
    /// </summary>
    bool EnableSmoothSketchLines { get; set; }
}

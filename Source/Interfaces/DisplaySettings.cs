namespace Oblikovati.API;

/// <summary>
/// The DisplaySettings object provides access to properties that provide read and write access of the display appearance related document settings. This is somewhat equivalent to the Display Appearance tab of the Document Settings dialog.
/// </summary>
public interface DisplaySettings
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Enables or disables the depth dimming effect that displays entities that are nearer with a brighter light to better convey the depth of the model.
    /// </summary>
    bool DepthDimming { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to display silhouette edges for active components.
    /// </summary>
    bool DisplaySilhouettes { get; set; }
    /// <summary>
    /// Gets and sets the color for the edge display (including silhouettes) for active components.
    /// </summary>
    Color EdgeColor { get; set; }
    /// <summary>
    /// Property that returns the GroundPlaneSettings object. The GroundPlaneSettings object provides access to various settings that define the ground plane.
    /// </summary>
    GroundPlaneSettings GroundPlaneSettings { get; }
    /// <summary>
    /// Gets and sets the dimming factor (expressed as a percentage) applied to the display of hidden lines in the model.
    /// </summary>
    int HiddenLineDimmingPercent { get; set; }
    /// <summary>
    /// Gets and sets the default display mode for new windows.
    /// </summary>
    DisplayModeEnum NewWindowDisplayMode { get; set; }
    /// <summary>
    /// Gets and sets the default projection type for new windows.
    /// </summary>
    ProjectionTypeEnum NewWindowProjectionType { get; set; }
    /// <summary>
    /// Gets and sets whether to display ground planes for new windows.
    /// </summary>
    bool NewWindowShowGroundPlane { get; set; }
    /// <summary>
    /// Gets and sets whether to display ground plane reflections for new windows.
    /// </summary>
    bool NewWindowShowGroundReflections { get; set; }
    /// <summary>
    /// Property that returns the parent Document object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets and sets whether the hidden model edges should be displayed as solid lines.
    /// </summary>
    bool SolidLinesForHiddenEdges { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
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
}

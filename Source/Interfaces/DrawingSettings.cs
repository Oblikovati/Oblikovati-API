namespace Oblikovati.API;

/// <summary>
/// The DrawingSettings object provides access to properties that provide read and write access of the various drawing document specific settings. This is somewhat equivalent to the Drawing tab of the Document Settings dialog.
/// </summary>
public interface DrawingSettings
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
    /// Property that returns the parent DrawingDocument object.
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Gets and sets the state of the DeferUpdates setting.
    /// </summary>
    bool DeferUpdates { get; set; }
    /// <summary>
    /// Gets and sets the state of the invalid annotation highlighting setting.
    /// </summary>
    bool HighlightInvalidAnnotations { get; set; }
    /// <summary>
    /// Gets and sets the printing quality for shaded drawing view when defer update is active.
    /// </summary>
    OfflineImageFidelityEnum OfflineImageFidelity { get; set; }
    /// <summary>
    /// Gets and sets the state of dimension text update alignment.
    /// </summary>
    DimensionTextAlignmentEnum DimensionTextAlignment { get; set; }
    /// <summary>
    /// Gets and sets whether bitmaps should always be used when displaying shaded drawing views.
    /// </summary>
    bool AlwaysUseBitmapsForShadedViews { get; set; }
    /// <summary>
    /// Gets and sets whether orphaned annotations should be preserved and continued to be displayed.
    /// </summary>
    bool PreserveOrphanedAnnotations { get; set; }
    /// <summary>
    /// Gets and sets the color for invalid feature-based annotations.
    /// </summary>
    Color InvalidFeatureBasedAnnotationsColor { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MemorySavingModeEnum MemorySavingMode { get; set; }
    /// <summary>
    /// Gets and sets whether cross hatches should be clipped about drawing annotations.
    /// </summary>
    bool CrossHatchClipping { get; set; }
    /// <summary>
    /// Gets and sets the full file name of the model file that contains custom properties to copy to the active drawing or template.
    /// </summary>
    string CustomPropertySourceFile { get; set; }
    /// <summary>
    /// Property that returns an object that provides properties to set all of the various settings that are used as the default settings for this document when creating automatic centerlines.
    /// </summary>
    AutomatedCenterlineSettings AutomatedCenterlineSettings { get; }
    /// <summary>
    /// Gets and sets whether to apply specular effect or not.
    /// </summary>
    bool ApplySpecularEffect { get; set; }
    /// <summary>
    /// Gets and sets whether the reflection environment will use application options for shaded views.
    /// </summary>
    bool ReflectionEnvironmentUseApplicationOptions { get; set; }
    /// <summary>
    /// Gets and sets the reflection environment file path.
    /// </summary>
    string ReflectionEnvironmentFilePath { get; set; }
    /// <summary>
    /// Gets and sets the bitmap resolution for shaded views.
    /// </summary>
    BitmapResolutionTypeEnum BitmapResolution { get; set; }
}

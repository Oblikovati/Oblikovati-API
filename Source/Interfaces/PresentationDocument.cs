namespace Oblikovati.API;

/// <summary>
/// The PresentationDocument object respesents a presentation document in Inventor.
/// </summary>
public interface PresentationDocument : Document
{
    DisabledCommandList DisabledCommandList { get; }
    /// <summary>
    /// </summary>
    EnvironmentManager EnvironmentManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PresentationExplodedViews PresentationExplodedViews { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PresentationExplodedView ActiveExplodedView { get; }
    /// <summary>
    /// Property that returns the LightingStyles collection object.
    /// </summary>
    LightingStyles LightingStyles { get; }
    /// <summary>
    /// Property that returns the DisplaySettings object. The DisplaySettings object provides access to various display appearance related document settings.
    /// </summary>
    DisplaySettings DisplaySettings { get; }
    /// <summary>
    /// Gets and sets the lighting style to use for the presentation.
    /// </summary>
    LightingStyle ActiveLightingStyle { get; set; }
    /// <summary>
    /// Gets an AssetsEnumerator collection object that contains the appearances associated with the document.
    /// </summary>
    AssetsEnumerator AppearanceAssets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Publications Publications { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Publication ActivePublication { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsMultiTopComponentsDisabled { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PresentationEvents PresentationEvents { get; }
    /// <summary>
    /// Read-only property that returns the PresentationScenes collection object.
    /// </summary>
    PresentationScenes Scenes { get; }
    /// <summary>
    /// Read-only property that returns the active PresentationScene object.
    /// </summary>
    PresentationScene ActiveScene { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string StoryboardName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void CleanupLegacy();
}

namespace Oblikovati.API;

/// <summary>
/// The ColorScheme object represents a single color scheme. It provides access to the various components that make up a color scheme.
/// </summary>
public interface ColorScheme
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
    /// Color property that returns the highlight .
    /// </summary>
    Color HighlightColor { get; }
    /// <summary>
    /// String property that returns the name of the color scheme.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Color property that returns the primary selection .
    /// </summary>
    Color PrimarySelectColor { get; }
    /// <summary>
    /// Color property that returns the secondary selection .
    /// </summary>
    Color SecondarySelectColor { get; }
    /// <summary>
    /// Gets the TertiarySelectColor Color setting.
    /// </summary>
    Color TertiarySelectColor { get; }
    /// <summary>
    /// Property that returns the preview color used when using the 'Join' option during feature creation.
    /// </summary>
    Color JoinPreviewColor { get; }
    /// <summary>
    /// Property that returns the preview color used when using the 'Cut' option during feature creation.
    /// </summary>
    Color CutPreviewColor { get; }
    /// <summary>
    /// Property that returns the preview color used when using the 'Intersect' option during feature creation.
    /// </summary>
    Color IntersectPreviewColor { get; }
    /// <summary>
    /// property that returns the DOF fixed color.
    /// </summary>
    Color DOFFixedColor { get; }
    /// <summary>
    /// Property that returns the DOF free color.
    /// </summary>
    Color DOFFreeColor { get; }
    /// <summary>
    /// Property that returns the background screen color.
    /// </summary>
    Color ScreenColor { get; }
    /// <summary>
    /// Gets and sets the full file name of the image file to be used as the background.
    /// </summary>
    string ImageFullFileName { get; set; }
    /// <summary>
    /// Property that returns the top screen color used when the BackgroundType is set to kGradientBackgroundType.
    /// </summary>
    Color TopScreenColor { get; }
    /// <summary>
    /// Property that returns the bottom screen color used when the BackgroundType is set to kGradientBackgroundType.
    /// </summary>
    Color BottomScreenColor { get; }
    /// <summary>
    /// Property that returns the 2D highlight color.
    /// </summary>
    Color HighlightColor2D { get; }
    /// <summary>
    /// Property that returns the 2D primary selection color.
    /// </summary>
    Color PrimarySelectColor2D { get; }
    /// <summary>
    /// Property that returns the 2D background screen color.
    /// </summary>
    Color ScreenColor2D { get; }
    /// <summary>
    /// Property that returns the 2D top screen color used when the BackgroundType is set to kGradientBackgroundType.
    /// </summary>
    Color TopScreenColor2D { get; }
    /// <summary>
    /// Property that returns the 2D bottom screen color used when the BackgroundType is set to kGradientBackgroundType.
    /// </summary>
    Color BottomScreenColor2D { get; }
    /// <summary>
    /// Gets the 2D&3D sketch dimension color.
    /// </summary>
    Color DimensionColor { get; }
    /// <summary>
    /// Read-write property that gets and sets the image full filename for the reflection map.
    /// </summary>
    string ReflectionEnvironmentFileName { get; set; }
    /// <summary>
    /// Gets the color of the active manipulator glyph.
    /// </summary>
    Color GripHighlightingColor { get; }
    /// <summary>
    /// Read-write property that gets and sets the colors that are used for display separate colors setting. Currently 32 colors are supported for display separate colors.
    /// </summary>
    ObjectCollection DisplaySeparateColors { get; set; }
    /// <summary>
    /// Method that causes this color scheme to become the active color scheme.
    /// </summary>
    [PreserveSig]
    void Activate();
}

namespace Oblikovati.API;

/// <summary>
/// The ColorSchemes object provides access to all of the existing objects. This is somewhat equivalent to the Color tab of the Application Options dialog.
/// </summary>
public interface ColorSchemes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ColorScheme object from the collection.
    /// </summary>
    ColorScheme Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the type of background.
    /// </summary>
    BackgroundTypeEnum BackgroundType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ApplicationFrameColorTypeEnum ApplicationFrameColor { get; set; }
    /// <summary>
    /// Gets and sets the color theme for the icons in the ribbon interface.
    /// </summary>
    IconsColorTypeEnum IconsColor { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InterfaceStyleEnum InterfaceStyle { get; set; }
    /// <summary>
    /// Gets and sets whether the enhanced highlighting option is enabled.
    /// </summary>
    bool EnableEnhancedHighlighting { get; set; }
    /// <summary>
    /// Gets and sets whether enables or disables pre-highlighting during selection.
    /// </summary>
    bool EnablePrehighlight { get; set; }
    /// <summary>
    /// Gets and sets whether enables or disables hidden faces highlighting.
    /// </summary>
    bool HighlightHiddenFaces { get; set; }
}

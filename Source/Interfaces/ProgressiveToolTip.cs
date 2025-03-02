namespace Oblikovati.API;

/// <summary>
/// A ProgressiveToolTip object provides access to enhanced tooltip display for controls in the ribbon interface.
/// </summary>
public interface ProgressiveToolTip
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent of the ControlDefinition object.
    /// </summary>
    ControlDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the short description of the progressive tooltip.
    /// </summary>
    string Description { get; set; }
    /// <summary>
    /// Gets and sets the long&nbsp;description of the progressive tooltip.
    /// </summary>
    string ExpandedDescription { get; set; }
    /// <summary>
    /// Gets and sets the image to use for the progressive tooltip.&nbsp;The standard recommended size is 304 x 188 pixels.&nbsp;This property can either be set to an IPictureDisp object or a string indicating a URI (uniform resource identifier).
    /// </summary>
    object Image { get; set; }
    /// <summary>
    /// Gets and sets whether the second level content (ExpandedDescription and Image) is displayed after a delay.
    /// </summary>
    bool IsProgressive { get; set; }
    /// <summary>
    /// Gets and sets the title of the progressive tooltip.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets and sets the the video clip to use for the progressive tooltip.&nbsp;The standard recommended size is 304 x 188 pixels.&nbsp;This property can either be set to the full file name indicating the video clip or a string indicating a URI (uniform resource identifier).
    /// </summary>
    string Video { get; set; }
}

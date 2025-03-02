namespace Oblikovati.API;

/// <summary>
/// The SheetSettings object provides access to properties that provide read and write access of the various sheet related document specific settings. This is somewhat equivalent to the Sheet tab of the Document Settings dialog.
/// </summary>
public interface SheetSettings
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DraftViewLabel { get; set; }
    /// <summary>
    /// Gets/Sets the default prefix name used for newly created drawing sheets.
    /// </summary>
    string SheetLabel { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ViewLabel { get; set; }
    /// <summary>
    /// Gets/Sets the color used to highlight elements on the drawing sheet when the cursor passes over them.
    /// </summary>
    Color SheetEntityHighlightColor { get; set; }
    /// <summary>
    /// Gets/Sets the color used to illuminate elements on the drawing sheet when they are selected.
    /// </summary>
    Color SheetEntitySelectionColor { get; set; }
    /// <summary>
    /// Gets/Sets the background color used for drawing sheets.
    /// </summary>
    Color SheetColor { get; set; }
    /// <summary>
    /// Gets/Sets the color used for the border of drawing sheets.
    /// </summary>
    Color SheetOutlineColor { get; set; }
}

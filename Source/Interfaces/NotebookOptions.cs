namespace Oblikovati.API;

/// <summary>
/// The NotebookOptions object provides access to properties that provide read and write access of the notebook related application options. This is somewhat equivalent to the Notebook tab of the Application Options dialog.
/// </summary>
public interface NotebookOptions
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
    /// Gets/Sets whether enables or disables displaying icons for design notes in the graphics window.
    /// </summary>
    bool DisplayNoteIcons { get; set; }
    /// <summary>
    /// Gets/Sets whether enables or disables displaying text for design notes.
    /// </summary>
    bool DisplayNoteText { get; set; }
    /// <summary>
    /// Gets/Sets whether design notes associated with model geometry should be retained after the geometry has been deleted.
    /// </summary>
    bool KeepNotesOnDeletedObjects { get; set; }
    /// <summary>
    /// Gets/Sets the background color for the comment boxes in design notes.
    /// </summary>
    Color TextBackgroundColor { get; set; }
    /// <summary>
    /// Gets/Sets the color for arrows in design notes.
    /// </summary>
    Color ArrowColor { get; set; }
    /// <summary>
    /// Gets/Sets the color for the highlighted component in note views.
    /// </summary>
    Color NoteHighlightColor { get; set; }
}

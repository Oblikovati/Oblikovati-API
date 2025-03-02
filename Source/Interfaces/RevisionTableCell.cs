namespace Oblikovati.API;

/// <summary>
/// The RevisionTableCell object represents an individual cell in the revision table.
/// </summary>
public interface RevisionTableCell
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
    /// Property that returns the parent RevisionTable object.
    /// </summary>
    RevisionTable Parent { get; }
    /// <summary>
    /// Gets/Sets the text of the RevisionTable cell.
    /// </summary>
    string Text { get; set; }
    /// <summary>
    /// Gets/Sets formatted text of the RevisionTable cell.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Gets and sets the position (alignment) of the stacked text with respect to regular text.
    /// </summary>
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
}

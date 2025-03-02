namespace Oblikovati.API;

/// <summary>
/// The HoleTag object represents a hole tag associated with a hole table row.
/// </summary>
public interface HoleTag
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
    /// Property that returns the parent HoleTableRow object.
    /// </summary>
    HoleTableRow Parent { get; }
    /// <summary>
    /// Gets/Sets the text of the HoleTag.
    /// </summary>
    string Text { get; set; }
    /// <summary>
    /// Gets/Sets formatted text of the HoleTag.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Property that gets and sets whether the tag is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display the leader line.
    /// </summary>
    bool ShowLeader { get; set; }
    /// <summary>
    /// Gets/Sets the position of the HoleTag on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that gets and sets the associated DimensionStyle object.
    /// </summary>
    DimensionStyle DimensionStyle { get; set; }
    /// <summary>
    /// Property that gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns the Leader object associated with the hole tag.
    /// </summary>
    Leader Leader { get; }
    /// <summary>
    /// Gets and sets the position (alignment) of the stacked text with respect to regular text.
    /// </summary>
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
}

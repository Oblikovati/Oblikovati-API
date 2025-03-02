namespace Oblikovati.API;

/// <summary>
/// The DrawingViewLabel object represents the text in a drawing view label.
/// </summary>
public interface DrawingViewLabel
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    DrawingView Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the color of the text.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the fully formatted string that defines the contents of the drawing view label.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the horizontal justification override of the drawing view label.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the line spacing of the drawing view label.
    /// </summary>
    double LineSpacing { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the method used to define the line spacing.
    /// </summary>
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the position of the label.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that gets the string that defines the drawing view label.
    /// </summary>
    string Text { get; }
    /// <summary>
    /// Read-write property that gets and sets the vertical justification override of the drawing view label.
    /// </summary>
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the width scale factor for the drawing view label.
    /// </summary>
    double WidthScale { get; set; }
    /// <summary>
    /// Gets and sets whether to constrain the view label to the view.
    /// </summary>
    bool ConstrainToBorder { get; set; }
    /// <summary>
    /// Gets and sets the text style associated with the view label.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Gets and sets the layer associated with the view label.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the position (alignment) of the stacked text with respect to regular text.
    /// </summary>
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
}

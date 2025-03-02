namespace Oblikovati.API;

/// <summary>
/// The DimensionText object represents text in a dimension placed on a sheet.
/// </summary>
public interface DimensionText
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets and sets the Color Object of the text.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and sets the formatted text.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Gets and sets the horizontal justification of the text.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    /// <summary>
    /// Gets and sets the line spacing of the text.
    /// </summary>
    double LineSpacing { get; set; }
    /// <summary>
    /// Gets and sets the line spacing method of the text.
    /// </summary>
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    /// <summary>
    /// Gets and sets the origin position of the text.
    /// </summary>
    Point2d Origin { get; set; }
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    DrawingDimension Parent { get; }
    /// <summary>
    /// Property that indicates the string that defines the dimension text. When getting this property, the returned string has all formatting removed and contains the actual text characters displayed in the text. If this property is used to set the text, all format overrides will be removed and the text will revert to the associated text style. Also, the dimension value will always be placed at the beginning of the text. If you want to control the location of the dimension value, use the FormattedText property. The dimension value can be hidden using the HideValue property.
    /// </summary>
    string Text { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the vertical justification of the text.
    /// </summary>
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    /// <summary>
    /// Gets and sets the width scale factor of the text.
    /// </summary>
    double WidthScale { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets and sets the BackgroundColor associated with the DimensionText.
    /// </summary>
    Color BackgroundColor { get; set; }
    /// <summary>
    /// Gets and sets the UseBackgroundColor associated with the DimensionText.
    /// </summary>
    bool UseBackgroundColor { get; set; }
}

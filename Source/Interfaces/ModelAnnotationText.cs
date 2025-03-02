namespace Oblikovati.API;

/// <summary>
/// The ModelAnnotationText object represents text in a model annotation or dimension.
/// </summary>
public interface ModelAnnotationText
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the parent of the object.
    /// </summary>
    ModelAnnotation Parent { get; }
    /// <summary>
    /// Property that gets and sets the color of the annotation text.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Property that gets and sets the default font.
    /// </summary>
    string Font { get; set; }
    /// <summary>
    /// Read-only property that gets the string that defines the dimension text.&nbsp;When getting this property, the returned string has all formatting removed and contains the actual text characters displayed in the text.
    /// </summary>
    string Text { get; }
    /// <summary>
    /// Property that gets and sets the fully formatted string that defines the contents of the dimension text.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Property that gets and sets the horizontal justification override of the annotation text.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    /// <summary>
    /// Property that gets and sets the vertical justification of the ModelAnnotationText.
    /// </summary>
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    /// <summary>
    /// Property that gets and sets the line spacing of the dimension text.
    /// </summary>
    double LineSpacing { get; set; }
    /// <summary>
    /// Property that gets and sets the method used to define the line spacing.
    /// </summary>
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    /// <summary>
    /// Property that gets and sets the position of the origin of the dimension text.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Property that gets and sets the width scale factor for the dimension text.
    /// </summary>
    double WidthScale { get; set; }
    /// <summary>
    /// Property that gets and sets the default size of the text in centimeters.
    /// </summary>
    double Size { get; set; }
    /// <summary>
    /// Property that gets and sets the position (alignment) of the stacked text with respect to regular text.
    /// </summary>
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
}

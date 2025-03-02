namespace Oblikovati.API;

/// <summary>
/// The TextBoxes collection object provides access to all the existing objects in a drawing document and supports methods to create new TextBox objects.
/// </summary>
public interface TextBoxes : IEnumerable
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
    /// Returns a TextBox from the collection.
    /// </summary>
    TextBox Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a text box whose size is defined by the \input points that define opposing diagonals of the text box.
    /// </summary>
    /// <param name="CornerOne">Input Point2d that specifies the first corner of the rectangle.</param>
    /// <param name="CornerTwo">Input Point2d that specifies the diagonal corner of the rectangle.</param>
    /// <param name="FormattedText">Input String that specifies the text of the text box. This string can contain tags that define internal formatting changes, which override the text style of the text box. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="TextStyle">Optional input Variant that specifies which text style to use for the text box. The text style can be specified by providing the name of an existing style or by supplying a TextStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    TextBox AddByRectangle([In] [MarshalAs(UnmanagedType.Interface)] Point2d CornerOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d CornerTwo, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] [MarshalAs(UnmanagedType.Struct)] object? TextStyle = default);
    /// <summary>
    /// Method that creates a text box positioned at the specified point. The size of the resulting text box is just large enough to contain the input text.
    /// </summary>
    /// <param name="Position">Input that specifies the position of the text box. The position of this point in relation to the resulting text string is dependent on the vertical and horizontal justification of the text. For example if the vertical justification is the top and horizontal is the left, then the position point defines the upper\-left corner of the text box. If the vertical justification is the center and the horizontal justification is the center, the position point defines the center of the text box.</param>
    /// <param name="FormattedText">Input String that specifies the text of the text box. This string can contain tags that define internal formatting changes, which override the text style associated with the text box. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="TextStyle">Optional input Variant that specifies which text style to use for the text box. The text style can be specified by providing the name of an existing style or by supplying a TextStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    TextBox AddFitted([In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] [MarshalAs(UnmanagedType.Struct)] object? TextStyle = default);
}

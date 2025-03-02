namespace Oblikovati.API;

/// <summary>
/// GeneralNotes collection object provides access to all of the general notes on the sheet.
/// </summary>
public interface GeneralNotes : IEnumerable
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
    /// Returns the specified GeneralNote object from the collection.
    /// </summary>
    GeneralNote Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a general note whose size is defined by the input points that define opposing diagonals of the note.
    /// </summary>
    /// <param name="CornerOne">Input Point2d that specifies the first corner of the rectangle.</param>
    /// <param name="CornerTwo">Input Point2d that specifies the second corner of the rectangle.</param>
    /// <param name="FormattedText">Input String that specifies the text of the general note. This string can contain tags that define internal formatting changes, which override the text style associated with the general note. The formatting is specified using XML tags within the string. By default, all text in the string will be displayed using the text style assigned to the note. You can use the XML tags to override the default style and apply style overrides for all or portions of the text.
    /// The formatting overrides are defined using tags. There is an opening tag and closing tag for each formatting override you define. The text between the opening and closing tags is affected by the override. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="TextStyle">Optional input Variant that specifies which text style to use for the general note. The text style can be specified by providing the name of an existing style or by supplying a TextStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    GeneralNote AddByRectangle([In] [MarshalAs(UnmanagedType.Interface)] Point2d CornerOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d CornerTwo, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] [MarshalAs(UnmanagedType.Struct)] object? TextStyle = default);
    /// <summary>
    /// Method that creates a fitted general note positioned at the specified point on the sheet.
    /// </summary>
    /// <param name="PlacementPoint">Input Point2d that specifies the position of the general note on the sheet. The position of this point in relation to the resulting text string is dependent on the vertical and horizontal justification of the note. For example if the vertical justification is the top and horizontal is the left, then the position point defines the upper-left corner of the note. If the vertical justification is the center and the horizontal justification is the center, the position point defines the center of the \note.</param>
    /// <param name="FormattedText">Input String that specifies the text of the general note. This string can contain tags that define internal formatting changes, which override the text style associated with the general note. The formatting is specified using XML tags within the string. By default, all text in the string will be displayed using the text style assigned to the note. You can use the XML tags to override the default style and apply style overrides for all or portions of the text.
    /// The formatting overrides are defined using tags. There is an opening tag and closing tag for each formatting override you define. The text between the opening and closing tags is affected by the override. See the list of XML text formatting tags under Reference Topics in the Overviews section.</param>
    /// <param name="TextStyle">Optional input Variant that specifies which text style to use for the general note. The text style can be specified by providing the name of an existing style or by supplying a TextStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    GeneralNote AddFitted([In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.BStr)] string FormattedText, [In] [MarshalAs(UnmanagedType.Struct)] object? TextStyle = default);
}

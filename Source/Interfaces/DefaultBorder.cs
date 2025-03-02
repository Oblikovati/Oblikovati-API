namespace Oblikovati.API;

/// <summary>
/// The DefaultBorder object represents an instance of the default border.
/// </summary>
public interface DefaultBorder
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
    /// Property returning the parent sheet object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property returning the border definition object that this border is an instance of.
    /// </summary>
    BorderDefinition Definition { get; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets and sets the name of the border instance.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the number of horizontal zones to be created for the border.
    /// </summary>
    int HorizontalZoneCount { get; }
    /// <summary>
    /// Property that returns the label style for the horizontal labels. Valid values are kBorderLabelModeAlphabetical, kBorderLabelModeNumeric, and kBorderLabelModeNone.
    /// </summary>
    BorderLabelModeEnum HorizontalZoneLabelMode { get; }
    /// <summary>
    /// Property that returns the number of vertical zones to be created for the border.
    /// </summary>
    int VerticalZoneCount { get; }
    /// <summary>
    /// Property that returns the label style for the vertical labels. Valid values are kBorderLabelModeAlphabetical, kBorderLabelModeNumeric, and kBorderLabelModeNone.
    /// </summary>
    BorderLabelModeEnum VerticalZoneLabelMode { get; }
    /// <summary>
    /// Property that returns whether the zone numbers begin at the bottom-right or top-left corner. A value of True indicates the bottom-right corner and False specifies the top-left.
    /// </summary>
    bool LabelFromBottomRight { get; }
    /// <summary>
    /// Property that returns if delimit zones are indicated by lines or arrowheads. A value of True indicates lines are used and False specifies arrowheads.
    /// </summary>
    bool DelimitZonesByLines { get; }
    /// <summary>
    /// Property that returns the space between the top edge of the sheet and the border line. The distance is specified in centimeters.
    /// </summary>
    double TopMargin { get; }
    /// <summary>
    /// Property that returns the space between the bottom edge of the sheet and the border line. The distance is specified in centimeters.
    /// </summary>
    double BottomMargin { get; }
    /// <summary>
    /// Property that returns the space between the left edge of the sheet and the border line. The distance is specified in centimeters.
    /// </summary>
    double LeftMargin { get; }
    /// <summary>
    /// Property that returns the space between the right edge of the sheet and the border line. The distance is specified in centimeters.
    /// </summary>
    double RightMargin { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double _BorderLineWidth { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _Font { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double _TextLabelHeight { get; }
    /// <summary>
    /// Property that returns if center marks are displayed on the border. A value of True indicates center marks are displayed.
    /// </summary>
    bool Centermarks { get; }
    /// <summary>
    /// Method that deletes the title block from the sheet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that returns the text that is currently displayed for a specific text box. This is useful for text boxes that use input form other sources to define their content, i.e. properties and prompted text. The string displayed within this text box is returned.
    /// </summary>
    /// <param name="DefinitionText">Input object from the referenced TitleBlockDefinition object. This text box is used as in index to specify which text box in the instance to return the text for.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetResultText([In] [MarshalAs(UnmanagedType.Interface)] TextBox DefinitionText);
    /// <summary>
    /// Method that sets the text that was supplied for a specified border that contains prompted text. The string displayed within this border is changed.
    /// </summary>
    /// <param name="DefinitionText">Input TextBox object from the referenced BorderDefinition object. This text box is used to specify which prompted text box to set the text for.</param>
    /// <param name="NewValue">Input String that defines the new text to use for the specified prompted text.</param>
    [PreserveSig]
    void SetPromptResultText([In] [MarshalAs(UnmanagedType.Interface)] TextBox DefinitionText, [In] [MarshalAs(UnmanagedType.BStr)] string NewValue);
}

namespace Oblikovati.API;

/// <summary>
/// The TextStyle object represents a text style in a drawing.
/// </summary>
public interface TextStyle
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DrawingStylesManager _Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the name of the Style.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the internal name of the style. The name is the internal English name of the standard style. This name will remain constant and is not affected by locale. This name is never displayed to the user. Note that this name is not guaranteed to be unique.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that indicates if this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that returns the location of this style, i.e. local to the document, cached locally in the document, exists in the library. Styles that exist in the library cannot be edited.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets the type of the style.
    /// </summary>
    StyleTypeEnum StyleType { get; }
    /// <summary>
    /// Gets and sets comments associated with the style.
    /// </summary>
    string Comments { get; set; }
    /// <summary>
    /// Property returning the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _InUse { get; }
    /// <summary>
    /// Gets and sets the font used for the text style.
    /// </summary>
    string Font { get; set; }
    /// <summary>
    /// Gets and sets the size of the font.&nbsp;The size is specified in centimeters.
    /// </summary>
    double FontSize { get; set; }
    /// <summary>
    /// Gets and sets whether the text style has bold formatting or not.&nbsp;True if the text style has bold formatting.
    /// </summary>
    bool Bold { get; set; }
    /// <summary>
    /// Gets and sets whether the text style has italic formatting or not.&nbsp;True if the text style has italic formatting.
    /// </summary>
    bool Italic { get; set; }
    /// <summary>
    /// Gets and sets whether the text style has underline formatting or not.&nbsp;True if the text style has underline formatting.
    /// </summary>
    bool Underline { get; set; }
    /// <summary>
    /// Gets and sets the horizontal justification of the text style.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    /// <summary>
    /// Gets and sets the vertical justification of the text style.
    /// </summary>
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    /// <summary>
    /// Gets and sets the width scale factor for the text style.&nbsp;This is also referred to as the 'stretch factor'. A value of 1.0 will display the text as designed; a value of 0.5 will decrease the width of the text by 50%.
    /// </summary>
    double WidthScale { get; set; }
    /// <summary>
    /// Gets and sets the rotation of the text style.&nbsp;The units used to define the rotation angle are radians.&nbsp;Currently text rotation is limited to 90 degree increments so valid values for this property are 0, pi/2, pi, and 1.5pi.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Gets and sets the method used to define the line spacing.
    /// </summary>
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    /// <summary>
    /// Gets and sets the line spacing of the text style.
    /// </summary>
    double LineSpacing { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    StyleLocationEnum _StyleLocation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _UpToDate { get; }
    /// <summary>
    /// Gets and sets the current color of the text.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Method that deletes the Style/Layer/UnfoldMethod.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Style ConvertToLocal();
    /// <summary>
    /// Method that creates a new local Style object. The newly created style is returned.
    /// </summary>
    /// <param name="Name">Input String that specifies the name for the new style. This name must be unique with respect to all other styles of a similar type in the document. That is, if a dimension style is being copied, the name must be unique with respect to all the other dimension styles. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    Style Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    [PreserveSig]
    TextStyle _Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetColor([Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    TextStyle _ConvertToLocal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _SaveToGlobal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _UpdateFromGlobal();
}

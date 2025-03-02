namespace Oblikovati.API;

/// <summary>
/// The TextBox object represents text on a sheet or sketch.
/// </summary>
public interface TextBox
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    Sketch Parent { get; }
    /// <summary>
    /// Gets and sets the fully formatted string that defines the contents of the text box.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Gets and sets the string that defines the contents of the text box.
    /// </summary>
    string Text { get; set; }
    /// <summary>
    /// Gets/Sets the text style associated with the text box.
    /// </summary>
    TextStyle Style { get; set; }
    /// <summary>
    /// Gets and sets the horizontal justification override of the text box.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    /// <summary>
    /// Gets and sets the vertical justification override of the text box.
    /// </summary>
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    /// <summary>
    /// Gets and sets override stretch factor for the text box.
    /// </summary>
    double WidthScale { get; set; }
    /// <summary>
    /// Gets and sets the override rotation of the text box.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Property that returns if the text box remains tightly fitted to the text within the box. True indicates the text box just encloses the text.
    /// </summary>
    bool Fitted { get; }
    /// <summary>
    /// Property that returns the actual height of the text within the text box. This does not necessarily represent the current height of the text box, but only the text within the box. If the Fitted property is True then this value is the same as the height of the text box.
    /// </summary>
    double FittedTextHeight { get; }
    /// <summary>
    /// Property that returns the actual width of the text within the text box. This does not necessarily represent the current width of the text box, but only the text within the box. If the Fitted property is True then this value is the same as the width of the text box.
    /// </summary>
    double FittedTextWidth { get; }
    /// <summary>
    /// Gets and sets the position of upper-left corner of the text box.
    /// </summary>
    Point2d Origin { get; set; }
    /// <summary>
    /// Gets the SketchPoint on the origin of this TextBox. This will be Nothing in the case that the boundaries are displayed
    /// </summary>
    SketchPoint OriginSketchPoint { get; }
    /// <summary>
    /// Gets and sets the width of the text box.
    /// </summary>
    double Width { get; set; }
    /// <summary>
    /// Gets and sets the height of the text box.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Gets and sets the method used to define the line spacing.
    /// </summary>
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    /// <summary>
    /// Gets and sets the line spacing of the text box.
    /// </summary>
    double LineSpacing { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets whether boundary geometry is displayed for the text box.
    /// </summary>
    bool ShowBoundaries { get; set; }
    /// <summary>
    /// Property that returns the four construction sketch lines that form the boundary of the text box.
    /// </summary>
    SketchEntitiesEnumerator BoundaryGeometry { get; }
    /// <summary>
    /// Gets and sets the layer applied to this text box.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets/Sets the color of the text box.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets/Sets the single line text option.&nbsp;If True, all line breaks are removed from multi-line text.
    /// </summary>
    bool SingleLineText { get; set; }
    /// <summary>
    /// Gets and sets the position (alignment) of the stacked text with respect to regular text.
    /// </summary>
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Property that returns the sketch block that contains this object. This is the same SketchBlock returned as the last item in the SketchBlockPath property. This property returns Nothing if this object does not belong to a sketch block and lives directly under a sketch.
    /// </summary>
    SketchBlock ContainingSketchBlock { get; }
    /// <summary>
    /// Property that returns the path of sketch blocks at the leaf of which this sketch object is found. The enumerator returns a count of 0 if the object lives directly under a sketch.
    /// </summary>
    SketchBlocksEnumerator SketchBlockPath { get; }
    /// <summary>
    /// Gets/Sets the BackgroundColor associated with the TextBox.
    /// </summary>
    Color BackgroundColor { get; set; }
    /// <summary>
    /// Gets/Sets the UseBackgroundColor associated with the TextBox.
    /// </summary>
    bool UseBackgroundColor { get; set; }
    /// <summary>
    /// Method that deletes the text box.
    /// </summary>
    [PreserveSig]
    void Delete();
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
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void SetColor([In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void GetFacetsInfo([Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
    /// <summary>
    /// Method that converts the text box to sketch geometries.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator ConvertToGeometry([In] [MarshalAs(UnmanagedType.BStr)] string SHXFont, [In] [MarshalAs(UnmanagedType.Struct)] object? UseBigFont = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BigFont = default);
}

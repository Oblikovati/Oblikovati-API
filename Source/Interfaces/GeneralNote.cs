namespace Oblikovati.API;

/// <summary>
/// The GeneralNote object represents a general note on a sheet and derives from the DrawingNote object.
/// </summary>
public interface GeneralNote
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
    /// Property that returns the parent sheet of the object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/Sets color of the DrawingNote.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets/Sets&nbsp;text of the DrawingNote.
    /// </summary>
    string Text { get; set; }
    /// <summary>
    /// Gets/Sets formatted text of the DrawingNote.
    /// </summary>
    string FormattedText { get; set; }
    /// <summary>
    /// Gets/Sets horizontal justification of the DrawingNote.
    /// </summary>
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    /// <summary>
    /// Gets/Sets vertical justification of the DrawingNote.
    /// </summary>
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    /// <summary>
    /// Gets/Sets the layer used by the DrawingNote.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets/Sets the LineSpacing used by the DrawingNote.
    /// </summary>
    double LineSpacing { get; set; }
    /// <summary>
    /// Gets/Sets the LineSpacingType used by the DrawingNote.
    /// </summary>
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    /// <summary>
    /// Gets/Sets the position of the DrawingNote on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Gets/Sets the width scale factor of the DrawingNote.
    /// </summary>
    double WidthScale { get; set; }
    /// <summary>
    /// Gets and sets the position (alignment) of the stacked text with respect to regular text.
    /// </summary>
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GeometryIntent _AttachedEntity { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Property that returns whether the note remains tightly fitted to the text within the box.
    /// </summary>
    bool Fitted { get; }
    /// <summary>
    /// Property that returns the actual height of the text within the note. This does not necessarily represent the current height of the note, but only the text within the note. If the Fitted property is True then this value is the same as the height of the note.
    /// </summary>
    double FittedTextHeight { get; }
    /// <summary>
    /// Property that returns the actual width of the text within the note. This does not necessarily represent the current width of the note, but only the text within the note. If the Fitted property is True then this value is the same as the width of the note.
    /// </summary>
    double FittedTextWidth { get; }
    /// <summary>
    /// Gets/Sets the height of the GeneralNote.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Gets/Sets the rotation of the GeneralNote.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Gets/Sets the TextStyle of the GeneralNote.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Gets/Sets the width of the GeneralNote.
    /// </summary>
    double Width { get; set; }
    /// <summary>
    /// Get the unit attributes associated with the GeneralNote.
    /// </summary>
    UnitAttributes UnitAttributes { get; }
    /// <summary>
    /// Gets/Sets the BackgroundColor associated with the GeneralNote.
    /// </summary>
    Color BackgroundColor { get; set; }
    /// <summary>
    /// Gets/Sets the UseBackgroundColor associated with the GeneralNote.
    /// </summary>
    bool UseBackgroundColor { get; set; }
    /// <summary>
    /// Gets/Sets whether to show the text border or not.
    /// </summary>
    bool ShowTextBorder { get; set; }
    /// <summary>
    /// Indicates whether the drawing note was created as a result of retrieving it from the model.
    /// </summary>
    bool Retrieved { get; }
    /// <summary>
    /// Returns the model annotation this drawing note was retrieved from.
    /// </summary>
    object RetrievedFrom { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the DrawingNote.
    /// </summary>
    [PreserveSig]
    void Delete();
}
